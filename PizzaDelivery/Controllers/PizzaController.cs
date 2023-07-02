using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Response;
using PizzaProyect.Models;
using PizzaProyect.Services;

namespace PizzaProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;
        public PizzaController(IPizzaService pizzaService) 
        {
            this._pizzaService = pizzaService;
        }

        [HttpGet]
        [Route("GetPizzas")]
        public ActionResult<List<GetPizzasResponse>> GetPizzas()
        {
            var pizzasResponse = new List<GetPizzasResponse>();
            var pizzas = _pizzaService.ObtenerPizzas();
            if (pizzas != null)
            {
                foreach (var pizza in pizzas) {
                    pizzasResponse.Add(GetPizzasMapper.Map(pizza));
                }
                return Ok(pizzasResponse);
            }
            return Ok();
        }
    }
}
