using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftCard.Repository.Entities;

namespace GiftCard.Repository
{
    public class GiftCardRepository : IGiftCardRepository
    {
        GiftCardEntityContext _ctx;
        public GiftCardRepository()
        {
            _ctx = new GiftCardEntityContext();
        }

        public GiftCardRepository(GiftCardEntityContext ctx)
        {
            _ctx = ctx;
        }
        public Entities.GiftCard GetGiftCard(int id, string username)
        {

            var giftCard = _ctx.GiftCards
                .Where(x => x.Id == id)
                .FirstOrDefault();

            return giftCard;
        }
    }
}
