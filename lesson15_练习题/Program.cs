namespace lesson15_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三目运算符练习题");

            #region 比较两个数的大小，求出最大的。
            int num1 = 1, num2 = 2;
            string result = num1 > num2 ? "num1最大" : "num2最大";
            Console.WriteLine(result);
            Console.WriteLine("***************************");
            #endregion

            #region 提示用户输入一个姓名，然后再控制台输出姓名，只要输入的不是帅哥，就显示美女
            Console.WriteLine("请输入您的姓名");
            string input = Console.ReadLine();
            string result2 = input == "帅哥" ? "帅哥" : "美女！";
            Console.WriteLine(result2);
            Console.WriteLine("***************************");
            #endregion

            #region 依次输入学生的姓名，C#语言的成绩，Unity的成绩，两门成绩都大于等于90分，才能毕业，请输出最后的结果。
            Console.WriteLine("请输入你的姓名");
            Console.ReadLine();
            Console.WriteLine("请输入你的C#语言的成绩");
            int scoreCSharp = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的Unity的成绩");
            int scoreUnity = int.Parse(Console.ReadLine());
            string result3 = scoreCSharp >= 90 && scoreUnity >= 90 ? "你毕业啦！！" : "很遗憾，你未毕业，继续加油！";
            Console.WriteLine(result3);
            Console.WriteLine("***************************");

            #endregion

            #region 要求用户输入一个年份，然后判断是不是闰年
            //闰年判断条件： 年份能被400整除（2000） 或者 年份能被4整除，但是不能被100整除（2008）
            Console.WriteLine("请输入一个年份");
            int year = int.Parse(Console.ReadLine());
            string result4 = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "你输入的年份是闰年" : "你输入的年份不是闰年";
            Console.WriteLine(result4);
            #endregion
        }
    }
}
