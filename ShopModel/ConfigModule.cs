using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ShopModel
{
    class ConfigModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IValueCalculator>().To<ValueCalculator>();
            Bind<ShoppingCart>().ToSelf();
        }
    }
}
