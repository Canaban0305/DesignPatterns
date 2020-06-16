using System;

namespace 单例模式
{
    /// <summary>
    /// Singleton Pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = SingletonObject.getInstance1().FuncName();
            string s2 = SingletonObject.getInstance2.FuncName();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.Read();
        }
    }
}
