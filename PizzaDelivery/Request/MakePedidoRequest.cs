using PizzaDelivery.Models.Pizza;

namespace PizzaDelivery.Request
{
    public class MakePedidoRequest
    {
        public string NombreCliente { get; set; } = "";
        public List<MakePizzaRequest> MakePizzas { get; set; }

        public MakePedidoRequest()
        {
            MakePizzas = new List<MakePizzaRequest>();
        }
    }

    public class MakePizzaRequest
    {
        public int PizzaId { get; set; }
        public List<int> ToppingsIds { get; set; }

        public MakePizzaRequest()
        {
            ToppingsIds = new List<int>();
        }
    }
}
