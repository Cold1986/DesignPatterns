using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// NormalBuilder类，具体构造者，普通套餐
    /// </summary>
    public class NormalBuilder : Builder
    {
        private Food NormalFood = new Food();

        public override void BuildHamb()
        {
            NormalFood.Add("NorMalHamb", "$10.5");
        }

        public override void BuildCoke()
        {
            NormalFood.Add("NormalCoke", "$4.5");
        }

        public override void BuildChip()
        {
            NormalFood.Add("NormalChip", "$2");
        }

        public override Food GetFood()
        {
            return NormalFood;
        }
    }
}
