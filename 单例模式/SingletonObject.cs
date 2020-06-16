using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    public class SingletonObject
    {
        // 唯一实例
        private static SingletonObject singleton;
        // 私有构造函数（限制外部实例化）
        private SingletonObject()
        {

        }

        /// <summary>
        /// 提供外部获取该类实例的静态方法（可带参数）
        /// </summary>
        /// <returns>SingletonObject</returns>
        public static SingletonObject getInstance1()
        {
            if (singleton == null)
                singleton = new SingletonObject();
            return singleton;
        }

        // 只读属性（无法带参数）
        public static SingletonObject getInstance2
        {
            get
            {
                if (singleton == null)
                    singleton = new SingletonObject();
                return singleton;
            }
        }

        /// <summary>
        /// 类内部方法
        /// </summary>
        /// <returns></returns>
        public string FuncName()
        {
            return "This is Singleton Pattern";
        }
    }
}
