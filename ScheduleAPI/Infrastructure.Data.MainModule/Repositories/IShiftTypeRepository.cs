using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IShiftTypeRepository
    {
        Infrastructure.Data.MainModule.Models.ShiftType Add(Infrastructure.Data.MainModule.Models.ShiftType item, string clientToken);
        Infrastructure.Data.MainModule.Models.ShiftType Delete(int id, string clientToken);
        Infrastructure.Data.MainModule.Models.ShiftType Get(int id, string clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.ShiftType> List(string clientToken);
        Infrastructure.Data.MainModule.Models.ShiftType Update(Infrastructure.Data.MainModule.Models.ShiftType item, string clientToken);
    }
}
