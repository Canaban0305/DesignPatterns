using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// CPU扩展类  CPU扩展类  i7系列
    /// </summary>
    public class Inteli7CPU : CPU
    {
        public override string Name() => "Intel(R) Core(TM)i7-8500U CPU";

        public override float Price() => 3999.0f;
    }
}
