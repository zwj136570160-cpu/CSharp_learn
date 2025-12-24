namespace lesson6_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //请用至少两种方式在控制台打印出：
            //我是小明
            //我今年18
            //我的爱好是制作游戏
            //我要好好学习，天天向上

            #region 方式一
            Console.WriteLine("我是小明");
            Console.WriteLine("我今年18");
            Console.WriteLine("我的爱好是制作游戏");
            Console.WriteLine("我要好好学习，天天向上");

            Console.WriteLine("---------------------------------------------");
            #endregion

            #region 方式二
            Console.WriteLine("我是\'小明\'\n我今年18\n我的爱好是\"制作游戏\"\n我要好好学习，天天向上");
            #endregion
        }
    }
}
