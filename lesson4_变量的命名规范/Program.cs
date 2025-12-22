namespace lesson4_变量的命名规范
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量的命名规范");
            #region 知识点一：必须遵守的规则
            //不能重名
            //不能以数字开头
            //不能使用程序关键字命名
            //不能有特殊符号（下划线除外）
            #endregion

            #region 知识点二：常用命名规则
            //驼峰命名法——首字母小写，之后单词首字母大写（变量）
            string myName = "味精";
            string yourName = "你的名字";
            string yourMoterName = "你猜";

            //帕斯卡命名法——所有单词首字母都大写（函数、类）
            string MyName = "CAKO";

            //潜在知识点
            //C#中对大小写是敏感的，是区分的
            #endregion
        }
    }
}
