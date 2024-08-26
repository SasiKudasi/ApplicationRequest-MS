using ApplicationRequest.Core.Abstractions;
using ApplicationRequest.Core.Models;

namespace ApplicationRequest.Application.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _reposytory;

        public RequestService(IRequestRepository repository)
        {
            _reposytory = repository;
        }

        public async Task<List<Request>> GetRequestListAsync()
        {
            return await _reposytory.GetListAsync();
        }
        public async Task<long> CreateRequestAsync(Request request)
        {
            return await _reposytory.CreateAsync(request);
        }

        public async Task DeleteRequest(Request request)
        {
            await _reposytory.Delete(request);
        }
        public async Task<Request> GetByIdRequestAsync(long id)
        {
            return await _reposytory.GetByIdAsync(id);
        }
        public async Task<long> UpdateRequestAsync(Request request)
        {
            return await _reposytory.UpdateAsync(request);
        }
    }
}
