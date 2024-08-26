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
            return await _reposytory.GetRequestListAsync();
        }
        public async Task<long> CreateRequestAsync(Request request)
        {
            return await _reposytory.CreateRequestAsync(request);
        }

        public async Task DeleteRequest(Request request)
        {
            await _reposytory.DeleteRequest(request);
        }
        public async Task<Request> GetByIdRequestAsync(long id)
        {
            return await _reposytory.GetByIdRequestAsync(id);
        }
        public async Task<long> UpdateRequestAsync(Request request)
        {
            return await _reposytory.UpdateRequestAsync(request);
        }
    }
}
