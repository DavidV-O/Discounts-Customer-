using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Costomer_Discount.Class1;

namespace Costomer_Discount
{
    internal class PreiumClass
    {
        public class PremiumCustomer : Customer
        {
            public PremiumCustomer(string firstName, string lastName)
                : base(firstName, lastName)
            {
                CustomerType = "Premium";
                SetDiscountAmount(0.10m);
            }

            public override decimal CalculateDiscountAmount(decimal purchaseAmount)
            {
                PurchaseCount++;
                return purchaseAmount * DiscountAmount;
            }
        }

    }
}
