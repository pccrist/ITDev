using TradeBank.Domain.Interface;
using System;
using TradeBank.Domain.VO;

namespace TradeBank.Domain.Entities
{
    public class ValorMaiorUmMilhaoSetorPublico : IRegraCalculo
    {
        public string calcula(Trade tr)
        {

            if (tr.Value > 1000000 && tr.ClientSector == "Public")
                return ToString();

            return null;
        }

        public override string ToString()
        {
            return "MEDIUMRISK";
        }

    }
}
