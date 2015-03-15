using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public interface IDiscountCalculator
    {
        decimal DiscountProducts(IEnumerable<Product> products, decimal Sum, int  discount=0);
    }
}
