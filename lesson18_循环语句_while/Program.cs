namespace lesson18_循环语句_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while语句");

            #region 知识点一 作用
            //让顺序执行的代码，可以不停的循环执行某一条代码块的内容
            //条件分支语句是让代码产生分支
            //循环语句是让代码可以被重复执行
            #endregion

            #region 知识点二 语法相关
            ////bool类型的变量 条件运算符 逻辑运算符
            //while(bool类型的值)
            //{
            //    //当满足条件时，就会执行while语句块中的内容
            //    //......
            //    //......
            //    //......
            //    //......
            //    //当代码逻辑执行完，会回到while循环开头
            //    //再次进行条件判断
            //}
            //Console.WriteLine("主代码逻辑");

            //死循环
            //不停的执行循环中的逻辑，‘直到死为止’
            while (true)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("请玩家输入用户名密码");
                Console.ReadLine();
            }

            //非死循环
            //计算一个为0的整形变量，让他只能累加1，不停的加到10为止
            int i = 0;
            while (i < 10)
            {
                ++i;
            }
            Console.WriteLine(i);
            #endregion

            #region 知识点三 嵌套使用
            //不仅可以嵌套if switch还可以嵌套while
            int a = 0;
            int b = 0;
            while (a < 10)
            {
                ++a;
                while (b < 10)
                {
                    ++b;
                }
            }

            int a2 = 0;
            while (a2 < 10)
            {
                ++a2;
                //每次从外层循环进来时
                //b2和上一次的b2没有关系
                int b2 = 0;
                while (b2 < 10)
                {
                    ++b2;
                }
            }

            #endregion

            #region 知识点四 流程控制关键词
            //作用：控制循环逻辑的关键词
            //break：跳出循环
            while (true)
            {
                Console.WriteLine("break之前的代码");
                break;
                Console.WriteLine("break之前的代码");
            }
            Console.WriteLine("循环外的代码");

            int i2 = 0;
            while (true)
            {
                ++i2;
                Console.WriteLine(i2);
                if (i2 == 10)
                {
                    break;
                }
            }
            Console.WriteLine(i2);

            //continue：回到循环开始，继续开始
            while (true)
            {
                Console.WriteLine("continue前的代码");
                continue;
                Console.WriteLine("continue后的代码");
            }

            //打印1到20之间的奇数
            int i3 = 0;
            while ( i3 < 20 )
            {
                ++i3;
                if( i3 % 2 == 0 )
                {
                    continue;
                }
                Console.WriteLine(i3);
            }
            //注意：
            //break和continue主要是和循环配合使用的，和if语句无关
            //break在switch中的作用和while循环中的作用有异曲同工之妙

            while(true)
            {
                int a = 1;
                switch (a)
                {
                    default:
                        break;
                }
                Console.WriteLine("11111111");
            }
            #endregion
        }
    }
}
