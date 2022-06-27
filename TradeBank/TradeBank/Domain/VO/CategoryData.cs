using System;
using TradeBank.Domain.Interface;

namespace TradeBank.Domain.VO
{
    public class CategoryData : ITrade
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get;  set; }
    }
}
