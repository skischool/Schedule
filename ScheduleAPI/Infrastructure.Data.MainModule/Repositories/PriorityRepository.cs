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

        public Priority Add(Priority item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            item.ClientToken = guid;

            var addedItem = _context.Priorities.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Priority Update(Priority item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToUpdate = _context.Priorities.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Priority Delete(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToDelete = _context.Priorities.FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            var deletedItem = _context.Priorities.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Priority> List(string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var items = _context.Priorities.Where(b => b.ClientToken == guid);

            return items;
        }

        public Priority Get(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.Priorities.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            return item;
        }
    }
}
