using System.Collections.Generic;
using System.Threading.Tasks;
using TradeBank.Domain.DTO.Request;

namespace TradeBank.Domain.Service
{
    public interface ITradeService
    {
        Task<List<string>> GetCategoria(TradeRequest request);

    }
}
