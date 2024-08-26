using ApplicationRequest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRequest.Core.Abstractions
{
    public interface IRequestRepository
    {
        public Task<List<Request>> GetRequestListAsync();
        public Task<long> CreateRequestAsync(Request request);
        public Task DeleteRequest(Request request);
        public Task<Request> GetByIdRequestAsync(long id);
        public Task<long> UpdateRequestAsync(Request request);



    }
}
