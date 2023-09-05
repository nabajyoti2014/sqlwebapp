using Webappwithsqldb.Models;

namespace Webappwithsqldb.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
