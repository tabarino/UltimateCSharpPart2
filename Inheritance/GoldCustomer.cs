using System;

namespace Inheritance
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            base.Promote();
        }
    }
}
