using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 实现IVender接口的实体类 -- 英特尔品牌
    /// </summary>
    public class Intel : IVender
    {
        public string VenderName() => "英特尔";
    }
}
