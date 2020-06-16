using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_Prototype_Pattern_.浅克隆
{
    /// <summary>
    /// 颜色接口
    /// </summary>
    public interface IColor
    {
        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }
        string Name { get; set; }

        IColor Clone();
    }
}
