using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;

namespace PizzaProyect.Repository
{
    public interface IPedidoRepository
    {
        public PedidoModel MakePedido(String customerName, List<PizzaModel> pizzas);
        public PedidoModel GetPedidoByID(int PedidoId);
        public PedidoModel UpdateEstadoPedido(PedidoModel pedido);
    }
}
