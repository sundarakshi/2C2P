using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.DAL.BusinessContract
{
    public interface ICardDetails
    {
        Models.CardDetails GetCardDetails(string CardNumber);
    }
}
