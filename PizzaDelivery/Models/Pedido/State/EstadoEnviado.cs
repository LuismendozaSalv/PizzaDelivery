namespace PizzaDelivery.Models.Pedido.State
{
    public class EstadoEnviado : EstadoPedido
    {
        public EstadoEnviado() : base()
        {
            this.descripcion = "ENVIADO";
        }
        public override string ObtenerEstado()
        {
            return descripcion;
        }
        public override void Cancelar(PedidoModel pedido)
        {
            throw new Exception("Pedido enviado no se puede cancelar");
        }

        public override void Proceder(PedidoModel pedido)
        {
            pedido.CambiarEstado(new EstadoEntregado());
        }
    }
}
