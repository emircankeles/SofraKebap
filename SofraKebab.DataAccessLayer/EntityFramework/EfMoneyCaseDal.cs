using Microsoft.EntityFrameworkCore;
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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(SofraKebabContext context) : base(context)
        {
        }

        public decimal TotalMoney()
        {
            using var context = new SofraKebabContext();
            return context.MoneyCases.Sum(x => x.TotalCount);
        }
    }
}
