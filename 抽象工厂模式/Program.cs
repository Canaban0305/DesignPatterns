using System;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象工厂模式");
            // 获取小米品牌工厂
            AbstractFactory mi_Factory = FactoryProducter.GetFactory("MIBrand");

            // 获取小米品牌下得小米手机商品
            IMIBrand mi_Phone = mi_Factory.GetMIBrand("Phone");

            // 调用方法
            mi_Phone.PrintName();

            // 获取晨光品牌工厂
            AbstractFactory morning_Factory = FactoryProducter.GetFactory("MorningLight");

            // 获取晨光品牌下得笔记本商品
            IMorningLight morning_Phone = morning_Factory.GetMorningLight("NoteBook");

            // 调用方法
            morning_Phone.PrintIn();

            Console.ReadLine();
        }
    }
}
