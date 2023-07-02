using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Models.Pedido;
using PizzaProyect.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDelivery.Models.Pizza
{
    public class PizzaModel
    {
        [Key]
        public int AutoPizzaId { get; set; }
        public int PizzaId { get; set; }
        public string Nombre { get; set; }
        public decimal Price { get; set; }
        public List<Topping> Toppings { get; set; }
        public PedidoModel Pedido { get; set; }

        public PizzaModel()
        {
            Toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
        }

        public string Imprimir()
        {   
            return "Pizza: " + Nombre + ";" +
                "Precio: " + Price + ";" +
                "Ingredientes: " + string.Join(", ", Toppings.Select(topping => topping.Name));
        }
    }
}
