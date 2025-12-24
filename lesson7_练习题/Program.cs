namespace lesson7_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 什么情况下会出现数据类型的隐式转换，请举例说明
            int i = 1;
            short s = 1;
            i = s;
            #endregion

            #region 请将自己名字的每一个字符转换成数字并打印出来
            char name1 = '味';
            char name2 = '精';
            int num1 = 1;
            int num2 = 1;
            num1 = name1;
            num2 = name2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine("--------------------------------------------");
            int name_num1 = '味';
            int name_num2 = '精';
            Console.WriteLine(name_num1 + name_num2);
            Console.WriteLine("味精对应的数字编号：" + name_num1 + name_num2);

            #endregion
        }
    }
}
