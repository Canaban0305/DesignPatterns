using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 实现IVender接口的实体类 -- 雷蛇品牌
    /// </summary>
    public class Razer : IVender
    {
        public string VenderName() => "雷蛇";
    }
}
