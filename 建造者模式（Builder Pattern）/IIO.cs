using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 零件
    /// </summary>
    public interface IIO
    {
        /// <summary>
        /// 零件名称
        /// </summary>
        /// <returns></returns>
        string Name();
        /// <summary>
        /// 零件品牌
        /// </summary>
        /// <returns></returns>
        IVender Vender();
        /// <summary>
        /// 价格
        /// </summary>
        /// <returns></returns>
        float Price();
    }
}
