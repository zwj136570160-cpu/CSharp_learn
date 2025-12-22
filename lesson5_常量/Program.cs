namespace lesson5_常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("常量");

            #region 知识点一 常量的申明
            //关键字 const
            /*固定写法：
             * const 变量类型 变量名 = 初始值;*/
            //变量的申明
            int i = 1;
            //常量申明
            const int i2 = 1;
            #endregion

            #region 知识点二 常量的特点
            /*1.必须初始化
             2.不能被修改*/
            
            //变量申明可以不初始化
            string name;
            //之后可以来修改
            name = "CAKO";
            name = "楠楠";

            const string myNmae = "味精";

            //作用：申明一些常用不变的变量

            //PI 3.1415926
            const float PI = 3.1415925f;
            //后续也可以使用这个常量
            Console.WriteLine(PI);
            #endregion
        }
    }
}
