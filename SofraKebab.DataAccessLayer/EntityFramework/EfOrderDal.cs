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

        public int ActiveOrders()
        {
            using var context = new SofraKebabContext();
            var a = context.Orders.Where(x => x.Activate == true );
            return a.Count(); 
        }

        public decimal LastOrderPrice()
        {
            using var context = new SofraKebabContext();
            var price =  context.Orders.Where(x => x.Activate == false)
                .Select(x=>x.TotalPrice).FirstOrDefault();
            return price;
                
        }

        public decimal TodayGetMoney()
        {
            using var context = new SofraKebabContext();
            var total = context.Orders.Where(x=>x.Activate == false)
                .Select(x=>x.TotalPrice).Sum();
            return total;
        }

        public int TotalOrderCount()
        {
            using var context = new SofraKebabContext();
            return context.Orders.Count();
        }
    }
}
