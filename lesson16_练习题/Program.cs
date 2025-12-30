using System;

namespace lesson16_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句练习题");
            #region 请用户输入今日看唐老狮视频花了多少分钟，如果大于60分钟，那么在控制台输出“今天看视频花了XX分钟，看来你离成功又进了一步!”
            try
            {
                Console.WriteLine("今日观看唐老狮视频花了多少分钟？");
                int time = int.Parse(Console.ReadLine());
                if (time > 60)
                {
                    Console.WriteLine("今天看视频花了{0}分钟，看来你离成功又进了一步!", time);
                }
                else
                {
                    Console.WriteLine("今日观看时间不足60分钟");
                }
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            Console.WriteLine("**************************************");
            #endregion

            #region 请输入你的 语文，数学，英语成绩，满足以下任意条件，则输出:“非常棒，继续加油”
            //语文成绩大于70 并且 数学成绩大于80 并且英语成绩大于90
            //语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            //语文成绩大于90 并且 其它两门中有一门成绩大于70

            try
            {
                //输入成绩
                Console.WriteLine("请输入你的语文成绩");
                int chineseGrade = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入你的数学成绩");
                int mathGrade = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入你的数学成绩");
                int englishGrade = int.Parse(Console.ReadLine());
                //设置判断条件
                if (chineseGrade > 70 && mathGrade > 80 && englishGrade > 90)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else if (chineseGrade == 100 || mathGrade == 100 || englishGrade == 100)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else if (chineseGrade > 90 && (mathGrade > 70 || englishGrade > 70))
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else
                {
                    Console.WriteLine("继续努力哦！！！");
                }
            }
            catch
            {
                Console.WriteLine("请输入具体分数");
            }
            #endregion

            #region 定义一个变量，存储小赵的考试成绩，如果小赵的考试成绩大于（含）90分，那么爸爸奖励100元钱，否则一个月不能玩游戏
            try
            {
                Console.WriteLine("输入小赵的考试成绩");
                int xiaoZhaoGrade = int.Parse(Console.ReadLine());
                if (xiaoZhaoGrade >= 90)
                {
                    Console.WriteLine("奖励100元");
                }
                else
                {
                    Console.WriteLine("考试不合格，一个月不许玩游戏");
                }
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion

            #region 要求用户输入两个数a、b，如果两个数可以整除或者这两个数加起来大于100，则输出a的值，否则输出b的值
            try
            {
                Console.WriteLine("请输入数字a");
                float numA = float.Parse(Console.ReadLine());
                Console.WriteLine("请输入数字b");
                float numB = float.Parse(Console.ReadLine());
                if (numA % numB == 0 || numB % numA == 0 || numA + numB > 100)
                {
                    Console.WriteLine("输出的值为{0}", numA);
                }
                else
                {
                    Console.WriteLine("输出的值为{0}", numB);
                }
            }
            catch
            {
                Console.WriteLine("请输入正确数字");
            }
            #endregion

            #region 输入一个整数，如果这个数是偶数，则打印“Your input is even”，否则打印“Your input is odd”
            try
            {
                Console.WriteLine("请输入一个整数");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 % 2 == 0)
                {
                    Console.WriteLine("Your input is even");
                }
                else
                {
                    Console.WriteLine("Your input is odd");
                }
            }
            catch
            {
                Console.WriteLine("请输入正确数字");
            }
            Console.WriteLine("******************************");
            #endregion

            #region 有3个整形变量，分别存储不同的值，编写代码输出其中最大的整数  
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            if (num3 > num4 && num3 > num5)
            {
                Console.WriteLine(num3);
            }
            else if (num4 > num3 && num4 > num5)
            {
                Console.WriteLine(num4);
            }
            else if (num5 > num3 && num5 > num4)
            {
                Console.WriteLine(num5);
            }
            #endregion

            #region 写一个程序接受用户输入的字符，如果输入的字符是0~9数字中的一个，则显示“您输入了一个数字”，否则显示这不是一个数字
            //方法1 使用try来检测输入的是否为数字
            try
            {
                Console.WriteLine("请输入一个字符");
                //keychar可以得到玩家输入的一个字符
                char c = Console.ReadKey().KeyChar;
                int num = int.Parse(c.ToString());
                if (num >= 0 && num <= 9)
                {
                    Console.WriteLine("您输入了一个数字");
                }
            }
            //因为tostring转int 要求是必须要输入一个Int才能转，如输入别的类型会导致tostring转int报错 从而进入catch
            catch
            {
                Console.WriteLine("这不是一个数字");
            }
            //方法2
            Console.WriteLine("请输入一个字符");
            int askii = Console.ReadKey().KeyChar;
            //char类型可以隐式转换为数值类型
            int zeroAskill = '0';
            int nineAskill = '9';
            if (askii >= zeroAskill && askii <= nineAskill)
            {
                Console.WriteLine("您输入了一个数字");
            }
            else
            {
                Console.WriteLine("这不是一个数字");
            }
            #endregion

            #region 提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”，并且密码是"8888"，则提示正确，否则，如果用户名不是admin还提示用户用户名不存在，如果用户名是admin则提示密码错误
            Console.WriteLine("请输入用户名");
            string userId = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            if (userId == "admin" && passWord == "8888")
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                if (userId != "admin")
                {
                    Console.WriteLine("用户名错误");
                }
                else
                {
                    Console.WriteLine("密码错误");
                }
            }
            #endregion

            #region 提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，否则提示“退出”。
            try
            {
                Console.WriteLine("请输入年龄");
                int age = int.Parse(Console.ReadLine());
                if (age > 18)
                {
                    Console.WriteLine("请查看");
                }
                else if (age < 13)
                {
                    Console.WriteLine("年龄太小，不允许查看");
                }
                else if (age >= 13 && age < 18)
                {
                    Console.WriteLine("请确认是否继续查看（yes、no）");
                    if (Console.ReadLine() == "yes")
                    {
                        Console.WriteLine("请继续查看");
                    }
                    else
                    {
                        Console.WriteLine("退出");
                    }
                }
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion
        }



    }
}

