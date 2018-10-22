using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators.Validators
{
    public class JCB : Card
    {
        string[] _startsWith = { "3528", "3589" };

        public JCB(string cardNumber, int month, int year)
        {

            if (cardNumber.StartsWith("3528"))
            {
                CardType = GetType().Name;
                CardResult = Result.Valid;
                return;
            }
            else if (cardNumber.StartsWith("3589"))
            {
                CardType = GetType().Name;
                CardResult = Result.Valid;
                return;
            }
            else
            {
                CardResult = Result.InValid;
                return;
            }
        }
    }
}

