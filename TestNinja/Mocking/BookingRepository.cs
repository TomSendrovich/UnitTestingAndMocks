using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IBookingRepository
    {
        IQueryable<Booking> GetActiveBookings(int? excludedBokkingId = null);
    }

    public class BookingRepository : IBookingRepository
    {
        UnitOfWork _unitOfWork;

        public BookingRepository()
        {
            _unitOfWork = new UnitOfWork();
        }
        public IQueryable<Booking> GetActiveBookings(int? excludedBokkingId = null)
        {
            var bookings = _unitOfWork.Query<Booking>()
                            .Where(b => b.Status != "Cancelled");

            if (excludedBokkingId.HasValue)
            {
                bookings = bookings.Where(b => b.Id != excludedBokkingId.Value);
            }

            return bookings;
        }
    }
}
