using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace _2C2P.CardAPI.Models
{
  
    public class CardInfo
    {
        [JsonProperty("CardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("ValidMonth")]
        public int ValidMonth{ get; set; }

        [JsonProperty("Amount")]
        public int ValidYear{ get; set; }

    }
}