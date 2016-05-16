using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// FoodManager类，即指导者
    /// </summary>
    public class FoodManager
    {
        public void Construct(Builder builder)
        {
            builder.BuildHamb();

            builder.BuildCoke();

            builder.BuildChip();
        }
    }
}
