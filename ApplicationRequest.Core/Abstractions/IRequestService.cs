using ApplicationRequest.Core.Models;


namespace ApplicationRequest.Core.Abstractions
{
    public interface IRequestService
    {
        public Task<List<Request>> GetRequestListAsync();
        public Task<long> CreateRequestAsync(Request request);
        public Task DeleteRequest(Request request);
        public Task<Request> GetByIdRequestAsync(long id);
        public Task<long> UpdateRequestAsync(Request request);
    }
}
