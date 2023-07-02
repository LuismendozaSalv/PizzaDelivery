using PizzaDelivery.Repository;
using PizzaProyect.Models;

namespace PizzaDelivery.Services
{
    public class ToppingService : IToppingService
    {
        private readonly IToppingRepository _toppingRepository;

        public ToppingService(IToppingRepository toppingRepository)
        {
            _toppingRepository = toppingRepository;
        }

        public Topping ObtenerTopping(int toppingId)
        {
            return _toppingRepository.GetTopping(toppingId);
        }

        public List<Topping> ObtenerToppings()
        {
            return _toppingRepository.GetToppings();
        }

        public List<Topping> ObtenerToppingsPorId(List<int> toppingsId)
        {
            return _toppingRepository.GetToppingsById(toppingsId);
        }
    }
}
