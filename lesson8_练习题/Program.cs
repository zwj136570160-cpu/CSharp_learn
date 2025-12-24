namespace lesson8_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("显示转换_练习题");

            #region 1.显示类型转换有几种方式？他们分别是什么，请举例说明？

            //括号强转
            //有符号
            sbyte sb = 1;
            int i = 1;
            short s = 1;
            long l = 1;
            i = (int)sb;
            i = (int)s;
            i = (int)l;
            //无符号
            byte b = 1;
            uint ui = 1;
            ushort us = 1;
            ulong ul = 1;
            b = (byte)us;
            us = (ushort)ul;
            //浮点数
            float f = 1;
            double d = 1;
            f = (float)d;

            //parse方法
            long l2 = int.Parse("3");
            short i2 = byte.Parse("112");
            ulong ul2 = ushort.Parse("4");

            //Convert方法
            long l3 = Convert.ToInt64("123");
            byte b3 = Convert.ToByte("1");
            short s3 = Convert.ToInt16("123");
            int i3 = Convert.ToInt32("123");

            //其他类型转string
            string s4 = 1.ToString();
            long l4 = 5;
            s4 = l4.ToString();
            #endregion

            #region 2.请将24069转成字符，并打印
            Console.WriteLine(Convert.ToChar(24069));
            Console.WriteLine((char)24069);
            #endregion

            #region 3.提示用户输入姓名、语文、数学、英语成绩，并将输入的3门成绩用整形变量存储
            Console.WriteLine("请输入姓名");
            //通过字符串变量 把输入内容存起来
            string str = Console.ReadLine();
            
            Console.WriteLine("请输入语文成绩");
            str = Console.ReadLine();
            int yuWen_GPA = int.Parse(str);
            Console.WriteLine("请输入数学成绩");
            str = Console.ReadLine();
            int shuXue_GPA = int.Parse(str);
            Console.WriteLine("请输入英语成绩");
            str = Console.ReadLine();
            int yingYu_GPA = int.Parse(str);

            Console.WriteLine("你的各科成绩为：" + "语文：" + yuWen_GPA + "数学：" + shuXue_GPA + "英语：" + yingYu_GPA);
            



            #endregion



        }
    }
}
