using System;
using System.Collections.Generic;
using System.Text;
using _2C2P.DAL.Models;

namespace _2C2P.DAL.BusinessImpl
{
    public class CustomerCardInfo : BusinessContract.ICardDetails
    {
        private SqlDBContext dbContext;

        public CustomerCardInfo()
        {
            dbContext = new SqlDBContext();
        }
        public CardDetails GetCardDetails(string CardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
