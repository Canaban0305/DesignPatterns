using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_Prototype_Pattern_.浅克隆
{
    /// <summary>
    /// RedColor  
    /// <author> Canaban </author>
    /// <createdate> 2020/6/16 17:43:41 </CreateDate>
    /// </summary>
    public class RedColor : IColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Name { get; set; }

        public IColor Clone()
        {
            return (IColor)this.MemberwiseClone();
        }
    }
}
