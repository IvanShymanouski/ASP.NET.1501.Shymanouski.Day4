using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
        private readonly IValueCalculator valueCalc;

        public IEnumerable<Product> Products { get; set; }

        public ShoppingCart(IValueCalculator valueCalc)
        {
            this.valueCalc = valueCalc;
        }

        public decimal CalculateProductTotal(int discount)
        {
            return valueCalc.ValueProducts(Products,discount);
        }
    }
}
