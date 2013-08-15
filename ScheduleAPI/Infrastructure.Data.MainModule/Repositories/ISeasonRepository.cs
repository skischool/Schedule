using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface ISeasonRepository
    {
        Infrastructure.Data.MainModule.Models.Season Add(Infrastructure.Data.MainModule.Models.Season item);
        Infrastructure.Data.MainModule.Models.Season Delete(int id);
        Infrastructure.Data.MainModule.Models.Season Get(int id);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Season> List();
        Infrastructure.Data.MainModule.Models.Season Update(Infrastructure.Data.MainModule.Models.Season item);
    }
}
