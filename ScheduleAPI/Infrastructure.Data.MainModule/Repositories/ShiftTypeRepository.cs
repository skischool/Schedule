using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class ShiftTypeRepository : Infrastructure.Data.MainModule.Repositories.IShiftTypeRepository
    {
        private readonly ScheduleApiContext _context;

        public ShiftTypeRepository()
        {
            _context = new ScheduleApiContext();
        }

        public ShiftType Add(ShiftType item, string clientToken)
        {
            item.ClientToken = Guid.Parse(clientToken);

            var addedItem = _context.ShiftTypes.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public ShiftType Update(ShiftType item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToUpdate = _context.ShiftTypes.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public ShiftType Delete(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToDelete = _context.ShiftTypes.FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            var deletedItem = _context.ShiftTypes.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<ShiftType> List(string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var items = _context.ShiftTypes.Where(b => b.ClientToken == guid);

            return items;
        }

        public ShiftType Get(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.ShiftTypes.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            return item;
        }
    }
}
