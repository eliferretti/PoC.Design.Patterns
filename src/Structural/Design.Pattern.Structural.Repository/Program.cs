using Design.Pattern.Structural.Repository.Data;
using Design.Pattern.Structural.Repository.Entities;
using Design.Pattern.Structural.Repository.Repositories;

using var context = new AppDbContext();
var repository = new ProductRepository(context);

// Add a new product
var newProduct = new Product { Name = "Laptop", Price = 1200.00M };
repository.Add(newProduct);

// Retrieve the product
var retrievedProduct = repository.GetById(newProduct.Id);
Console.WriteLine($"Retrieved Product: {retrievedProduct.Name} - ${retrievedProduct.Price}");

// Update the product
retrievedProduct.Price = 1100.00M;
repository.Update(retrievedProduct);

// Retrieve all products
var allProducts = repository.GetAll();
foreach (var product in allProducts)
{
    Console.WriteLine($"Product: {product.Name} - ${product.Price}");
}

// Delete the product
repository.Delete(retrievedProduct.Id);
