using System.Text;

namespace lesson7_类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——隐式转换");
            // 什么是类型转换
            //类型转换 就是不同变量之间的相互转换

            //隐式转换的基本规则——>不同类型之间自动转换
            //大范围装小范围

            #region 知识点一 相同大类型之间的转换
            //有符号 long——>int——>short——>sbyte 
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;
            //隐式转换 int隐式转换为了long
            //可以用大范围 装小范围的 类型（类型转换）
            l = i;
            //不能够用小范围的类型去装载大范围的类型
            //i = l;    int<——long 无法转换会报错
            l = i;
            l = s;
            l = sb;
            i = s;
            s = sb;
            //sb = s;   sbyte<——short 无法转换会报错

            //无符号 ulong——>uint——>ushort——>byte
            ulong ul = 1;
            uint ui = 1;
            ushort us = 1;
            byte b = 1;

            ul = ui;
            ul = us;
            ul = b;
            ui = us;
            ui = us;
            ui = b;
            us = b;
            
            //浮点数 decimal(X) double——>float
            decimal de = 1.1m;
            double d = 1.1;
            float f = 1.1f;
            //decimal这个类型 没有办法用隐式转换的形式 去存储double和float
            //de = d;
            //de = f;
            //float 式可以隐式转换成 double
            d = f;

            //特殊类型 bool char string
            //他们之间 不存在隐式转换
            bool a = true;
            char c = 'a';
            string str = "abc";
            #endregion

            #region 知识点二 不相同大类型之间的转换

            #region 无符号和有符号之间
            //无符号(不能装负数)
            byte b2 = 1; //0~255
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号
            //b2 = sb2;
            //us2 = sb2;
            //ul2 = sb2;

            //有符号装无符号
            //i2 = ui2;   //因为有符号的变量 可能会超过 这个无符号的数
            i2 = b2;    //因为有符号的变量 不管是多少 都在无符号的范围内
            #endregion

            #region 浮点数和整数（有、无符号）之间
            //浮点数装整数 整形转为浮点数 是存在隐式转换的 
            //无符号
            byte b3 = 1; //0~255
            ushort us3 = 1;
            uint ui3 = 1;
            ulong ul3 = 1;
            //有符号
            sbyte sb3 = 1;
            short s3 = 1;
            int i3 = 1;
            long l3 = 1;
            //浮点数
            float f2 = 1.1f;
            double d2 = 1.1;
            decimal de2 = 1.1m;
            
            //浮点数 是可以装载任何类型的 整数的
            f2 = ui3;
            f2 = ul3;
            f2 = us3;
            f2 = b3;

            f2 = i3;
            f2 = ul3;
            f2 = ui3;
            f2 = sb3;
            f2 = us3;

            f2 = 1000000000000000000;
            Console.WriteLine(f2);

            //decimal 不能隐式存储 float和double
            //但是他可以隐式的存储整数
            de = l3;
            de2 = ul3;

            //整数装浮点数 整数是不能隐式存储 浮点数 因为整数不能存小数
            //i3 = f2;

            #endregion

            #region 特殊类型和其他类型之间
            
            //无符号
            byte b4 = 1; //0~255
            ushort us4 = 1;
            uint ui4 = 1;
            ulong ul4 = 1;
            //有符号
            sbyte sb4 = 1;
            short s4 = 1;
            int i4 = 1;
            long l4 = 1;
            //浮点数
            float f4 = 1.1f;
            double d4 = 1.1;
            decimal de4 = 1.1m;

            //bool bool没有办法和其他类型 相互隐士转换
            bool bo2 = true;
            char c2 = 'A';
            string str2 = "123321";
            //bo2 = i4;
            //bo2 = ui4;
            //bo2 = f4;

            //i4 = bo2;
            //ui4 = bo2;
            //f4 = bo2;

            //bo2 = c4;
            //c2 = bo2;
            //bo2 = str2;
            //str2 = bo2;

            //char char没有办法隐式存储 为其他类型的变量
            //c2 = i4;
            //c2 = ui4;
            //c2 = f4;
            //c2 = str2;

            //char 类型可以隐式的转换成 整数和浮点数
            //char隐式转换成 数值类型是 对应的数字
            //计算机里面存储 2进制 
            //字符 中文 英文 标点符号 在计算机中都是一个数字
            //一个字符 对应一个数字 ASCII码就是一种对应关系
            i4 = c2;
            Console.WriteLine(i4);
            ui4 = c2;
            Console.WriteLine(ui4);
            f4 = c2;
            Console.WriteLine(f4);
            //str2 = c2;

            //string 类型 无法和其他类型进行隐式转换
            //i2 = str2;
            //ui2 = str2;
            //f2 = str2;

            #endregion
            #endregion
        }
    }
}
