using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Request;

namespace PizzaProyect.Services
{
    public interface IPedidoService
    {
        public PedidoModel ObtenerPedidoPorId(int pedidoId);
        public PedidoModel ArmarPedido(MakePedidoRequest pedidoRequest);
        public PedidoModel ActualizarEstadoPedido(PedidoModel pedido);
    }
}
