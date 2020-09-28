using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_Prototype_Pattern_
{
    /// <summary>
    /// TeamLeader  组长
    /// <author> Administrator </author>
    /// <createdate> 2020/6/17 14:46:47 </CreateDate>
    /// </summary>
    public class TeamLeader : IPost
    {
        public string Name => "组长";
    }
}
