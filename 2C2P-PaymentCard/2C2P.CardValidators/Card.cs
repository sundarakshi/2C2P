using System;
using System.Collections.Generic;
using System.Text;

namespace _2C2P.CardValidators
{
    public class Card
    {
        public Result CardResult { get; set; }
        public string CardType { get; set; }

        
    }

    public enum Result
    {
        InValid,
        Valid,      
        DoesNotExits
    }

    

}
