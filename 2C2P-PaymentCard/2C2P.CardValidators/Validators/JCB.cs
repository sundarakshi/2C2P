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
            bool response = false;

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


            if (response)
            {
                CardType = GetType().Name;
                CardResult = Result.Valid;
            }
        }
    }
}

