using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Repository;

namespace PizzaProyect.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApiContext _context;

        public PedidoRepository(ApiContext context)
        {
            _context = context;
        }
        public PedidoModel GetPedidoByID(int pedidoId)
        {
            var pedidos = _context.Pedidos
                .Where(pedido => pedido.PedidoId == pedidoId)
                .Include(pedido => pedido.Pizzas)
                .ThenInclude(pizza => pizza.Toppings)
                .FirstOrDefault();
            return pedidos;
        }

        public PedidoModel MakePedido(string customerName, List<PizzaModel> pizzas)
        {
            var pedido = new PedidoModel
            {
                NombreCliente = customerName,
                Pizzas = pizzas
            };
            pedido.CalcularPrecioTotal();
            _context.Pedidos.Add(pedido);
            pedido.CargarDetalle();
            _context.SaveChanges();
            return pedido;
        }

        public PedidoModel UpdateEstadoPedido(PedidoModel pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
            return pedido;
        }
    }
}
