using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TradeBank.Domain.DTO.Request;
using TradeBank.Domain.Service;

namespace TradeBank.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("v{version:apiVersion}/[controller]")]
    public class TradesController : ControllerBase
    {

        readonly ITradeService _tradeService;

        public TradesController(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrades([FromBody] TradeRequest request)
        {

            try
            {
                // var cliente = _mapper.Map<Cliente>(cadastrarClienteRequest);
                var result = await _tradeService.GetCategoria(request);

             //   if (_clienteService.PossuiMensagens)
              //      return BadRequest(_clienteService.Mensagens);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
