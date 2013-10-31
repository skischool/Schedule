using System;
using System.Collections.Generic;
using Infrastructure.Data.MainModule.Models;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IShiftTypeRepository
    {
        ShiftType Add(ShiftType item, string clientToken);
        ShiftType Delete(int id, string clientToken);
        ShiftType Get(int id, string clientToken);
        IEnumerable<ShiftType> List(string clientToken);
        ShiftType Update(ShiftType item, string clientToken);
    }
}
