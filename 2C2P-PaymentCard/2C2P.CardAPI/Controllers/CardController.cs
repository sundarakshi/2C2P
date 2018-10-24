using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _2C2P.CardAPI.Controllers
{
    public class CardController : ApiController
    {

        [HttpGet]
        public _2C2P.CardAPI.Models.CardValidateResponse GetCardDetails(string cardNumber,int month,int year)
        {
            
            Models.CardValidateResponse cardValidateResponse = new Models.CardValidateResponse();
            _2C2P.CardValidators.CheckCard obj = new CardValidators.CheckCard(cardNumber, month, year);
            cardValidateResponse.CardName = obj.Response.CardType;
            return cardValidateResponse;
        }

        [HttpPost]
        [Route("api/CardCheck/")]
        [ActionName("CardCheck")]
        public Models.CardValidateResponse CardCheck([FromBody] Models.CardInfo _cardInfo)
        {
            Models.CardValidateResponse cardValidateResponse = new Models.CardValidateResponse();
            _2C2P.CardValidators.CheckCard obj = new CardValidators.CheckCard(_cardInfo.CardNumber.ToString(), _cardInfo.ValidMonth, _cardInfo.ValidYear);
            cardValidateResponse.CardName = obj.Response.CardType;
            return cardValidateResponse;
        }


        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

    }
}