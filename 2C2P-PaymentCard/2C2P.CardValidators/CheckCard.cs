using _2C2P.CardValidators.Validators;
using System;
using System.Collections.Generic;

namespace _2C2P.CardValidators
{

    public class CheckCard
    {
        public Card Response = new Card();
        public CheckCard(string cardNumber, int month, int year)
        {
            List<Card> objLst = new List<Card>();
            objLst.Add(new VISA(cardNumber,month,year));
            objLst.Add(new Master(cardNumber, month, year));
            objLst.Add(new JCB(cardNumber, month, year));
            objLst.Add(new Amex(cardNumber, month, year));


            for(int i=0;i<objLst.Count;i++)
            {
                if (objLst[i].CardType!=null)
                {
                    Response.CardResult = objLst[i].CardResult;
                    Response.CardType = objLst[i].CardType;
                    return;
                }
            }
                
                   
        }
    }
}
