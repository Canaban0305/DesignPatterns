using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 实现IIO接口的实体类 -- 鼠标
    /// </summary>
    public abstract class Mouse : IIO
    {
        public abstract string Name();

        public abstract float Price();

        public IVender Vender() => new Razer();
    }
}
