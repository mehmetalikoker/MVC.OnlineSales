using OnlineSales.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using OnlineSales.Data.Model;
using System.Linq.Expressions;
using OnlineSales.Data.Data_Context;
using System.Data.Entity.Migrations;

namespace OnlineSales.Core.Repository
{
    public class ProductFeatureRepository : IProductFeatureRepository
    {
        private readonly OnlineSalesContext context = new OnlineSalesContext();

        public int Count()
        {
            return context.ProductFeature.Count();
        }

        public void Delete(int id)
        {
            var productFeature = GetById(id);
            if (productFeature != null)
                context.ProductFeature.Remove(productFeature);

        }

        public ProductFeature Get(Expression<Func<ProductFeature, bool>> expression)
        {
            return context.ProductFeature.FirstOrDefault(expression);
        }

        public IEnumerable<ProductFeature> GetAll()
        {
            return context.ProductFeature.Select(x => x);
        }

        public ProductFeature GetById(int id)
        {
            return context.ProductFeature.FirstOrDefault(x => x.ProductFeatureId == id);
        }

        public IQueryable<ProductFeature> GetMany(Expression<Func<ProductFeature, bool>> expression)
        {
            return context.ProductFeature.Where(expression);
        }

        public void Insert(ProductFeature obj)
        {
            context.ProductFeature.Add(obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(ProductFeature obj)
        {
            context.ProductFeature.AddOrUpdate(obj);
        }
    }
}
