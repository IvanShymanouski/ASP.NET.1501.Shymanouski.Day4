using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public decimal DiscountProducts(IEnumerable<Product> products, decimal Sum, int discount)
        {
             if (discount > 100) discount = 100;
            else
                if (discount < 0) discount = 0;
            decimal discountPercent = (decimal)(1 - discount / 100.0);

            return Sum * discountPercent;
        }
    }
}
