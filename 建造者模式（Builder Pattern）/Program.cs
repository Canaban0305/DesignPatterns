using System;
using System.Xml;

namespace 建造者模式_Builder_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======建造者模式======");

            // 创建一个高配置的电脑
            var high = ComputerBuilder.HighConfiguration();
            Console.WriteLine("高配置:");
            high.ShowIIO();
            Console.WriteLine("总价格：" + high.getCost());

            Console.WriteLine("======================");

            // 创建一个低配置的电脑
            var low = ComputerBuilder.LowProfile();
            Console.WriteLine("低配置:");
            low.ShowIIO();
            Console.WriteLine("总价格：" + low.getCost());

            Console.Read();
        }
    }
}
