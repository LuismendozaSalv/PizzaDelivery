using PizzaProyect.Models;

namespace PizzaDelivery.Models.Pizza
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private PizzaModel pizza;

        public PizzaBuilder()
        {
            pizza = new PizzaModel();
        }

        public PizzaBuilder SetPizzaId(int pizzaId)
        {
            pizza.PizzaId = pizzaId;
            return this;
        }

        public PizzaBuilder SetNombre(string nombre)
        {
            pizza.Nombre = nombre;
            return this;
        }

        public PizzaBuilder AddTopping(Topping topping)
        {
            pizza.AddTopping(topping);
            return this;
        }

        public virtual PizzaModel Build()
        {
            return pizza;
        }

        public PizzaBuilder SetPrice(decimal precio)
        {
            pizza.Price = precio;
            return this;
        }
    }
}
