using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace 原型模式_Prototype_Pattern_
{
    /// <summary>
    /// GeneralStaff  普通员工
    /// <author> Administrator </author>
    /// <createdate> 2020/6/17 14:45:15 </CreateDate>
    /// </summary>
    public class GeneralStaff : IPost
    {
        public string Name => "普通员工";
    }
}
