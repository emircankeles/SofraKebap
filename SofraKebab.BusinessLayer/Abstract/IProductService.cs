using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        public int TProductCount();
        public int TProductCountByCategoryNameDrink();
        public int TProductCountByCategoryNameDöner();
        decimal TProductPriceAVG();
        string TMaxProductPrice();
        string TMinProductPrice();
        decimal TAvgDönerPrice();
    }
}
