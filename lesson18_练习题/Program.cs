using System;

namespace lesson18_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while循环练习题");

            #region 练习题1 在控制台输出1到100
            //int i = 0;
            //while (i < 100)
            //{
            //    ++i;
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习题2 在控制台输出1到100之间所有整数的和
            //int num = 0;
            //int result = 0;
            //while (num <= 100)
            //{
            //    result += num;
            //    ++num;
            //}
            //Console.WriteLine(result);
            #endregion

            #region 练习题3 用while和continue实现计算1到100（包含）之间的除了能被7整除之外所有整数的和
            //int num2 = 0;
            //int result2 = 0;
            //while(num2 <= 100)
            //{
            //    if(num2 % 7 != 0)
            //    {
            //        result2 += num2;
            //        ++num2;
            //    }
            //    else
            //    {
            //        ++num2;
            //        continue;
            //    }
            //}
            //Console.WriteLine(result2);
            #endregion

            #region 练习题4 提示用户输入一个数，判断该数是否是素数并打印。 （素数/质数：只能被1和这个数字本身整除的数字，1不是质数，最小的质数是2）
            //try
            //{
            //    Console.WriteLine("请输入一个数字");
            //    int num = int.Parse(Console.ReadLine());
            //    int index = 2;
            //    while(index < num)
            //    {
            //        if(num % index == 0)
            //        {
            //            break;
            //        }
            //        ++index;
            //    }
            //    if (index != num)
            //    {
            //        Console.WriteLine("这不是一个质数");
            //    }
            //    else
            //    {
            //        Console.WriteLine("是质数");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请正确输入");
            //}
            #endregion

            #region 练习题5 要求输入用户名和密码（admin/8888），用户名或者密码错误，则提示“用户名或密码错误”，直到输入正确为止
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string userId = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string passWord = Console.ReadLine();
            //    if(userId == "admin" && passWord == "8888")
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或者密码错误");
            //    }
            //}
            #endregion

            #region 练习题6 输入班级人数，然后依次输入学员成绩（需提示当前是第几个学员）， 计算班级学员的平均成绩和总成绩。
            //try
            //{
            //    Console.WriteLine("请输入班级人数");
            //    int studentEenrollment = int.Parse(Console.ReadLine()); //学生人数
            //    int num3 = 0;
            //    float totalScore = 0;
            //    while (++num3 <= studentEenrollment)
            //    {
            //        Console.WriteLine("请输入第{0}个学生的成绩", num3);
            //        float score = float.Parse(Console.ReadLine());
            //        //总成绩
            //        totalScore += score;
            //    }
            //    Console.WriteLine($"学生的总成绩为：{totalScore}分");
            //    //平均分
            //    float averageScore = totalScore / studentEenrollment;
            //    Console.WriteLine($"学生的平均分为：{averageScore}分");
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题7 定义一个整形变量sum，然后分别把1~100之间的数字依次累加到sum中，当sum的值大于500的时候，中断操作，并在控制台输出累加到第几个数字就可以使sum大于500
            //int sum = 0;
            //int num4 = 0;
            //while (num4 < 100)
            //{
            //    ++num4;
            //    sum += num4;
            //    if (sum > 500)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"累加到第{num4}个数字就可以使sum大于500");
            #endregion

            #region 练习题8 假设看唐老狮视频的同学有100人，每个月增长20%，请问按此速度增长，经历多少个月看唐老狮视频的同学能达到1000人？
            //int month = 0;
            //int num = 100;
            //while (num <= 1000)
            //{
            //    month += 1;
            //    num = (int)(num * 0.2f) + num;
            //}
            //Console.WriteLine($"经历{month}个月后看唐老狮视频的同学能达到1000人");
            #endregion

            #region 练习题9 求数列 1,1,2,3,5,8,13....的第20位数字是多少？
            //斐波那契数列
            //1 1+1=2 3
            //2 1+2=3 4
            //3 2+3=5 5
            //4 3+5=8 6
            //5 5+8=13 7
            //6 8+13=21 8
            //n 上一次的加数 + 上一次的结果

            //int index = 2;
            //int num1 = 1;
            //int num2 = 1;
            //int num3 = 0;
            //while (index < 20)
            //{
            //    ++index;
            //    if( index == 1 )
            //    {
            //        num3 = num1;
            //    }
            //    else if( index == 2 )
            //    {
            //        num3 = num2;
            //    }
            //    num3 = num1 + num2;
            //    num1 = num2;
            //    num2 = num3;
            //}
            //Console.WriteLine($"第20位数字是{num3}");
            #endregion

            #region 练习题10 找出100内所有素数并打印
            int num = 2;
            while (num < 100)
            {
                ++num;
                int index = 2;
                while(index < num)
                {
                    if(num % index == 0)
                    {
                        break;
                    }
                    ++index;
                }
                if(index == num)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion
        }
    }
}
