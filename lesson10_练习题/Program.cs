namespace lesson10_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算数运算符练习题");

            #region 定义一个变量存储你的年龄，十年后你的年龄是多少？请输出到控制台
            int myAge = 27;
            myAge += 10;
            Console.WriteLine("十年后我的年龄是：" + myAge);
            #endregion

            #region 计算一个半径为5的圆的面积和周长 面积公式：πr² 周长公式：2πr
            int r = 5;
            float pi = 3.14f;
            float sq = pi * (5 * 5);    //面积
            float circ = 2 * pi * r;    //周长
            Console.WriteLine("半径为5的圆，面积为：" + sq + "，周长为：" + circ);
            #endregion

            #region 计算任意三门成绩的总分、平均分打印到控制台。 三门成绩均为整数类型（C# Unity Math）
            int yuWen = 90, shuXue = 80, yingYu = 89;
            int total = yuWen + shuXue + yingYu;
            int avg = total / 3;
            Console.WriteLine("三门成绩的总分为：" + total + "，平均分为：" + avg);
            #endregion

            #region 商店T恤的价格为285元/件，裤子的价格为720元/条，小李在该店卖了2件T恤和3条裤子，请计算小李该付多少钱？打3.8折后呢？
            int tee = 285, pants = 720;
            int money = tee * 2 + pants * 3;
            Console.WriteLine("小李在该店买了2件T恤和3条裤子，总计金额：" + money + "元");
            float saleMoney = money * 0.38f;
            Console.WriteLine("打折3.8折后，需要付款：" + saleMoney);
            #endregion

            #region int a = 10, b = 20; int number1 = ++a + b; a = 10; b = 20; int number2 = a + b++; a = 10; b = 20; int number3 = a++ + ++b + a++; 请说明 number1和number2和number3的结果
            int a = 10, b = 20, number1 = ++a + b;
            a = 10; b = 20;
            int number2 = a + b++;
            a = 10; b = 20;
            int number3 = a++ + ++b + a++;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            #endregion

            #region 有两个数a=99，b=87，请写出两种方法交换他们的值，让a = 87，b=99
            int a2 = 99, b2 = 87;
            //方法1
            int c = a2;  //c=99
            a2 = b2;  //a=87
            b2 = c;  //b=99
            Console.WriteLine("a2=" + a2);
            Console.WriteLine("b2=" + b2);

            //方法2 算数运算符 加减法
            a2 = 99;
            b2 = 87;
            a2 = a2 + b2;   //a2 = 99 + 87
            b2 = a2 - b2;   //b2 = 99 + 87 - 87 = 99
            a2 = a2 - b2;   //a2 = 99 + 87 - 99 = 87
            Console.WriteLine("a2(方法2)=" + a2);
            Console.WriteLine("b2(方法2)=" + b2);
            #endregion

            #region 请把987652秒通过代码转为n天n小时n分钟n秒显示在控制台中
            int sec = 987652;
            int day = 987652 / (24 * 60 * 60);  //天
            sec = 987652 - (day * 24 * 60 * 60);
            int hour = sec / 60 / 60;   //小时
            sec = sec - hour * 60 * 60;
            int min = sec / 60; //分钟
            sec = sec - min * 60;   //秒
            Console.WriteLine("987652秒等于：" + day + "天" + hour + "小时" + min + "分钟" + sec + "秒");
            #endregion
        }
    }
}
