namespace lesson11_字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接");
                
            #region 知识点一 字符串拼接方式1
            string str = "123";
            //用+号进行字符串拼接
            str = str + "456";
            Console.WriteLine(str);
            str = str + 1;
            Console.WriteLine(str);
            Console.WriteLine("*********************************");

            //复合运算符 +=
            str = "123";
            str += "1" + 4 + true;
            Console.WriteLine(str);
            Console.WriteLine("***************************************");
            str += 1 + 2 + 3 + 4;
            Console.WriteLine(str);
            Console.WriteLine("***************************************");
            #endregion

            #region 知识点二 字符串拼接方式2
            //固定语法:string.Format("待拼接的内容", 内容1, 内容2......);
            //拼接内容中的固定规则:想要拼接的内容用占位符替代{数字} 数字：0~n，依次往后

            string str2 = string.Format("我是{0}，我今年{1}岁，我想要{2}", "味精", 27, "天天学习，好好向上");
            Console.WriteLine(str2);
            Console.WriteLine("******************************************");

            str2 = string.Format("{0}{1}{2}", 1, true, false);
            Console.WriteLine(str2);
            Console.WriteLine("******************************************");
            #endregion

            #region 控制台打印拼接
            Console.WriteLine("A{0}B{1}C{2}", 1, true, false,1,2);
            Console.Write("A{0}B{1}C{2}", 1, true);
            #endregion
        }
    }
}
