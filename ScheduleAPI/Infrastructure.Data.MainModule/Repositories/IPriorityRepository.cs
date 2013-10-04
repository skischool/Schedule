using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IPriorityRepository
    {
        Infrastructure.Data.MainModule.Models.Priority Add(Infrastructure.Data.MainModule.Models.Priority item, string clientToken);
        Infrastructure.Data.MainModule.Models.Priority Delete(int id, string clientToken);
        Infrastructure.Data.MainModule.Models.Priority Get(int id, string clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Priority> List(string clientToken);
        Infrastructure.Data.MainModule.Models.Priority Update(Infrastructure.Data.MainModule.Models.Priority item, string clientToken);
    }
}
