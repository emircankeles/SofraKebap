using SofraKebab.DataAccessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;
using SofraKebab.DataAccessLayer.Repositories;
using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(SofraKebabContext context) : base(context)
		{
		}

        public void BookingStatusApproved(int id)
        {
            using var context = new SofraKebabContext();
            var values = context.Bookings.Find(id);
            values.Description = "Rezervasyon Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusCancelled(int id)
        {
            using var context = new SofraKebabContext();
            var values = context.Bookings.Find(id);
            values.Description = "Rezervasyon İptal Edildi";
            context.SaveChanges();
        }
    }
}
