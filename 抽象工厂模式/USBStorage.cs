using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    public class USBStorage : IMIBrand
    {
        public void PrintName()
        {
            Console.WriteLine("U盘");
        }
    }
}
