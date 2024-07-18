using Design.Pattern.Behavioral.Mediator.Entities;
using MediatR;

namespace Design.Pattern.Behavioral.Mediator.Command
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        private static readonly List<Product> Products = new List<Product>();
        public Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product { Name = request.Name, Price = request.Price };
            Products.Add(product);

            return Task.FromResult(new CreateProductResponse
            {
                Success = true,
                Message = "Product created successfully."
            });
        }

    }
}
