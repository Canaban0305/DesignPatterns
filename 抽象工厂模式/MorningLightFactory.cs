using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    /// <summary>
    /// MorningLight工厂
    /// </summary>
    public class MorningLightFactory : AbstractFactory
    {
        public override IMIBrand GetMIBrand(string type)
        {
            return null;
        }

        public override IMorningLight GetMorningLight(string type)
        {
            IMorningLight brand = null;
            switch (type)
            {
                case "NoteBook":
                    brand = new NoteBook();
                    break;
                case "Pen":
                    brand = new Pen();
                    break;
                default:
                    break;
            }
            return brand;
        }
    }
}
