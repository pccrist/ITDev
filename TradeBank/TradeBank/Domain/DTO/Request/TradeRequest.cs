using System;
using System.Collections.Generic;
using TradeBank.Domain.VO;


namespace TradeBank.Domain.DTO.Request
{
    public class TradeRequest
    {
        public string CurrentDate { get; set; }
        public string Portfolio { get; set; }
        public List<CategoriaDataRequest> ListCategoryData { get; set; }
    }
}
