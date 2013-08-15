using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IShiftTypeRepository
    {
        Infrastructure.Data.MainModule.Models.ShiftType Add(Infrastructure.Data.MainModule.Models.ShiftType item);
        Infrastructure.Data.MainModule.Models.ShiftType Delete(int id);
        Infrastructure.Data.MainModule.Models.ShiftType Get(int id);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.ShiftType> List();
        Infrastructure.Data.MainModule.Models.ShiftType Update(Infrastructure.Data.MainModule.Models.ShiftType item);
    }
}
