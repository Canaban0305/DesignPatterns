using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// KeyBoard扩展类  键盘扩展类  机械键盘
    /// </summary>
    public class MechanicalKeyBoard : KeyBoard
    {
        public override string Name() => "机械键盘P230";

        public override float Price() => 328.9f;
    }
}
