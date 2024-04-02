using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Client
    {
        public string Name { get; set; }
        public List<CreditOffer> CreditOffers { get; set; }

        public Client(string name)
        {
            Name = name;
            CreditOffers = new List<CreditOffer>();
        }


        public CreditOffer FindCreditOffer(string bankName, Type creditType)
        {
            foreach (var offer in CreditOffers)
            {
                if (offer.BankName == bankName && offer.GetType() == creditType)
                {
                    return offer;
                }
            }
            return null;
        }
    }
}
