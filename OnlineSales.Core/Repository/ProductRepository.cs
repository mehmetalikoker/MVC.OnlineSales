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
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineSalesContext context = new OnlineSalesContext(); 

        public int Count()
        {
            return context.Product.Count();
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
                context.Product.Remove(product);
        }

        public Product Get(Expression<Func<Product, bool>> expression)
        {
            return context.Product.FirstOrDefault(expression);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Product.Select(x => x);
        }

        public Product GetById(int id)
        {
            return context.Product.FirstOrDefault(x => x.ProductId == id);
        }

        public IQueryable<Product> GetMany(Expression<Func<Product, bool>> expression)
        {
            return context.Product.Where(expression);
        }

        public void Insert(Product obj)
        {
            context.Product.Add(obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Product obj)
        {
            context.Product.AddOrUpdate(obj);
        }
    }
}
