using Design.Pattern.Behavioral.Service.Data;
using Design.Pattern.Behavioral.Service.Entities;
using Design.Pattern.Behavioral.Service.Repositories;
using Design.Pattern.Behavioral.Service.Services;

using var context = new AppDbContext();
var productRepository = new ProductRepository(context);
var productService = new ProductService(productRepository);

// Add a new product
var newProduct = new Product { Name = "Smartphone", Price = 699.99M };
productService.AddProduct(newProduct);

// Retrieve the product
var retrievedProduct = productService.GetProductById(newProduct.Id);
Console.WriteLine($"Retrieved Product: {retrievedProduct.Name} - ${retrievedProduct.Price}");

// Update the product
retrievedProduct.Price = 649.99M;
productService.UpdateProduct(retrievedProduct);

// Retrieve all products
var allProducts = productService.GetAllProducts();
foreach (var product in allProducts)
{
    Console.WriteLine($"Product: {product.Name} - ${product.Price}");
}

// Delete the product
productService.DeleteProduct(retrievedProduct.Id);