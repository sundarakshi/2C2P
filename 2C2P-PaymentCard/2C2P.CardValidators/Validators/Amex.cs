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

            if (cardNumber.StartsWith("34") && cardNumber.Length == _cardLength)
            {
                CardType = GetType().Name;
                CardResult = Result.Valid;
                return;
            }
            else if (cardNumber.StartsWith("37") && cardNumber.Length == _cardLength)
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
