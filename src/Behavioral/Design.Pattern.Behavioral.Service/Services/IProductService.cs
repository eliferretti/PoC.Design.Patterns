using Design.Pattern.Behavioral.Service.Entities;

namespace Design.Pattern.Behavioral.Service.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
