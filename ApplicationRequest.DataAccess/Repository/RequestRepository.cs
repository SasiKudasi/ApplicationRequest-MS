using ApplicationRequest.Core.Models;
using ApplicationRequest.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRequest.DataAccess.Repository
{
    public class RequestRepository
    {
        private readonly ApplicationRequestDbContext _dbContext;

        public RequestRepository(ApplicationRequestDbContext dbContext)
        {
           _dbContext = dbContext;
        }

        public async Task<List<Request>> GetRequestListAsync()
        {
            var entity = await _dbContext.RequestEntities.AsNoTracking().ToListAsync();
            var requests = entity
                .Select(r => Request.Create(r.Id, r.UserId, r.AnimalId, r.Status))
                .ToList();
            return requests;
        }
        public async Task<long> CreateRequestAsync (Request request)
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



    }
}
