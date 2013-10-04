using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class SeasonRepository : Infrastructure.Data.MainModule.Repositories.ISeasonRepository
    {
        private readonly ScheduleApiContext _context;

        public SeasonRepository()
        {
            _context = new ScheduleApiContext();
        }

        public Season Add(Season item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            item.ClientToken = guid;

            var addedItem = _context.Seasons.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Season Update(Season item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToUpdate = _context.Seasons.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            itemToUpdate.Start = item.Start;

            itemToUpdate.End = item.End;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Season Delete(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToDelete = _context.Seasons.FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            var deletedItem = _context.Seasons.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Season> List(string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var items = _context.Seasons.Where(b => b.ClientToken == guid);

            return items;
        }

        public Season Get(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.Seasons.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            return item;
        }
    }
}
