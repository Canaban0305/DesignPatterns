using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂模式
{
    /// <summary>
    /// Phone子类    手机品牌  小米
    /// </summary>
    public class MI : Phone
    {
        public string GetPhoneMessage()
        {
            return "Vender Name:Xiao Mi";
        }
    }
}
