namespace lesson9_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");

            #region 作用
            //将玩家输入的内容存储string类型的变量（容器）中
            //string str = Console.ReadLine();
            //Parse转字符串为数值类型时，必须要合法合规
            //int i = int.Parse(str);

            //通过对异常捕获的学习 可以避免当代码报错时，造成程序卡死的情况
            #endregion

            #region 基本语法
            //必备部分
            try 
            {
                //希望进行异常捕获的代码块放到try中，如果try中的代码报错了，不会让程序卡死
            }
            catch
            {
                //如果出错了，会执行catch中的代码
                //catch (Exception e)具体报错跟踪通过e得到具体的报错信息
            }
            //可选部分
            finally
            {
                //最后执行的代码 不管有没有出错 都会执行其中的代码
                //目前 可以不用写
            }
            #endregion

            #region 实践
            try
            {
                string str = Console.ReadLine();
                int i = int.Parse(str);
                Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("请输出合法数字");
            }
            finally
            {
                Console.WriteLine("执行完毕");
            }
            #endregion
        }
    }
}
