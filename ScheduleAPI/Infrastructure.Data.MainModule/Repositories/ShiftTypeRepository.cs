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

        public ShiftType Add(ShiftType item)
        {
            var addedItem = _context.ShiftTypes.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public ShiftType Update(ShiftType item)
        {
            var itemToUpdate = _context.ShiftTypes.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public ShiftType Delete(int id)
        {
            var itemToDelete = _context.ShiftTypes.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.ShiftTypes.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<ShiftType> List()
        {
            var items = _context.ShiftTypes;

            return items;
        }

        public ShiftType Get(int id)
        {
            var item = _context.ShiftTypes.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
