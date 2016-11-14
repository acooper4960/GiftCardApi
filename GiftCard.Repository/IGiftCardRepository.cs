using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCard.Repository
{
    public interface IGiftCardRepository
    {
        GiftCard.Repository.Entities.GiftCard GetGiftCard(int id, string username);
    }
}
