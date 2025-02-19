using Basket.API.Models;

namespace Basket.API.Basket.GetBasket;

public record GetBasketResponse(ShoppingCart Cart);
public class GetBasketEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        throw new NotImplementedException();
    }
}
