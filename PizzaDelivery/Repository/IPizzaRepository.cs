using PizzaDelivery.Models.Pizza;
using PizzaProyect.Models;

namespace PizzaProyect.Repository
{
    public interface IPizzaRepository
    {
        public PizzaModel MakePizza (int idPizza, List<Topping> toppings);
        public List<PizzaModel> GetPizzas();
    }
}
