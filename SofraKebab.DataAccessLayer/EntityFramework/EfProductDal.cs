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
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SofraKebabContext context) : base(context)
		{
		}

        public List<Product> GetProductsWithCategories()
        {
            var context = new SofraKebabContext();
            var values= context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}
