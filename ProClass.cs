using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Costomer_Discount.Class1;

namespace Costomer_Discount
{
    internal class ProClass
    {
        public class ProCustomer : Customer
        {
            public ProCustomer(string firstName, string lastName)
                : base(firstName, lastName)
            {
                CustomerType = "Pro";
            }

            public override decimal CalculateDiscountAmount(decimal purchaseAmount)
            {
                PurchaseCount++;

                if (PurchaseCount <= 5)
                {
                    SetDiscountAmount(0.25m);
                }
                else
                {
                    SetDiscountAmount(0.10m);
                }

                return purchaseAmount * DiscountAmount;
            }
        }


    }
}
