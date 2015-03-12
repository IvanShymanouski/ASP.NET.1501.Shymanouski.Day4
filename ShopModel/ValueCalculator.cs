using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopModel
{
    public class ValueCalculator: IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products, int discount)
        {
            if (discount > 100) discount = 100;
            else
                if (discount < 0) discount = 0;
            decimal discountPercent = (decimal)(1 - discount / 100.0);

            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return sumOfProduct*discountPercent;
        }
    }
}
