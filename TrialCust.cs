using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Costomer_Discount.Class1;

namespace Costomer_Discount
{
    internal class TrialCust
    {
        public class TrialCustomer : Customer
        {
            public TrialCustomer(string firstName, string lastName)
                : base(firstName, lastName)
            {
                CustomerType = "Trial";
            }

            public override decimal CalculateDiscountAmount(decimal purchaseAmount)
            {
                PurchaseCount++;

                if (PurchaseCount <= 3)
                {
                    SetDiscountAmount(0.10m);
                }
                else
                {
                    SetDiscountAmount(0.0m);
                }

                return purchaseAmount * DiscountAmount;
            }
        }


    }
}
