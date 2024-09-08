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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SofraKebabContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new SofraKebabContext();
            return context.Orders.Where(x=>x.Description=="Müşteri masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new SofraKebabContext();
            return context.Orders.OrderByDescending(x=>x.OrderID).Take(1).Select(y=>y.TotalPrice).FirstOrDefault();
        }

        public decimal TodayOrderPrice()
        {
            return 0;
        }

        public int TotalOrderCount()
        {
            using var context = new SofraKebabContext();
            return context.Orders.Count();
        }
    }
}
