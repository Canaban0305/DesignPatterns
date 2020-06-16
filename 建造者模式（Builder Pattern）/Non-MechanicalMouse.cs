using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// Mouse扩展类  鼠标扩展类  非机械鼠标
    /// </summary>
    public class Non_MechanicalMouse : Mouse
    {
        public override string Name() => "非机械鼠标S857";

        public override float Price() => 99.0f;
    }
}
