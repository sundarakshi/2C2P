using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators.Validators
{
    public class Master : Card
    {
        string _startsWith = "5";

        public Master(string cardNumber, int month, int year)
        {
            if (cardNumber.StartsWith(_startsWith) && CheckPrimeYear(year))
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


        private bool CheckPrimeYear(int year)
        {
            int CurrentYear = DateTime.Today.Year;
            int[] lstPrimeYears = { 2011, 2017, 2027, 2029, 2039, 2053 };
            if (year >= CurrentYear)
            {
                return (lstPrimeYears.Equals(year));
            
            }
            else
            {
                return false;
            }

        }
    }
}
