using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class PriorityRepository : Infrastructure.Data.MainModule.Repositories.IPriorityRepository
    {
        private readonly ScheduleApiContext _context;

        public PriorityRepository()
        {
            _context = new ScheduleApiContext();
        }

        public Priority Add(Priority item)
        {
            var addedItem = _context.Priorities.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Priority Update(Priority item)
        {
            var itemToUpdate = _context.Priorities.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Priority Delete(int id)
        {
            var itemToDelete = _context.Priorities.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.Priorities.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Priority> List()
        {
            var items = _context.Priorities;

            return items;
        }

        public Priority Get(int id)
        {
            var item = _context.Priorities.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
