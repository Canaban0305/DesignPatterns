using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// CPU扩展类  CPU扩展类  i5系列
    /// </summary>
    public class Inteli5CPU : CPU
    {
        public override string Name() => "Intel(R) Core(TM)i5-9400F CPU";

        public override float Price() => 2999.9f;
    }
}
