using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IShiftRepository
    {
        Infrastructure.Data.MainModule.Models.Shift Add(Infrastructure.Data.MainModule.Models.Shift item, string clientToken);
        Infrastructure.Data.MainModule.Models.Shift Delete(int id, string clientToken);
        Infrastructure.Data.MainModule.Models.Shift Get(int id, string clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Shift> List(string clientToken);
        Infrastructure.Data.MainModule.Models.Shift Update(Infrastructure.Data.MainModule.Models.Shift item, string clientToken);
    }
}
