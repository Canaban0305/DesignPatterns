using System;
using System.Collections.Generic;
using System.Text;
using 原型模式_Prototype_Pattern_.浅克隆;

namespace 原型模式_Prototype_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======原型模式======");
            Console.WriteLine("====浅克隆：");

            Person xiaoming = new Person();
            xiaoming.post = new GeneralStaff();
            xiaoming.Working();

            Person zhangsan = xiaoming.Clone();
            zhangsan.Name = "zhangsan";
            //zhangsan.Age = 30;
            zhangsan.Working();

            IPost p1 = xiaoming.post;

            zhangsan.post = new TeamLeader();

            IPost p2 = xiaoming.post;
            zhangsan.Working();
            xiaoming.Working();

            Console.WriteLine("====深克隆：");
            Console.Read();
        }
    }
}
