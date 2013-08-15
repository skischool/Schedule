using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IShiftRepository
    {
        Infrastructure.Data.MainModule.Models.Shift Add(Infrastructure.Data.MainModule.Models.Shift item);
        Infrastructure.Data.MainModule.Models.Shift Delete(int id);
        Infrastructure.Data.MainModule.Models.Shift Get(int id);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Shift> List();
        Infrastructure.Data.MainModule.Models.Shift Update(Infrastructure.Data.MainModule.Models.Shift item);
    }
}
