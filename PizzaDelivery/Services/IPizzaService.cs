using PizzaDelivery.Models.Pizza;
using PizzaProyect.Models;

namespace PizzaProyect.Services
{
    public interface IPizzaService
    {
        public PizzaModel ArmarPizza(int idPizza, List<int> toppingsId);
        public List<PizzaModel> ObtenerPizzas();
    }
}
