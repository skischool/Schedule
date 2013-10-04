using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface ISeasonRepository
    {
        Infrastructure.Data.MainModule.Models.Season Add(Infrastructure.Data.MainModule.Models.Season item, string clientToken);
        Infrastructure.Data.MainModule.Models.Season Delete(int id, string clientToken);
        Infrastructure.Data.MainModule.Models.Season Get(int id, string clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Season> List(string clientToken);
        Infrastructure.Data.MainModule.Models.Season Update(Infrastructure.Data.MainModule.Models.Season item, string clientToken);
    }
}
