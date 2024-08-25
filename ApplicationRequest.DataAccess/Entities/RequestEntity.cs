using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRequest.DataAccess.Entities
{
    public class RequestEntity
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long AnimalId { get; set; }
        public string Status { get; set; } = "New";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

    }
}
