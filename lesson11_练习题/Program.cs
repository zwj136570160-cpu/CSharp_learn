using System.Net;

namespace lesson11_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接练习题");

            #region 定义一个变量存储客户的姓名，然后再屏幕上显示：“你好，XXX” XXX代表客户的姓名
            string name = "味精";
            Console.WriteLine("你好，" + name);
            Console.WriteLine("**************************************");
            #endregion

            #region 定义两个变量，一个存储客户的姓名，另一个存储年龄，然后再屏幕上显示：“xxx + yyy岁了”。xxx代表客户的姓名，yyy代表年龄 举例（唐老狮18岁了）
            string name1 = "味精";
            int age = 27;
            Console.WriteLine(name1 + age + "岁了");
            Console.WriteLine("**************************************");
            #endregion

            #region 当我们去面试时，前台会要求我们填一张表格，有姓名，年龄，邮箱，家庭住址，期望工资，请把这些信息在控制台输出。
            string name3 = "味精";
            int age1 = 27;
            string email = "136570160@qq.com";
            string homeAddress = "银河系宇宙空间";
            int desiredSalary = 12000;
            Console.WriteLine("姓名：" + name3 + "，年龄：" + age1 + "，邮箱：" + email + "，家庭住址：" + homeAddress + "，期望工资：" + desiredSalary);
            Console.WriteLine("**************************************");
            #endregion

            #region 请用户输入用户名、年龄、班级，最后一起用占位符形式打印出来
            Console.WriteLine("请输入用户名：");
            string userID = Console.ReadLine();
            Console.WriteLine("请输入年龄：");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入班级：");
            string form = Console.ReadLine();
            Console.WriteLine("用户名：{0}，年龄：{1}，班级：{2}", userID, age2, form);
            #endregion
        }
    }
}
