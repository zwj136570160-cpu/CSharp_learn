namespace lesson17_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句练习题");

            #region 假设唐老狮的工资是4000 请用户输入王老师的评级，并算出王老师的工资是多少？
            //唐老狮的工资是由基本工资 + 绩效决定的
            //绩效说明：
            //学生评价 很兴奋，则评定为A级，绩效工资500
            //学生评价 很充实，则评定为B级，不加绩效工资
            //学生评价 还好吧，则评定为C级，绩效工资扣300
            //学生评价 难理解，则评定为D级，绩效工资扣500
            //学生评价 枯燥泛味，则评定为E级，绩效工资扣800

            try
            {
                int salaryTang = 4000;
                Console.WriteLine("请对唐老师进行评价（A、B、C、D、E）");
                char grade = Convert.ToChar(Console.ReadLine());
                switch (grade)
                {
                    case 'A':
                        salaryTang += 500;
                        Console.WriteLine("评级A级，绩效加500，目前工资为：{0}元", salaryTang);
                        break;
                    case 'B':
                        Console.WriteLine("评级B级，工资无影响，目前工资为：{0}元", salaryTang);
                        break;
                    case 'C':
                        salaryTang -= 300;
                        Console.WriteLine("评级C级，绩效扣300，目前工资为：{0}元", salaryTang);
                        break;
                    case 'D':
                        salaryTang -= 500;
                        Console.WriteLine("评级D级，绩效扣500，目前工资为：{0}元", salaryTang);
                        break;
                    case 'E':
                        salaryTang -= 800;
                        Console.WriteLine("评级E级，绩效扣800，目前工资为{0}元", salaryTang);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("评价格式有误");
            }

            #endregion

            #region 请用户输入选择的型号，如果钱够，则购买成功，并算出小王最后还剩多少钱？ 如果钱不够，则提示用户“钱不够，请换其他型号”
            //小唐带了10元钱去星巴克买咖啡，三种型号选择：
            //1 = (中杯，¥5) 
            //2 = (大杯，¥7) 
            //3 = (超大杯，¥11)

            int xiaoTangMoney = 10;
            Console.WriteLine("请输入需要选择的型号");
            int pick = int.Parse(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    if (xiaoTangMoney >= 5)
                    {
                        xiaoTangMoney -= 5;
                        Console.WriteLine("购买中杯成功，扣款5元，还剩{0}元", xiaoTangMoney);
                    }
                    else
                    {
                        Console.WriteLine("钱不够，请换其他型号");
                    }
                    break;
                case 2:
                    if (xiaoTangMoney >= 7)
                    {
                        xiaoTangMoney -= 7;
                        Console.WriteLine("购买大杯成功，扣款7元，还剩{0}元", xiaoTangMoney);
                    }
                    else
                    {
                        Console.WriteLine("钱不够，请换其他型号");
                    }
                    break;
                case 3:
                    if (xiaoTangMoney >= 11)
                    {
                        xiaoTangMoney -= 11;
                        Console.WriteLine("购买超大杯成功，扣款11元，还剩{0}元", xiaoTangMoney);
                    }
                    else
                    {
                        Console.WriteLine("钱不够，请换其他型号");
                    }
                    break;
                default:
                    Console.WriteLine("请输入正确内容");
                    break;
            }
            #endregion

            #region 输入学生的考试成绩，如果
            //成绩 >= 90：A
            //90 > 成绩 >= 80:B
            //80 > 成绩 >= 70:C
            //70 > 成绩 >= 60:D
            //成绩 < 60:E
            //（使用switch语法完成）最后输出学生的考试等级

            try
            {
                Console.WriteLine("请输入考试成绩");
                //取数字的十位数
                int grade = int.Parse(Console.ReadLine()) / 10;
                switch (grade)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("学生的考试等级为A");
                        break;
                    case 8:
                        Console.WriteLine("学生的考试等级为B");
                        break;
                    case 7:
                        Console.WriteLine("学生的考试等级为C");
                        break;
                    case 6:
                        Console.WriteLine("学生的考试等级为D");
                        break;
                    default:
                        Console.WriteLine("学生的考试等级为E");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion

            #region 在控制台输入一个（0~9）的数并显示为大写。如输入2，则显示二
            Console.WriteLine("输入一个（0~9）的数");
            try
            {
                int num = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("格式错误，请输入整数");
            }

            #endregion
        }
    }
}
