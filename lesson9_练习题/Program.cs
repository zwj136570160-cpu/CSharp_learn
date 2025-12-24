namespace lesson9_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获练习题");

            #region 请用户输入一个数字 如果输入有误，则提示用户输入错误
            try
            {
                string str = Console.ReadLine();
                int num = int.Parse(str);
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
            #endregion

            #region 提示用户输入姓名、语文、数学、英语成绩 如果输入的成绩有误，则提示用户输入错误 否则将输入的字符串转为整形变量存储
            try
            {
                Console.WriteLine("请输入姓名");
                Console.ReadLine();
                Console.WriteLine("请输入语文成绩");
                string yuWen_str = Console.ReadLine();
                int yuWen = int.Parse(yuWen_str);
                Console.WriteLine("请输入数学成绩");
                string shuXue_str = Console.ReadLine();
                int shuXue = int.Parse(shuXue_str);
                Console.WriteLine("请输入英语成绩");
                string yinYu_str = Console.ReadLine();
                int yinYu = int.Parse(yinYu_str);
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
            #endregion
        }
    }
}
