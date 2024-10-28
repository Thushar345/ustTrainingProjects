using ProductsAPI.Models;

namespace ProductsAPI.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int categoryId);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
        void Save();
    }

}
