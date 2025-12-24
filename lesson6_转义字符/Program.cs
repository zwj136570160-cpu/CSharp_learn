namespace lesson6_转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符");

            #region 知识点一 转义字符的使用
            //什么是转义字符？
            //他是字符串的一部分，用来表示一些特殊含义的字符
            //比如：在字符串中表现，单引号 引号 空行等等

            #region 固定写法
            //固定写法 \字符
            //不同的 \和字符的组合 表示不同的含义

            //常用转义字符 
            //单引号 \'
            string str = "\'哈哈哈哈\'";
            Console.WriteLine(str);

            Console.WriteLine("---------------------------------");
            
            //双引号 \"
            str = "\"哈哈哈\"";
            Console.WriteLine(str);

            Console.WriteLine("---------------------------------");

            //换行 \n
            str = "1231231\n2312312312";
            Console.WriteLine(str);

            Console.WriteLine("---------------------------------");

            //斜杠 \\
            str = "哈哈\\哈哈哈";
            Console.WriteLine(str);

            Console.WriteLine("---------------------------------");

            //不常用的转义字符
            //制表符（空一格tab键）
            str = "哈哈\t哈哈哈";
            Console.WriteLine(str);

            Console.WriteLine("---------------------------------");

            //光标退格
            str = "123\b123";
            Console.WriteLine(str);

            Console.WriteLine("-------------- -------------------");

            //空字符
            str = "1234\0123";
            Console.WriteLine(str);

            Console.WriteLine("-------------- -------------------");

            //警报音
            str = "\a";
            Console.WriteLine(str);

            Console.WriteLine("-------------- -------------------");
            #endregion

            #endregion

            #region 知识点二 取消转义字符
            string str2 = @"哈哈\哈哈";
            Console.WriteLine(str2);

            Console.WriteLine("-------------- -------------------");

            Console.WriteLine(@"\n\\");
            #endregion
        }
    }
}
