using System;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======工厂模式======");
            Phone phone = PhoneFactory.GetPhone(Vender.Huawei);
            Console.WriteLine(phone.GetPhoneMessage());
            phone = PhoneFactory.GetPhone(Vender.Mi);
            Console.WriteLine(phone.GetPhoneMessage());
            Console.ReadLine();
        }
    }
}
