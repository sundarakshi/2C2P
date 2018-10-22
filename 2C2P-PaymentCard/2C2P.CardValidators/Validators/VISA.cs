using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators.Validators
{
    public class VISA : Card
    {
        string _startsWith = "4";

        public VISA(string cardNumber, int  month, int year)
        {

            if (cardNumber.StartsWith(_startsWith) && CheckLeapYear(year))
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

        private bool CheckLeapYear(int Year)
        {
            return Year % 4 == 0; 
        }
    }
}
