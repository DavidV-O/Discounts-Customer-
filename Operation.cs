using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Costomer_Discount.Class1;
using static Costomer_Discount.PreiumClass;
using static Costomer_Discount.ProClass;
using static Costomer_Discount.TrialCust;

namespace Costomer_Discount
{
    internal class Operation
    {
        class Program
        {
            static void Main()
            {
                Customer trial = new TrialCustomer("John", "Doe");
                Customer premium = new PremiumCustomer("Jane", "Smith");
                Customer pro = new ProCustomer("Alex", "Johnson");

                TestCustomer(trial, 4);
                TestCustomer(premium, 3);
                TestCustomer(pro, 7);
            }

            static void TestCustomer(Customer customer, int purchases)
            {
                Console.WriteLine($"\nCustomer Type: {customer.CustomerType}");
                customer.PrintName();

                for (int i = 1; i <= purchases; i++)
                {
                    decimal discount = customer.CalculateDiscountAmount(100m);
                    Console.WriteLine($"Purchase {i}: Discount = ${discount}");
                }
            }
        }



    }
}
