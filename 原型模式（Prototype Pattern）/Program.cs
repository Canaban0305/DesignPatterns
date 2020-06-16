using System;
using System.Text;
using 原型模式_Prototype_Pattern_.浅克隆;

namespace 原型模式_Prototype_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======原型模式======");
            Console.WriteLine("====浅克隆：");

            IColor red = new RedColor();    // 标准红
            red.Name = "标准红";
            red.Red = 255;
            red.Blue = 0;
            red.Green = 0;
            Console.WriteLine("{3}：-red：{0},-green:{1},-blue:{2}", red.Red, red.Green, red.Blue, red.Name);

            IColor qianhong = red.Clone();
            qianhong.Red = 235;

            IColor qianhong2 = red.Clone();
            qianhong2.Red = 215;

            Console.WriteLine("{3}：-red：{0},-green:{1},-blue:{2}", qianhong.Red, qianhong.Green, qianhong.Blue, qianhong.Name);
            Console.WriteLine("{3}：-red：{0},-green:{1},-blue:{2}", qianhong2.Red, qianhong2.Green, qianhong2.Blue, qianhong2.Name);
            Console.WriteLine("{3}：-red：{0},-green:{1},-blue:{2}", red.Red, red.Green, red.Blue, red.Name);

            string name1 = qianhong.Name;
            string name2 = qianhong2.Name;

            Console.WriteLine("====深克隆：");
            Console.Read();
        }
    }
}
