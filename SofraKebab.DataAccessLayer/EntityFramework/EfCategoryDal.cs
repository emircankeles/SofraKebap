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
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EfCategoryDal(SofraKebabContext context) : base(context)
		{
		}

        public int ActiveCategoryCount()
        {
           using var context=new SofraKebabContext();
           return context.Categories.Where(x => x.Status == true).Count();
        }
        public int PassiveCategoryCount()
        {
            using var context = new SofraKebabContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }

        public int CategoryCount()
        {
            using var context = new SofraKebabContext();
            return context.Categories.Count();
        }
    }
}
