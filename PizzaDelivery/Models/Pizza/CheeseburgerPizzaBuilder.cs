using PizzaProyect.Models;

namespace PizzaDelivery.Models.Pizza
{
    public class CheeseburgerBuilder : PizzaBuilder
    {
        public CheeseburgerBuilder()
        {
            SetPizzaId(2);
            SetNombre("Pizza CheeseBurger");
            SetPrice(48);
        }
        public override PizzaModel Build()
        {
            var pizza = base.Build();
            pizza.AddTopping(new Topping { ToppingId = 3, Name = "Cheedar" });
            pizza.AddTopping(new Topping { ToppingId = 5, Name = "Tocino" });
            pizza.AddTopping(new Topping { ToppingId = 6, Name = "Carne" });
            pizza.AddTopping(new Topping { ToppingId = 7, Name = "Mozzarela" });
            return pizza;
        }
    }
}

