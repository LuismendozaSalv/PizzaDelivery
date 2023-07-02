using PizzaProyect.Models;

namespace PizzaDelivery.Models.Pizza
{
    public class CustomPizzaBuilder : PizzaBuilder
    {

        public CustomPizzaBuilder()
        {
            SetPizzaId(3);
            SetNombre("Pizza personalizada");
            SetPrice(60);
        }
        public override PizzaModel Build()
        {
            var pizza = base.Build();
            if (pizza != null && pizza.Toppings.Count == 0)
            {
                throw new Exception("Faltan toppings requeridos para la pizza personalizada.");
            }
            return base.Build();
        }
    }
}
