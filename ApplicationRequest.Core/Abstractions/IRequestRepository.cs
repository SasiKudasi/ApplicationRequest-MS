using ApplicationRequest.Core.Models;


namespace ApplicationRequest.Core.Abstractions
{
    public interface IRequestRepository
    {
        public Task<List<Request>> GetListAsync();
        public Task<long> CreateAsync(Request request);
        public Task Delete(Request request);
        public Task<Request> GetByIdAsync(long id);
        public Task<long> UpdateAsync(Request request);
    }
}
