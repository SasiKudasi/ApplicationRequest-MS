using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRequest.Core.Models
{
    public class Request
    {
        public long Id { get; }
        public long UserId { get; }
        public long AnimalId { get; }
        public string Status { get; } = "New";

        /* пока не знаю как будет ставиться время 
         CreatedAt навереное можно в конструктор не передавать и ставить дефолт (Now)
         а вот что делать с датой обновления - пока ХеЗе :(
         */
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; } = DateTime.Now;

        public Request(long id, long userId, long animalId, string status)
        {
            Id = id;
            UserId = userId;
            AnimalId = animalId;
            Status = status;
        }

        public static Request Create (long id, long userId, long animalId, string status)
        {
            /*
             * подумать о какой то валидации данных
             */
            return new Request(id, userId, animalId, status);
        }
    }
}
