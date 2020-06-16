using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    /// <summary>
    /// 超级工厂
    /// </summary>
    public class FactoryProducter
    {
        public static AbstractFactory GetFactory(string facType)
        {
            AbstractFactory factory = null;
            switch (facType)
            {
                case "MIBrand":
                    factory = new MIBrandFactory();
                    break;
                case "MorningLight":
                    factory = new MorningLightFactory();
                    break;
                default:
                    break;
            }
            return factory;
        }
    }
}
