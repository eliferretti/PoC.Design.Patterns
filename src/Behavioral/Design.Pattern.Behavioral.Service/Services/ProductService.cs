using Design.Pattern.Behavioral.Service.Entities;
using Design.Pattern.Behavioral.Service.Repositories;

namespace Design.Pattern.Behavioral.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }
    }
}
