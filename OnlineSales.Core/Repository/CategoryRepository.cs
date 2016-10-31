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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineSalesContext context = new OnlineSalesContext(); 

        public int Count()
        {
            return context.Category.Count();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category != null)
                context.Category.Remove(category);
        }

        public Category Get(Expression<Func<Category, bool>> expression)
        {
            return context.Category.FirstOrDefault(expression);
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Category.Select(x => x);
        }

        public Category GetById(int id)
        {
            return context.Category.FirstOrDefault(x => x.CategoryId == id);
        }

        public IQueryable<Category> GetMany(Expression<Func<Category, bool>> expression)
        {
            return context.Category.Where(expression);
        }

        public void Insert(Category category)
        {
            context.Category.Add(category);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Category updateCategory)
        {
            context.Category.AddOrUpdate(updateCategory);
        }
    }
}
