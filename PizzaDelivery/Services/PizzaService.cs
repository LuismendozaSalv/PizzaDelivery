using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Repository;
using PizzaDelivery.Services;
using PizzaProyect.Models;
using PizzaProyect.Repository;

namespace PizzaProyect.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IToppingService _toppingService;
            
        public PizzaService(IPizzaRepository pizzaRepository, IToppingService toppingService)
        {
           _pizzaRepository = pizzaRepository;
           _toppingService = toppingService;

        }
        public PizzaModel ArmarPizza(int idPizza, List<int> toppingsId)
        {
            var toppings = _toppingService.ObtenerToppingsPorId(toppingsId);
            return _pizzaRepository.MakePizza(idPizza, toppings);
        }

        public List<PizzaModel> ObtenerPizzas()
        {
            return _pizzaRepository.GetPizzas();
        }
    }
}
