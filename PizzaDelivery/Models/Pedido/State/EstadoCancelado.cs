namespace PizzaDelivery.Models.Pedido.State
{
    public class EstadoCancelado : EstadoPedido
    {
        public EstadoCancelado() : base()
        {
            this.descripcion = "CANCELADO";
        }

        public override void Cancelar(PedidoModel pedido)
        {
            throw new Exception("Pedido ya fue cancelado.");
        }

        public override string ObtenerEstado()
        {
            return descripcion;
        }

        public override void Proceder(PedidoModel pedido)
        {
            throw new Exception("Pedido ya fue cancelado.");
        }
    }
}
