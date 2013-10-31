using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity.Validation;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class ShiftRepository : Infrastructure.Data.MainModule.Repositories.IShiftRepository
    {
        private readonly ScheduleApiContext _context;

        public ShiftRepository()
        {
            _context = new ScheduleApiContext();
        }

        public Shift Add(Shift item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            item.ClientToken = guid;

            var shiftToAdd = new Shift();

            shiftToAdd.Assigned = item.Assigned;
            shiftToAdd.CanAdd = item.CanAdd;
            shiftToAdd.CanRemove = item.CanRemove;
            shiftToAdd.CanUpdate = item.CanUpdate;
            shiftToAdd.ClientId = item.ClientId;
            shiftToAdd.ClientToken = item.ClientToken;
            shiftToAdd.Date = item.Date;
            shiftToAdd.EmployeeId = item.EmployeeId;
            shiftToAdd.End = item.End;
            shiftToAdd.PriorityId = item.Priority.Id;
            shiftToAdd.SeasonId = item.Season.Id;
            shiftToAdd.Start = item.Start;
            shiftToAdd.TypeId = item.ShiftType.Id;

            var addedItem = _context.Shifts.Add(shiftToAdd);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Shift Update(Shift item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToUpdate = _context.Shifts.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

            itemToUpdate.EmployeeId = item.EmployeeId;

            itemToUpdate.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Shift Delete(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToDelete = _context.Shifts.FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            var deletedItem = _context.Shifts.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Shift> List(string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var items = _context.Shifts.Where(b => b.ClientToken == guid);

            return items;
        }

        public Shift Get(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.Shifts.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            return item;
        }
    }
}
