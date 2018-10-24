using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators.Validators
{
    public class DBCard : Card
    {

        public DBCard(string cardNumber, int month, int year)
        {
            DAL.BusinessImpl.CustomerCardInfo obj = new DAL.BusinessImpl.CustomerCardInfo();
            _2C2P.DAL.Models.CardDetails obj1 = obj.GetCardDetails(cardNumber);

            

        }

    }
}
