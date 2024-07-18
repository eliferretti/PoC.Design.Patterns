using Design.Pattern.Behavioral.Mediator.Entities;
using MediatR;

namespace Design.Pattern.Behavioral.Mediator.Query
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, GetAllProductsResponse>
    {
        private static readonly List<Product> Products = new List<Product>
    {
        new Product { Name = "Product1", Price = 10 },
        new Product { Name = "Product2", Price = 20 },
    };

        public Task<GetAllProductsResponse> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetAllProductsResponse
            {
                Products = Products
            });
        }
    }
}
