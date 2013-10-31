using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure.Data.MainModule.Models;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class ShiftTimeRepository : IShiftTimeRepository
    {
        private readonly ScheduleApiContext _context;

        public ShiftTimeRepository()
        {
            _context = new ScheduleApiContext();
        }

        public ShiftTime Add(ShiftTime item, string clientToken)
        {
            item.ClientToken = Guid.Parse(clientToken);

            var addedItem = _context.ShiftTimes.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public ShiftTime Update(ShiftTime item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToUpdate = _context.ShiftTimes.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            itemToUpdate.Start = item.Start;

            itemToUpdate.End = item.End;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public ShiftTime Delete(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToDelete = _context.ShiftTimes.FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            var deletedItem = _context.ShiftTimes.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<ShiftTime> List(string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var items = _context.ShiftTimes.Where(b => b.ClientToken == guid);

            return items;
        }

        public ShiftTime Get(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.ShiftTimes.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            return item;
        }
    }
}
