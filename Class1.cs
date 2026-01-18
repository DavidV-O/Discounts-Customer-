using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Costomer_Discount.Program;

namespace Costomer_Discount
{
    internal class Class1
    {
        public abstract class Customer : ICustomer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CustomerType { get; protected set; }
            public decimal DiscountAmount { get; protected set; }
            protected int PurchaseCount { get; set; }

            protected Customer(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
                PurchaseCount = 0;
            }

            public void SetDiscountAmount(decimal discount)
            {
                DiscountAmount = discount;
            }

            public string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }

            public decimal GetDiscount()
            {
                return DiscountAmount;
            }

            public void PrintName()
            {
                Console.WriteLine(GetFullName());
            }

            public abstract decimal CalculateDiscountAmount(decimal purchaseAmount);
        }

    }
}
