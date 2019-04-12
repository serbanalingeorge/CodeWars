using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitStrings.Decorator
{
    public abstract class BasePizza
    {
        protected double myPrice;

        public virtual double GetPrice()
        {
            return myPrice;
        }
    }
}
