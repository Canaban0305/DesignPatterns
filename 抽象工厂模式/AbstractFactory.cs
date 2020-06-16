using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    public abstract class AbstractFactory
    {
        public abstract IMIBrand GetMIBrand(string type);
        public abstract IMorningLight GetMorningLight(string type);
    }
}
