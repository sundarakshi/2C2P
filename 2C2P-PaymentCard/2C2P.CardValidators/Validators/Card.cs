using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators.Validators
{
    public class Card
    {
        public Result CardResult { get; set; }
        public string CardType { get; set; }
    }

    public enum Result
    {
        Valid,
        InValid,
        DoesNotExits
    }

    

}
