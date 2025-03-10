using System.Collections.Generic;
using DOGIAAN_2280600147.Models;

namespace DOGIAAN_2280600147.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
