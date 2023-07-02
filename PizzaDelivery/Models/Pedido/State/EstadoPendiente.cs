namespace PizzaDelivery.Models.Pedido.State
{
    public class EstadoPendiente : EstadoPedido
    {
        public EstadoPendiente() : base()
        {
            this.descripcion = "PENDIENTE";
        }
        public override string ObtenerEstado()
        {
            return descripcion;
        }
        public override void Cancelar(PedidoModel pedido)
        {
            pedido.CambiarEstado(new EstadoCancelado());
        }

        public override void Proceder(PedidoModel pedido)
        {
            pedido.CambiarEstado(new EstadoConfirmado());
        }
    }
}
