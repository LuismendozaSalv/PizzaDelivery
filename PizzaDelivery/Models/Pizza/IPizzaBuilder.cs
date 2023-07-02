using PizzaProyect.Models;

namespace PizzaDelivery.Models.Pizza
{
    public interface IPizzaBuilder
    {
        public PizzaBuilder SetPizzaId(int pizzaId);

        public PizzaBuilder SetNombre(string nombre);

        public PizzaBuilder SetPrice(decimal precio);

        public PizzaBuilder AddTopping(Topping topping);

        public PizzaModel Build();
    }
}
