using DOGIAAN_2280600147.Models;

namespace DOGIAAN_2280600147.Repositories
{
    public class MockCategoryRepocitory : ICategoryRepository
    {
        private List<Category> _categoryList;

        public MockCategoryRepocitory()
        {
            _categoryList = new List<Category>
            {
                new Category { Id = 1, Name = "Laptop" },
                new Category { Id = 2, Name = "Destop" },
                new Category { Id = 3, Name = "Phone" },
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
