using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// Mouse扩展类  鼠标扩展类  机械鼠标
    /// </summary>
    public class MechanicalMouse : Mouse
    {
        public override string Name() => "机械鼠标K928";

        public override float Price() => 399.0f;
    }
}
