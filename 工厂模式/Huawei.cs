using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂模式
{
    /// <summary>
    /// Phone子类   手机品牌 华为
    /// </summary>
    public class Huawei : Phone
    {
        public string GetPhoneMessage()
        {
            return "Vender Name:Huawei";
        }
    }
}
