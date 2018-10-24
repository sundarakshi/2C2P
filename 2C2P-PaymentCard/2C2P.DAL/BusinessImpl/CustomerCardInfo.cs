using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using _2C2P.DAL.Models;
using System.Data.SqlClient;

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
            CardDetails obj = new CardDetails();
            var idParam = new SqlParameter
            {
                ParameterName = "id",
                Value = 1
            };
            var courseList = dbContext.Database.SqlQuery<Models.CardDetails>("exec select * from CardDetails where CardNumber=@id", idParam);
            return obj;
        }
    }
}
