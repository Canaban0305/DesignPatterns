using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 实现IIO接口的实体类 -- CPU
    /// </summary>
    public abstract class CPU : IIO
    {
        public abstract string Name();

        public abstract float Price();

        public IVender Vender() => new Intel();
    }
}
