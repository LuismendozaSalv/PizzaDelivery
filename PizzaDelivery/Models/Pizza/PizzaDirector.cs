using PizzaProyect.Models;

namespace PizzaDelivery.Models.Pizza
{
    public class PizzaDirector
    {
        private IPizzaBuilder builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            this.builder = builder;
        }

        public PizzaModel ConstructPizza(List<Topping> toppings)
        {
            foreach (var topping in toppings)
            {
                builder.AddTopping(topping);
            }
            return builder.Build();
        }
    }
}
