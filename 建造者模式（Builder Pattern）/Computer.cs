using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 由零件组成的复杂对象 -- 电脑
    /// </summary>
    public class Computer
    {
        private List<IIO> components = new List<IIO>();

        public void AddIIO(IIO item)
        {
            components.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0f;
            foreach (var item in components)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowIIO()
        {
            foreach (var item in components)
            {
                Console.WriteLine("零件名称:{0},品牌:{1},价格:{2}", item.Name(), item.Vender().VenderName(), item.Price());
            }
        }
    }
}
