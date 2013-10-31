using System;
using System.Collections.Generic;
using Infrastructure.Data.MainModule.Models;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IShiftTimeRepository
    {
        ShiftTime Add(ShiftTime item, string clientToken);
        ShiftTime Delete(int id, string clientToken);
        ShiftTime Get(int id, string clientToken);
        IEnumerable<ShiftTime> List(string clientToken);
        ShiftTime Update(ShiftTime item, string clientToken);
    }
}
