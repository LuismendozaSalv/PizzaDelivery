namespace PizzaDelivery.Models.Pedido
{
    public static class PromocionStrategyFactory
    {
        public static IPromocionStrategy CrearPromocionStrategy(DateTime fechaPedido)
        {
            if (fechaPedido.DayOfWeek == DayOfWeek.Tuesday || fechaPedido.DayOfWeek == DayOfWeek.Wednesday)
            {
                return new PromocionDosPorUnoStrategy();
            }
            else if (fechaPedido.DayOfWeek == DayOfWeek.Thursday)
            {
                return new PromocionDeliveryGratisStrategy();
            }
            else
            {
                return new PromocionNormalStrategy();
            }
        }
    }
}
