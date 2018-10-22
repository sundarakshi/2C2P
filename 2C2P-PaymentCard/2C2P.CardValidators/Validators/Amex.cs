using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators.Validators
{
    public class Amex : Card
    {
        string[] _startsWith = { "34","37"};
        int _cardLength = 15;

        public Amex(string cardNumber, int month, int year)
        {
            bool response=false;

            foreach (string num in _startsWith)
            {
                if (cardNumber.StartsWith(num))
                    response = true;
                else
                {
                    response = false;
                    return;
                }
            }


            if (response && cardNumber.Length == _cardLength )
            {
                CardType = GetType().Name;
                CardResult = Result.Valid;
            }
            else
            {
                CardResult = Result.InValid;
                CardType = "UnKnown";
            }
        }
    }
}
