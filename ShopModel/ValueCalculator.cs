using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopModel
{
    public class ValueCalculator: IValueCalculator
    {
        private readonly IDiscountCalculator discountCalc;

        public ValueCalculator(IDiscountCalculator discountCalc)
        {
            this.discountCalc = discountCalc;
        }

        public decimal ValueProducts(IEnumerable<Product> products, int discount)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return discountCalc.DiscountProducts(products, sumOfProduct, discount);
        }
    }
}
