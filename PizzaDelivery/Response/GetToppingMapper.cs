using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;
using PizzaProyect.Models;

namespace PizzaDelivery.Response
{
    public static class GetToppingMapper
    {
        public static GetToppingResponse Map(Topping topping)
        {
            return new GetToppingResponse
            {
                Id = topping.ToppingId,
                Nombre = topping.Name,
            };
        }
    }
}
