namespace Costomer_Discount
{
    internal class Program
    {
        public interface ICustomer
        {
            void SetDiscountAmount(decimal discount);
            void PrintName();
            decimal CalculateDiscountAmount(decimal purchaseAmount);
            
        }

    }
}
