using PizzaProyect.Models;

namespace PizzaDelivery.Models.Pizza
{
    public class MargaritaPizzaBuilder : PizzaBuilder
    {
        public MargaritaPizzaBuilder()
        {
            SetPizzaId(1);
            SetNombre("Pizza Margarita");
            SetPrice(42);
        }
        public override PizzaModel Build()
        {      
            var pizza = base.Build();
            
            pizza.AddTopping(new Topping { ToppingId = 1, Name = "Albahaca" });
            pizza.AddTopping(new Topping { ToppingId = 2, Name = "Tomates" });
            return pizza;
        }
    }
}
