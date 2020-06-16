using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    public class NoteBook : IMorningLight
    {
        public void PrintIn()
        {
            Console.WriteLine("笔记本");
        }
    }
}
