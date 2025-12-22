namespace lesson1_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson1_练习题讲解");

            //打印信息后不换行
            Console.Write("");
            //打印信息后换行
            Console.WriteLine("");

            //检测键盘的一键输入
            Console.ReadKey();
            //检测键盘的一系列输入，回车结束
            Console.ReadLine();

            //请用户输入用户名、年龄、班级
            Console.WriteLine("请输入用户名");
            Console.ReadLine();
            Console.WriteLine("请输入年龄");
            Console.ReadLine();
            Console.WriteLine("请输入班级");
            Console.ReadLine();

<<<<<<< HEAD
            Console.WriteLine("您喜欢什么运动");
            Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢这个运动");
=======

>>>>>>> 4efc43ed7130438edefa18e4dad30037f21d3820

            //方式1
            Console.WriteLine("**********");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("**********");

            //方式2(不推荐，较复杂，使用WriteLine去换行)
            Console.Write("**********");
            //WriteLine();可不传参
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("*        *");
            Console.WriteLine();
            Console.Write("**********");
        }
    }
}
