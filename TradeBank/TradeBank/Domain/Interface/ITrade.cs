using System;

namespace TradeBank.Domain.Interface
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }

    }
}
