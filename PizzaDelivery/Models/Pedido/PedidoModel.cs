using PizzaDelivery.Models.Pedido.State;
using PizzaDelivery.Models.Pizza;
using PizzaProyect.Models;
using System.ComponentModel.DataAnnotations;

namespace PizzaDelivery.Models.Pedido
{
    public class PedidoModel
    {
        [Key]
        public int PedidoId { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public List<PizzaModel> Pizzas { get; set; } = new List<PizzaModel>();
        public decimal PrecioDelivery { get; set; } = 10;
        public decimal PrecioTotal { get; set; }
        public DateTime FechaPedido { get; set; } = DateTime.Now;
        public EstadoPedido Estado { get; set; }

        private readonly IPromocionStrategy PromocionStrategy;
        public string Detalle { get; set; } = string.Empty;
        public PedidoModel()
        {
            // Selecciona la estrategia de promoción según el día de la semana
            this.PromocionStrategy = PromocionStrategyFactory.CrearPromocionStrategy(this.FechaPedido);
            this.CambiarEstado(new EstadoPendiente());
        }

        public void CambiarEstado(EstadoPedido estado)
        {
            this.Estado = estado;
        }

        public decimal CalcularPrecioTotal()
        {
            this.PrecioTotal = this.PromocionStrategy.CalcularPrecio(Pizzas, PrecioDelivery);
            return this.PrecioTotal;
        }

        public string CargarDetalle()
        {
            this.Detalle = "Pedido: " + PedidoId + ";" +
                "Nombre cliente: " + NombreCliente + ";" +
                "Precio Total: " + PrecioTotal + ";" +
                "Estado: " + Estado.ObtenerEstado() + ";" +
                "Pizzas: " + string.Join(", ", Pizzas.Select(pizza => pizza.Imprimir()));
            return this.Detalle;
        }

    }
}
