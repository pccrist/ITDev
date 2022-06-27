using TradeBank.Domain.Interface;
using System;
using TradeBank.Domain.VO;

namespace TradeBank.Domain.Entities
{
    public class DataExpirada : IRegraCalculo
    {
        public string calcula(Trade tr)
        {

            if ((tr.CurrentDate - tr.NextPaymentDate).TotalDays > 30)
               return ToString();

            return null;
        }

        public override string ToString()
        {
            return "EXPIRED";
        }
    }
}
