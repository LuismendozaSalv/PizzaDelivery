using PizzaProyect.Models;

namespace PizzaDelivery.Services
{
    public interface IToppingService
    {
        public List<Topping> ObtenerToppings();
        public Topping ObtenerTopping(int toppingId);
        public List<Topping> ObtenerToppingsPorId(List<int> toppingsId);
    }
}
