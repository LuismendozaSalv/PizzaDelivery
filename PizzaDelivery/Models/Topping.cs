using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Models.Pizza;

namespace PizzaProyect.Models
{
    public class Topping
    {
        [Key]
        public int AutoToppingId { get; set; }
        public int ToppingId { get; set; }
        public string Name { get; set; }
        public PizzaModel Pizza { get; set; }
    }
}
