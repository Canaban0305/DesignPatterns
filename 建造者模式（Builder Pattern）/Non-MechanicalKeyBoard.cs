using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// KeyBoard扩展类  键盘扩展类  非机械键盘
    /// </summary>
    public class Non_MechanicalKeyBoard : KeyBoard
    {
        public override string Name() => "非机械键盘M67";

        public override float Price() => 128.0f;
    }
}
