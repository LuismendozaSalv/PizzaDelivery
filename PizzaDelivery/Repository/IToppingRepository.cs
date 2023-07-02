using PizzaProyect.Models;

namespace PizzaDelivery.Repository
{
    public interface IToppingRepository
    {
        public List<Topping> GetToppings();
        public Topping? GetTopping(int toppingId);
        public List<Topping> GetToppingsById(List<int> toppingsId);
    }
}
