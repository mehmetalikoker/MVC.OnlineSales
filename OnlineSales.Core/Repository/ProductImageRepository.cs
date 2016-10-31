using OnlineSales.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineSales.Data.Model;
using System.Linq.Expressions;
using OnlineSales.Data.Data_Context;
using System.Data.Entity.Migrations;

namespace OnlineSales.Core.Repository
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly OnlineSalesContext context = new OnlineSalesContext();

        public int Count()
        {
            return context.ProductImage.Count();
        }

        public void Delete(int id)
        {
            var productImage = GetById(id);
            if (productImage != null)
                context.ProductImage.Remove(productImage);
        }

        public ProductImage Get(Expression<Func<ProductImage, bool>> expression)
        {
            return context.ProductImage.FirstOrDefault(expression);
        }

        public IEnumerable<ProductImage> GetAll()
        {
            return context.ProductImage.Select(x => x);
        }

        public ProductImage GetById(int id)
        {
            return context.ProductImage.FirstOrDefault(x => x.ProductImageId == id);
        }

        public IQueryable<ProductImage> GetMany(Expression<Func<ProductImage, bool>> expression)
        {
            return context.ProductImage.Where(expression);
        }

        public void Insert(ProductImage productImage)
        {
            context.ProductImage.Add(productImage);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(ProductImage obj)
        {
            context.ProductImage.AddOrUpdate(obj);
        }
    }
}
