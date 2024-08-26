using ApplicationRequest.Core.Abstractions;
using ApplicationRequest.Core.Models;
using ApplicationRequest.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationRequest.DataAccess.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly ApplicationRequestDbContext _dbContext;

        public RequestRepository(ApplicationRequestDbContext dbContext)
        {
           _dbContext = dbContext;
        }

        public async Task<List<Request>> GetListAsync()
        {
            var entity = await _dbContext.RequestEntities.AsNoTracking().ToListAsync();
            var requests = entity
                .Select(r => Request.Create(r.Id, r.UserId, r.AnimalId, r.Status))
                .ToList();
            return requests;
        }
        public async Task<long> CreateAsync (Request request)
        {
            var requestEntity = new RequestEntity
            {
                Id = request.Id,
                UserId = request.UserId,
                AnimalId = request.AnimalId,
                Status = request.Status
            };
            await _dbContext.RequestEntities.AddAsync(requestEntity);
            await _dbContext.SaveChangesAsync();
            return requestEntity.Id;
        }

        public async Task Delete(Request request)
        {
            var entity = await _dbContext.RequestEntities.AsNoTracking().FirstOrDefaultAsync(r => r.Id == request.Id);
            if (entity != null)
            {
                 _dbContext.RequestEntities.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Request> GetByIdAsync (long id)
        {
            var entyties = await GetListAsync();
            var request = entyties.FirstOrDefault(r=>r.Id ==  id);
            return request;
        }

        public async Task<long> UpdateAsync(Request request)
        {
            if (request != null)
            {
                var requestEntity = new RequestEntity
                {
                    Id = request.Id,
                    UserId = request.UserId,
                    AnimalId = request.AnimalId,
                    Status = request.Status
                };
                _dbContext.RequestEntities.Update(requestEntity);
                await _dbContext.SaveChangesAsync();
            }
            return request.Id;
        }

    }
}
