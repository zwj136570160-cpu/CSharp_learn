namespace lesson20_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环练习题");

            #region 练习题1
            //输出1到100之间的整数（包含本身）
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习题2
            //求1~100之间所有偶数的和
            //int result = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if( i % 2 == 0 )
            //    {
            //        result += i;
            //    }
            //}
            //Console.WriteLine($"1~100之间所有偶数的和是：{result}");
            #endregion

            #region 练习题3
            //找出100~999之间的水仙花数
            //例如：153 = 1*1*1 + 5*5*5 + 3*3*3 这个数就是水仙花数

            //for (int i = 100; i <= 999; i++)
            //{
            //    //取i的每个位的数值
            //    int baiWei = i / 100;
            //    int shiWei = (i / 10) % 10;
            //    int geWei = i % 10;
            //    int result = baiWei * baiWei * baiWei + shiWei * shiWei * shiWei + geWei * geWei * geWei;
            //    if(result == i)
            //    {
            //        Console.WriteLine($"{i}是一个水仙花数");
            //    }
            //}
            #endregion

            #region 练习题4
            //在控制台上输出九九乘法表

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{j}*{i}={i * j}\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题5
            //在控制台上输出如下10 * 10的空心星型方阵
            //**********
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //**********

            #region 方法1
            //方法1
            //for (int i = 0; i <= 10; i++)
            //{
            //    if( i == 0 )
            //    {
            //        Console.WriteLine("**********");
            //    }
            //    else if( i > 0 && i < 9 )
            //    {
            //        Console.WriteLine("*        *");
            //    }
            //    else if ( i == 10 )
            //    {
            //        Console.WriteLine("**********");
            //    }
            //}
            #endregion

            #region 方法2
            //方法2
            //for (int j = 1; j <= 10; j++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        //列 如果是第一行和第10行 那么内层列循环都打印星号
            //        if (j == 1 || j == 10)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if (i == 1 || i == 10)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion

            #region 练习题6
            //在控制台上输出如下10 * 10的三角形方阵
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题7
            //在控制台上输出如下10行的三角形方阵
            //          *                  1  1 ----> 2i-1
            //         ***                 2  3
            //        *****                3  5
            //       *******               4  7
            //      *********              5  9
            //     ***********             6  11
            //   ***************
            //  *****************
            // *******************
            //*********************

            //行
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10-i; k++)
                {
                    Console.Write(" ");
                }
                //列
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
