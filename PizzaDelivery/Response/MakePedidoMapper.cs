using PizzaDelivery.Models.Pedido;
using System;

namespace PizzaDelivery.Response
{
    public static class MakePedidoMapper
    {
        public static MakePedidoResponse Map(PedidoModel pedido)
        {
            return new MakePedidoResponse
            {
                PedidoId = pedido.PedidoId,
                PedidoDetail = pedido.CargarDetalle()
            };
        }
    }
}
