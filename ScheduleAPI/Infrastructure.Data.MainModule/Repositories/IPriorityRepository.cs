using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IPriorityRepository
    {
        Infrastructure.Data.MainModule.Models.Priority Add(Infrastructure.Data.MainModule.Models.Priority item);
        Infrastructure.Data.MainModule.Models.Priority Delete(int id);
        Infrastructure.Data.MainModule.Models.Priority Get(int id);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Priority> List();
        Infrastructure.Data.MainModule.Models.Priority Update(Infrastructure.Data.MainModule.Models.Priority item);
    }
}
