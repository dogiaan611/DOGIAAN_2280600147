using DOGIAAN_2280600147.Models;

namespace DOGIAAN_2280600147.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
