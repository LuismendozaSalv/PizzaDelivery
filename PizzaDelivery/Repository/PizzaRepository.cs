using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Repository;
using PizzaProyect.Models;

namespace PizzaProyect.Repository
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly ApiContext _context;
        public PizzaRepository(ApiContext context)
        {
            this._context = context;
        }

        public List<PizzaModel> pizzaList = new List<PizzaModel> 
        {
            new PizzaModel { PizzaId = 1, Nombre = "Margarita", Price = 42},
            new PizzaModel { PizzaId = 2, Nombre = "Cheeseburger", Price = 48},
            new PizzaModel { PizzaId = 3, Nombre = "Personalizada", Price = 60},
        };

        public List<PizzaModel> GetPizzas()
        {
            return pizzaList;
        }

        public PizzaModel MakePizza(int idPizza, List<Topping> toppings)
        {
            PizzaBuilderFactory builderFactory = new PizzaBuilderFactory();
            IPizzaBuilder pizzaBuilder = builderFactory.CreateBuilder(idPizza);
            PizzaDirector director = new PizzaDirector(pizzaBuilder);
            PizzaModel pizza = director.ConstructPizza(toppings);
            return pizza;
        }
    }
}
