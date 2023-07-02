using PizzaProyect.Models;
using System;

namespace PizzaDelivery.Repository
{
    public class ToppingRepository : IToppingRepository
    {
        public List<Topping> Toppings = new List<Topping> {
            new Topping { ToppingId = 1, Name = "Choclo" },
            new Topping { ToppingId = 2, Name = "Mortadela" },
            new Topping { ToppingId = 3, Name = "Cheedar" },
            new Topping { ToppingId = 4, Name = "Pepperoni" },
            new Topping { ToppingId = 5, Name = "Tocino" },
            new Topping { ToppingId = 6, Name = "Carne" },
            new Topping { ToppingId = 7, Name = "Mozzarela" },
            new Topping { ToppingId = 8, Name = "Queso" },
            new Topping { ToppingId = 9, Name = "Albahaca" },
            new Topping { ToppingId = 10, Name = "Tomate" },
        };

        public List<Topping> GetToppings()
        {
            return Toppings;
        }

        public Topping GetTopping(int toppingId)
        {
            var topping = Toppings.FirstOrDefault(x => x.ToppingId == toppingId);
            if (topping == null)
            {
                throw new Exception("Topping inexistente.");
            }
            return topping;
        }

        public List<Topping> GetToppingsById(List<int> toppingsId)
        {
            List<Topping> filteredToppings = Toppings.Where(p => toppingsId.Contains(p.ToppingId)).ToList();
            return filteredToppings;
        }
    }
}
