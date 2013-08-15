using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class ShiftRepository : Infrastructure.Data.MainModule.Repositories.IShiftRepository
    {
        private readonly ScheduleApiContext _context;

        public ShiftRepository()
        {
            _context = new ScheduleApiContext();
        }

        public Shift Add(Shift item)
        {
            var addedItem = _context.Shifts.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Shift Update(Shift item)
        {
            var itemToUpdate = _context.Shifts.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.ClientId = item.ClientId;

            itemToUpdate.Date = item.Date;

            itemToUpdate.Start = item.Start;

            itemToUpdate.End = item.End;

            itemToUpdate.ClientId = item.ClientId;

            itemToUpdate.TypeId = item.TypeId;

            itemToUpdate.PriorityId = item.PriorityId;

            itemToUpdate.CanAdd = item.CanAdd;

            itemToUpdate.CanRemove = item.CanRemove;

            itemToUpdate.CanUpdate = item.CanUpdate;

            itemToUpdate.Id = item.Id;

            itemToUpdate.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Shift Delete(int id)
        {
            var itemToDelete = _context.Shifts.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.Shifts.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Shift> List()
        {
            var items = _context.Shifts;

            return items;
        }

        public Shift Get(int id)
        {
            var item = _context.Shifts.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
