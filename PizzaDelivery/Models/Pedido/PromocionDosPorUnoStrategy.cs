using PizzaDelivery.Models.Pizza;

namespace PizzaDelivery.Models.Pedido
{
    public class PromocionDosPorUnoStrategy : IPromocionStrategy
    {
        public decimal CalcularPrecio(List<PizzaModel> pizzas, decimal deliveryCost)
        {
            decimal total = pizzas.Sum(p => p.Price / 2);
            return total + deliveryCost;
        }
    }
}
