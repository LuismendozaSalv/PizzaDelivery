namespace PizzaDelivery.Models.Pedido.State
{
    public class EstadoPreparado : EstadoPedido
    {
        public EstadoPreparado() : base()
        {
            this.descripcion = "PREPARADO";
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
            pedido.CambiarEstado(new EstadoEnviado());
        }
    }
}
