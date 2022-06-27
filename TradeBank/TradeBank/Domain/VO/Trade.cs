using TradeBank.Domain.Interface;
using System;

namespace TradeBank.Domain.VO
{
    public class Trade : CategoryData
    {
        public DateTime CurrentDate { get; set; }
        public int Portfolio { get; set; }

    }
}
