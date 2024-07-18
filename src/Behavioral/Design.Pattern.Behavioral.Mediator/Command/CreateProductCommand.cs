using MediatR;

namespace Design.Pattern.Behavioral.Mediator.Command
{
    public class CreateProductCommand : IRequest<CreateProductResponse>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
