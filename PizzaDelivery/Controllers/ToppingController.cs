using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Response;
using PizzaDelivery.Services;

namespace PizzaProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingController : ControllerBase
    {
        private readonly IToppingService _toppingService;
        public ToppingController(IToppingService toppingService) 
        {
            this._toppingService = toppingService;
        }

        [HttpGet]
        [Route("GetToppings")]
        public ActionResult<List<GetToppingResponse>> GetToppings()
        {
            var toppingsResponse = new List<GetToppingResponse>();
            var toppings = _toppingService.ObtenerToppings();
            if (toppings != null)
            {
                foreach (var topping in toppings)
                {
                    toppingsResponse.Add(GetToppingMapper.Map(topping));
                }
                return Ok(toppingsResponse);
            }
            return Ok(toppings);
        }
    }
}
