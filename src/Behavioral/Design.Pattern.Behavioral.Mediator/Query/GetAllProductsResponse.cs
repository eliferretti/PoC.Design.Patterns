using Design.Pattern.Behavioral.Mediator.Entities;

namespace Design.Pattern.Behavioral.Mediator.Query
{
    public class GetAllProductsResponse
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
