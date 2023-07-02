using PizzaDelivery.Models.Pizza;

namespace PizzaDelivery.Models.Pedido
{
    public interface IPromocionStrategy
    {
        decimal CalcularPrecio(List<PizzaModel> pizzas, decimal deliveryCost);
    }
}
