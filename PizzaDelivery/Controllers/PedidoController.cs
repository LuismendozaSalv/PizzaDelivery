using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pizza;
using PizzaDelivery.Request;
using PizzaDelivery.Response;
using PizzaProyect.Services;

namespace PizzaProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        [Route("MakeOrder")]
        public ActionResult<MakePedidoResponse> MakeOrder(MakePedidoRequest pedidoRequest)
        {
            try
            {
                var pedido = _pedidoService.ArmarPedido(pedidoRequest);
                if (pedido != null)
                {
                    var pedidoResponse = MakePedidoMapper.Map(pedido);
                    return Ok(pedidoResponse);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("GetOrder")]
        public ActionResult<MakePedidoResponse> GetOrder(int id)
        {
            var pedido = _pedidoService.ObtenerPedidoPorId(id);
            if (pedido != null)
            {
                var pedidoResponse = MakePedidoMapper.Map(pedido);
                return Ok(pedidoResponse);
            }
            return BadRequest(string.Format("Pedido con id = {0} no encontrado", id));
        }

        [HttpPost]
        [Route("ProcesarPedido")]
        public ActionResult<MakePedidoResponse> ProcesarPedido(int id)
        {
            try
            {
                var pedido = _pedidoService.ObtenerPedidoPorId(id);

                if (pedido != null)
                {
                    pedido.Estado.Proceder(pedido);
                    _pedidoService.ActualizarEstadoPedido(pedido);
                    var pedidoResponse = MakePedidoMapper.Map(pedido);
                    return Ok(pedidoResponse);
                }
                return BadRequest(string.Format("Pedido con id = {0} no encontrado", id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("CancelarPedido")]
        public ActionResult<MakePedidoResponse> CancelarPedido(int id)
        {
            try
            {
                var pedido = _pedidoService.ObtenerPedidoPorId(id);
                if (pedido != null)
                {
                    pedido.Estado.Cancelar(pedido);
                    _pedidoService.ActualizarEstadoPedido(pedido);
                    var pedidoResponse = MakePedidoMapper.Map(pedido);
                    return Ok(pedidoResponse);
                }
                return BadRequest(string.Format("Pedido con id = {0} no encontrado", id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
