using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data;
using ProductsAPI.Models;

namespace ProductsAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductContext _dbContext;

        public CategoryRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetCategories() => _dbContext.Category.ToList();

        public Category GetCategoryById(int categoryId) => _dbContext.Category.Find(categoryId);

        public void InsertCategory(Category category)
        {
            _dbContext.Add(category);
            Save();
        }

        public void UpdateCategory(Category category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            Save();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _dbContext.Category.Find(categoryId);
            _dbContext.Category.Remove(category);
            Save();
        }

        public void Save() => _dbContext.SaveChanges();
    }

}
