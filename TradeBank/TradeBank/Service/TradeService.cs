using System;
using System.Linq;
using TradeBank.Domain.Interface;
using TradeBank.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using TradeBank.Domain.DTO.Request;
using TradeBank.Domain.Service;
using TradeBank.Domain.VO;

namespace TradeBank.Service
{
    public class TradeService : ITradeService
    {
        public TradeService()
        {

        }

        public Task<List<string>> GetCategoria(TradeRequest request)
        {

            string ret = null;
            int index = 0;
            List<string> ret1  = new List<string>();

            IEnumerable<Type> _commands = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(t => t.GetInterfaces().Contains(typeof(IRegraCalculo)));

            foreach (var req in request.ListCategoryData)
            {
                Trade tr = new Trade()
                {
                    CurrentDate = DateTime.ParseExact(request.CurrentDate, "MM/dd/yyyy", null),
                    Portfolio = Int32.Parse(request.Portfolio),
                    Value = double.Parse(request.ListCategoryData[index].Value),
                    ClientSector = request.ListCategoryData[index].ClientSector,
                    NextPaymentDate = DateTime.ParseExact(request.ListCategoryData[index].NextPaymentDate, "MM/dd/yyyy", null)
                };

                foreach (Type _type in _commands)
                {
                    IRegraCalculo _command = (IRegraCalculo)Activator.CreateInstance(_type);

                    ret = null;
                    ret = _command.calcula(tr);

                    if (ret != null)
                       break;
                }
                if (ret != null)
                    ret1.Add(ret);

                index += 1;
            }

            return Task.FromResult(ret1);

        }
    }
}
