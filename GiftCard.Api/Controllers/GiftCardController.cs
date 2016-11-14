using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace GiftCard.Api.Controllers
{
    [Authorize]
    public class GiftCardController : ApiController
    {
        GiftCard.Repository.IGiftCardRepository _repository;
        Repository.Factories.GiftCardFactory giftCardFactory = new Repository.Factories.GiftCardFactory();
        public GiftCardController()
        {
            _repository = new GiftCard.Repository.GiftCardRepository();
        }

        public GiftCardController(GiftCard.Repository.IGiftCardRepository repository)
        {
            _repository = repository;
        }

        [Route("giftcard/{giftCardId}/balance")]
        [Authorize]
        [HttpGet]
        public IHttpActionResult Balance(int giftCardId)
        {
            try
            {
                var username = HttpContext.Current.GetOwinContext().Authentication.User.Identity.Name;

                //var username = "test@yahoo.com";
                var giftCard = _repository.GetGiftCard(giftCardId, username);

                if (giftCard == null)
                    return NotFound();
                else
                {
                    var giftCardDTO = giftCardFactory.CreateGiftCard(giftCard);
                    return Ok(giftCardDTO);
                }
            }
            catch (Exception e)
            {

                return InternalServerError();
            }
        }
    }
}
