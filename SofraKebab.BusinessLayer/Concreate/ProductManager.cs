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

        public ProductManager(IProductDal ıproductdal)
        {
            _ıproductdal = ıproductdal;
        }

        public void TAdd(Product entity)
		{
			_ıproductdal.Add(entity);
		}

        public decimal TAvgDönerPrice()
        {
           return _ıproductdal.AvgDönerPrice();
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

        public string TMaxProductPrice()
        {
            return _ıproductdal.MaxProductPrice();
        }

        public string TMinProductPrice()
        {
           return _ıproductdal.MinProductPrice();
        }

        public int TProductCount()
        {
            return _ıproductdal.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _ıproductdal.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameDöner()
        {
            return _ıproductdal.ProductCountByCategoryNameDöner();
        }

        public decimal TProductPriceAVG()
        {
            return _ıproductdal.ProductPriceAVG();
        }

        public void TUpdate(Product entity)
		{
			_ıproductdal.Update(entity);	
		}
	}
}
