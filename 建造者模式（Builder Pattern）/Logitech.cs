using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 实现IVender接口的实体类 -- 罗技品牌
    /// </summary>
    public class Logitech : IVender
    {
        public string VenderName() => "罗技";
    }
}
