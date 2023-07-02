namespace PizzaDelivery.Models.Pedido.State
{
    public class EstadoEntregado : EstadoPedido
    {
        public EstadoEntregado() : base()
        {
            this.descripcion = "ENTREGADO";
        }
        public override string ObtenerEstado()
        {
            return descripcion;
        }
        public override void Cancelar(PedidoModel pedido)
        {
            throw new Exception("Pedido entregado no se puede cancelar");
        }

        public override void Proceder(PedidoModel pedido)
        {
            throw new Exception("Pedido entregado");
        }
    }
}
