using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_Prototype_Pattern_
{
    /// <summary>
    /// Person  
    /// <author> Administrator </author>
    /// <createdate> 2020/6/17 14:40:09 </CreateDate>
    /// </summary>
    public class Person
    {
        public Person() {
            this.Name = "xiaoming";
            this.Age = 28;
        }

        public string Name;
        public int Age;
        public IPost post;
        public void Working()
        {
            Console.WriteLine(this.Name + "是一位" + this.Age + "岁的" + post.Name);
        }

        public Person Clone()
        {
            return this.MemberwiseClone() as Person;
        }

    }
}
