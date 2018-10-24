using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CardValidators.TestApp
{
    public class CardRequest
    {
        [JsonProperty("CardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("ValidMonth")]
        public int ValidMonth { get; set; }

        [JsonProperty("Amount")]
        public int ValidYear { get; set; }
    }


    public class CardResponse
    {
        [JsonProperty("CardName")]
        public string CardName { get; set; }

        [JsonProperty("CardStatus")]
        public string CardStatus { get; set; }
    }


}
