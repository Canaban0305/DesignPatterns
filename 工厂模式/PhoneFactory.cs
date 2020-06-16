using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂模式
{
    /// <summary>
    /// 工厂类：基于给定信息生成对应对象
    /// </summary>
    public class PhoneFactory
    {
        /// <summary>
        /// 根据枚举创建对应对象
        /// </summary>
        /// <param name="type">Vender</param>
        /// <returns>Phone</returns>
        public static Phone GetPhone(Enum type)
        {
            Phone phone = null;

            switch (type)
            {
                case Vender.Huawei:
                    phone = new Huawei();
                    break;
                case Vender.Mi:
                    phone = new MI();
                    break;
                default:
                    break;
            }

            return phone;
        }
    }
}
