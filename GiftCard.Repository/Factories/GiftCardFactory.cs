using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GiftCard.Repository.Factories
{
    public class GiftCardFactory
    {
        public GiftCard.Dto.GiftCard CreateGiftCard(GiftCard.Repository.Entities.GiftCard giftCard)
        {
            return new Dto.GiftCard()
            {
                UserName = giftCard.UserName,
                Description = giftCard.Description,
                Id = giftCard.Id
            };
        }
    }
}
