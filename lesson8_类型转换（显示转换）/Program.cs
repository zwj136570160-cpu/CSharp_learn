namespace lesson8_类型转换_显示转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——显示转换");
            //显示转换——>手动处理 强制转换
            #region 知识点一 括号强转
            //作用：一般情况下，讲高精度的类型强制转换为低精度
            //语法：变量类型 变量名 = (变量类型)变量;
            //注意：精度问题 范围问题

            //相同大类的整数
            //有符号整数
            sbyte sb = 1;
            short s = 1;
            int i = 40000;
            long l = 1;

            //括号强转 可能会出现范围问题 造成的异常  
            s = (short)i;
            Console.WriteLine(s);

            i = (int)l;
            sb = (sbyte)s;
            sb = (sbyte)i;
            sb = (sbyte)l;

            //无符号整形
            byte b = 1;
            ushort us = 1;
            b = (byte)us;

            //浮点之间
            float f = 1.1f;
            double d = 1.12341234123412341234;
            f = (float)d;
            Console.WriteLine(f);

            //无符号转有符号
            uint ui2 = 1;
            int i2 = -1;
            ui2 = (uint)i2;
            Console.WriteLine(ui2);

            //有符号转无符号
            i2 = (int)ui2;

            //浮点和整形
            //浮点数强转整形时，会直接抛弃掉小数点后面的小数
            i2 = (int)1.24f;
            Console.WriteLine(i2);

            //char和数值类型
            i2 = 'A';
            char c = (char)i2;
            Console.WriteLine(c);

            //bool和string
            //不能通过括号强转
            bool bo = true;
            //int i3 = (bool)bo;

            string str = "123";
            //i3 = (int)bo;
            #endregion

            #region 知识点二 Parse法
            //作用：把字符串类型转换为对应的类型
            //语法：变量类型.parse("字符串")
            //注意：字符串必须能够转换成对应类型 否则报错

            //有符号
            int i4 = int.Parse("123");
            //Console.WriteLine(i4);
            //我们填写字符串 必须式要能够转成对应类型的字符，如果不符合规则 会报错
            //i4 = int.Parse("123.45");
            //Console.WriteLine(i4);
            //值的范围：必须是能够被变量存储的值 否则报错
            //short s3 = short.Parse("40000");
            //Console.WriteLine(s3);

            sbyte sb3 = sbyte.Parse("1");
            Console.WriteLine(sb3);
            //他们的意思是相同的
            Console.WriteLine(sbyte.Parse("1"));
            Console.WriteLine(long.Parse("123123"));

            //无符号
            Console.WriteLine(byte.Parse("123"));
            Console.WriteLine(uint.Parse("123"));
            Console.WriteLine(ulong.Parse("123"));
            Console.WriteLine(ushort.Parse("123"));

            //浮点数
            float f2 = float.Parse("123");
            double d2 = double.Parse("123");

            //特殊类型
            bool b2 = bool.Parse("True");
            Console.WriteLine(b2);

            char c2 = char.Parse("1");
            Console.WriteLine(c2);

            #endregion

            #region 知识点三 Convert法
            //作用：更准确的将 各个类型之间进行相互转换
            //语法：Convert.To目标类型(变量或常量)
            //注意：填写的变量或常量必须正确 否则出错

            //转字符串 如果是把字符串对应类型 那字符串一定要合法合规
            int a = Convert.ToInt32("12");
            Console.WriteLine(a);
            //精度比括号强转好一点 会四舍五入
            a = Convert.ToInt32(1.65845f);
            Console.WriteLine(a);

            a = Convert.ToInt32(true);
            Console.WriteLine(a);
            a = Convert.ToInt32(false);
            Console.WriteLine(a);

            a = Convert.ToInt32('A');
            Console.WriteLine(a);

            //每一个类型都存在对应的Convert中的方法
            //有符号
            sbyte sb4 = Convert.ToSByte("1");
            short s5 = Convert.ToInt16("1");
            int i5 = Convert.ToInt32("1");
            long l2 = Convert.ToInt64("1");

            //无符号
            byte b3 = Convert.ToByte("1");
            ushort us2 = Convert.ToUInt16("1");
            uint i6 = Convert.ToUInt32("1");
            ulong l3 = Convert.ToUInt64("1");

            //浮点数
            float f3 = Convert.ToSingle("1");
            double d3 = Convert.ToDouble("1");
            decimal de = Convert.ToDecimal("1");

            //特殊类型
            bool bo3 = Convert.ToBoolean("true");
            char ch = Convert.ToChar("A");
            string str3 = Convert.ToString("123");
            #endregion

            #region 知识点四 其他类型转string
            //作用：拼接打印
            //语法：变量.tostring();

            string str4 = 1.ToString();
            str4 = true.ToString();
            str4 = 1.2f.ToString();

            int aa = 1;
            str4 = aa.ToString();
            bool bo6 = true;
            str4 = bo6.ToString();

            //当我们进行字符串拼接时，就自动会调用tostring转成string
            Console.WriteLine("123123" + true + 1);

            str4 = "123123" + true + 1 + 1.23f;

            #endregion
        }
    }
}
