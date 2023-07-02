namespace PizzaDelivery.Models.Pedido.State
{
    public class EstadoConfirmado : EstadoPedido
    {
        public EstadoConfirmado() : base()
        {
            this.descripcion = "CONFIRMADO";
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
            pedido.CambiarEstado(new EstadoPreparado());
        }
    }
}
