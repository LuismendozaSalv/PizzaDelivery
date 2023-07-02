using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;

namespace PizzaDelivery.Response
{
    public static class GetPizzasMapper
    {
        public static GetPizzasResponse Map(PizzaModel pizza)
        {
            return new GetPizzasResponse
            {
                PizzaId = pizza.PizzaId,
                Nombre = pizza.Nombre,
                Price = pizza.Price,
            };
        }
    }
}
