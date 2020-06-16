using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    /// <summary>
    /// MIBrand工厂
    /// </summary>
    public class MIBrandFactory : AbstractFactory
    {
        public override IMIBrand GetMIBrand(string type)
        {
            IMIBrand brand = null;
            switch (type)
            {
                case "Phone":
                    brand = new MIPhone();
                    break;
                case "USB":
                    brand = new USBStorage();
                    break;
                default:
                    break;
            }
            return brand;
        }

        public override IMorningLight GetMorningLight(string type)
        {
            return null;
        }
    }
}
