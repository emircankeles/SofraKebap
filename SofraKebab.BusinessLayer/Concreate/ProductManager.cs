using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Abstract;
using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.BusinessLayer.Concreate
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _ıproductdal;
		public void TAdd(Product entity)
		{
			_ıproductdal.Add(entity);
		}

		public void TDelete(Product entity)
		{
			_ıproductdal.Delete(entity);
		}

		public Product TGetByID(int id)
		{
			return _ıproductdal.GetByID(id);	
		}

		public List<Product> TGetListAll()
		{
			return _ıproductdal.GetListAll();
		}

        public List<Product> TGetProductsWithCategories()
        {
            return _ıproductdal.GetProductsWithCategories();
        }

        public void TUpdate(Product entity)
		{
			_ıproductdal.Update(entity);	
		}
	}
}
