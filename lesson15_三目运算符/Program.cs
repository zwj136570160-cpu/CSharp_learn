namespace lesson15_三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三目运算符");

            #region 知识点一 基本语法
            //套路：三个空位，2个符号
            //固定语法：(空位)?(空位):(空位);
            //关键信息：bool类型 ? bool类型为真返回内容 : bool类型为假返回内容;
            //三目运算符会有返回值，这个返回值类型必须一致，并且必须使用
            #endregion

            #region 知识点二 具体使用
            string str = false ? "条件为真" : "条件为假";
            Console.WriteLine(str);
            Console.WriteLine("*********************************");

            int a = 5;
            str = a < 1 ? "a大于1" : "a不满足条件";
            Console.WriteLine(str);
            Console.WriteLine("*********************************");

            int i = a > 1 ? 123 : 234;
            Console.WriteLine(i);
            #endregion
        }
    }
}
