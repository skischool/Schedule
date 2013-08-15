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

        public Season Add(Season item)
        {
            var addedItem = _context.Seasons.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Season Update(Season item)
        {
            var itemToUpdate = _context.Seasons.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            itemToUpdate.Start = item.Start;

            itemToUpdate.End = item.End;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Season Delete(int id)
        {
            var itemToDelete = _context.Seasons.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.Seasons.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Season> List()
        {
            var items = _context.Seasons;

            return items;
        }

        public Season Get(int id)
        {
            var item = _context.Seasons.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
