using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedServices.Api.Mappings
{
    public static class Mapper
    {
        public static Entities.Dto.Shift Map(Infrastructure.Data.MainModule.Models.Shift item)
        {
            if (item == null)
                return new Entities.Dto.Shift();
            
            var dto = new Entities.Dto.Shift()
            {
                ClientId = item.ClientId,
                Id = item.Id,
                Date = item.Date,
                Start = item.Start,
                End = item.End,
                SeasonId = item.SeasonId,
                PriorityId = item.PriorityId,
                Season = Mapper.Map(item.Season),
                Priority = Mapper.Map(item.Priority),
                ShiftType = Mapper.Map(item.ShiftType)
            };

            return dto;
        }

        public static DistributedServices.Entities.Dto.Season Map(Infrastructure.Data.MainModule.Models.Season item)
        {
            if (item == null)
                return new Entities.Dto.Season();
            
            var dto = new Entities.Dto.Season()
            {
                Name = item.Name,
                Description = item.Description,
                Start = item.Start,
                End = item.End,
                Id = item.Id
            };

            return dto;
        }

        public static DistributedServices.Entities.Dto.Priority Map(Infrastructure.Data.MainModule.Models.Priority item)
        {
            if (item == null)
                return new Entities.Dto.Priority();
            
            var dto = new Entities.Dto.Priority()
            {
                Name = item.Name,
                Description = item.Description,
                Id = item.Id
            };

            return dto;
        }

        public static DistributedServices.Entities.Dto.ShiftType Map(Infrastructure.Data.MainModule.Models.ShiftType item)
        {
            if (item == null)
                return new Entities.Dto.ShiftType();
            
            var dto = new Entities.Dto.ShiftType()
            {
                Name = item.Name,
                Description = item.Description,
                Id = item.Id
            };

            return dto;
        }
    }
}