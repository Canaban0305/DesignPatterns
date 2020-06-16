using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    public class Pen : IMorningLight
    {
        public void PrintIn()
        {
            Console.WriteLine("钢笔");
        }
    }
}
