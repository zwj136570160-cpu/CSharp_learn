namespace lesson19_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do while语句练习题");

            #region 练习题1
            //要求用户输入用户名和密码，只要不是admin和8888就一直提示用户名或密码错误，请重新输入

            //方法1
            //do
            //{
            //    Console.WriteLine("请输入用户名");
            //    string userID = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string passWord = Console.ReadLine();
            //    if (userID == "admin" && passWord == "8888")
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入");
            //    }
            //}
            //while (true);

            //方法2
            string userID = "";
            string passWord = "";
            bool isShow = false;
            do
            {
                //这句代码第一次不能执行 所以设置isShow为false
                if(isShow)
                {
                    Console.WriteLine("用户名或密码错误，请重新输入");
                }
                Console.WriteLine("请输入用户名");
                userID = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
                isShow = true;
            }
            while (userID != "admin" || passWord != "8888");
            #endregion

            #region 练习题2
            //不断提示请输入你的姓名，直到输入q结束

            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入你的姓名");
            //    name = Console.ReadLine();
            //}
            //while (name != "q");
            #endregion
        }
    }
}
