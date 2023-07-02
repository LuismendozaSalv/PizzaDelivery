using PizzaDelivery.Models.Pizza;

namespace PizzaDelivery.Models.Pedido
{
    public class PromocionNormalStrategy : IPromocionStrategy
    {
        public decimal CalcularPrecio(List<PizzaModel> pizzas, decimal deliveryCost)
        {
            decimal total = pizzas.Sum(p => p.Price);
            return total + deliveryCost;
        }
    }
}
