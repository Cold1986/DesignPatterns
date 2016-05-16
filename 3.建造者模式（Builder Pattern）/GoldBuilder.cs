using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// GoldBuilder类，具体构造者，黄金套餐
    /// </summary>
    public class GoldBuilder : Builder
    {
        private Food GoldFood = new Food();

        public override void BuildHamb()
        {
            GoldFood.Add("GoldHamb", "$13.5");
        }

        public override void BuildCoke()
        {
            GoldFood.Add("CokeCole", "$4.5");
        }

        public override void BuildChip()
        {
            GoldFood.Add("CokeChip", "$3.5");
        }

        public override Food GetFood()
        {
            return GoldFood;
        }
    }
}
