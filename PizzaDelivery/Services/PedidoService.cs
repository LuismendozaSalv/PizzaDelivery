using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Request;
using PizzaProyect.Repository;
using System.Collections;

namespace PizzaProyect.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IPizzaService _pizzaService;

        public PedidoService(IPedidoRepository pedidoRepository, IPizzaService pizzaService)
        {
            _pedidoRepository = pedidoRepository;
            _pizzaService = pizzaService;
        }

        public PedidoModel ActualizarEstadoPedido(PedidoModel pedido)
        {
            return _pedidoRepository.UpdateEstadoPedido(pedido);
        }

        public PedidoModel ArmarPedido(MakePedidoRequest pedidoRequest)
        {
            List<PizzaModel> pizzas = new List<PizzaModel>();
            pedidoRequest.MakePizzas.ForEach(pizzaReq => {
                pizzas.Add(_pizzaService.ArmarPizza(pizzaReq.PizzaId, pizzaReq.ToppingsIds));
            });
            return this._pedidoRepository.MakePedido(pedidoRequest.NombreCliente, pizzas);
        }

        public PedidoModel ObtenerPedidoPorId(int pedidoId)
        {
            return _pedidoRepository.GetPedidoByID(pedidoId);
        }
    }
}
