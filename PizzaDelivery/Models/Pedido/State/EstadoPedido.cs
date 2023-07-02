namespace PizzaDelivery.Models.Pedido.State
{
    public abstract class EstadoPedido
    {
        protected string descripcion;
        public abstract String ObtenerEstado();
        public abstract void Proceder(PedidoModel pedido);
        public abstract void Cancelar(PedidoModel pedido);
    }
}
