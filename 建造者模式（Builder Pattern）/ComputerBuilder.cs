using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_Builder_Pattern_
{
    /// <summary>
    /// 负责创建 Computer 对象
    /// </summary>
    public class ComputerBuilder
    {
        /// <summary>
        /// 创建高配置电脑
        /// </summary>
        public static Computer HighConfiguration()
        {
            Computer computer = new Computer();
            computer.AddIIO(new Inteli7CPU());  // i7处理器
            computer.AddIIO(new MechanicalKeyBoard());     // 机械键盘
            computer.AddIIO(new MechanicalMouse());     // 机械鼠标

            return computer;
        }

        /// <summary>
        /// 创建低配置电脑
        /// </summary>
        public static Computer LowProfile()
        {
            Computer computer = new Computer();
            computer.AddIIO(new Inteli5CPU());  // i5处理器
            computer.AddIIO(new Non_MechanicalKeyBoard());  // 非机械键盘
            computer.AddIIO(new Non_MechanicalMouse()); // 非机械鼠标

            return computer;
        }
    }
}
