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

        public decimal AvgDönerPrice()
        {
            var context = new SofraKebabContext();
            return context.Products.Where(x=>x.CategoryID==(context.Categories.Where(y=>y.Name=="Döner").Select(z=>z.CategoryID).FirstOrDefault())).Average(x=>x.Price);
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SofraKebabContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public string MaxProductPrice()
        {
            using var context = new SofraKebabContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string MinProductPrice()
        {
            using var context = new SofraKebabContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public int ProductCount()
        {
            using var context = new SofraKebabContext();
             return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new SofraKebabContext();
             return context.Products.Where(x=>x.CategoryID==(context.Categories.Where(y=>y.Name=="İçecek").Select(z=>z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameDöner()
        {
            using var context = new SofraKebabContext();
             return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.Name == "Döner").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public decimal ProductPriceAVG()
        {
            using var context = new SofraKebabContext();
            return context.Products.Average(x => x.Price);
        }
    }
}
