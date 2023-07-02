namespace PizzaDelivery.Models.Pizza
{
    public class PizzaBuilderFactory
    {
        public IPizzaBuilder CreateBuilder(int builderType)
        {
            switch (builderType)
            {
                case 1:
                    return new MargaritaPizzaBuilder();
                case 2:
                    return new CheeseburgerBuilder();
                case 3:
                    return new CustomPizzaBuilder();
                default:
                    throw new ArgumentException("Tipo de builder no válido");
            }
        }
    }
}
