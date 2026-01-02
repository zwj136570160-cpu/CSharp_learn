namespace lesson19_循环语句_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do...while循环");
            Console.WriteLine("-------------------------------------");

            #region 知识点一 基本语法
            //while循环 是先判断条件再执行
            //do while循环 是先斩后奏 先至少执行依次循环语句块中的循环再判断是否继续

            //do
            //{

            //} while (bool类型的值);
            //注意：do while语句，存在一个重要的分号
            #endregion

            #region 知识点二 实际使用
            //do while在实际使用中较少
            do
            {
                Console.WriteLine("do while 循环语句块");
            }
            while (false);
            Console.WriteLine("-------------------------------------");

            int a = 1;
            do
            {
                Console.WriteLine(a);
                ++a;
            } while (a > 2);
            Console.WriteLine("-------------------------------------");

            #endregion

            #region 知识点三 嵌套使用
            //do
            //{
                //if(true)
                //{

                //}
                //while(true)
                //{

                //}
                //int i = 1;
                //switch(i)
                //{
                //    default:
                //        break;
                //}
                //break;
                //continue;
            //} while (true);

            //continue是回到while的判断中
            do
            {
                Console.WriteLine("111");
                continue;
            } while (false);

            #endregion
        }
    }
}
