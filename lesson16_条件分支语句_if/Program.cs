namespace lesson16_条件分支语句_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件分支语句");

            #region 知识点一 作用
            //作用：让顺序执行的代码，产生分支
            //if语句是第一个可以让我们的程序，产生逻辑变化的语句
            #endregion

            #region 知识点二 if语句
            //作用：满足条件时，多执行一些代码
            //语法：
            //if (bool类型)
            //{
            //    满足条件要执行的代码，写在if代码块中;
            //}

            if (false)
            {
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
            }
            Console.WriteLine("if语句外的代码");
            Console.WriteLine("******************************************");

            int a = 1;
            if (a > 0 && a < 5) 
            {
                Console.WriteLine("a在0和5之间");
            }
            Console.WriteLine("******************************************");

            string name = "味精";
            string passWord = "666";
            if(name =="味精"&& passWord == "666")
            {
                Console.WriteLine("登录成功");
            }
            //嵌套使用
            if (name == "味精")
            {
                Console.WriteLine("用户名验证成功");
                if (passWord == "666") 
                {
                    Console.WriteLine("密码验证成功");
                    //可以无限嵌套
                }
            }
            Console.WriteLine("******************************************");

            #endregion

            #region 知识点三 if...else语句
            //作用：产生两条分支，满足条件做什么，不满足条件做什么
            //语法：
            //if (bool类型值)
            //{
            //    满足条件执行的代码;
            //}
            //else
            //{
            //    不满足条件执行的代码;
            //}
            //注意：
            //1.if...else语句，语法部分，不需要写分号
            //2.if...else语句，可以嵌套

            if( false )
            {
                Console.WriteLine("满足if条件，做什么");
            }
            else
            {
                Console.WriteLine("不满足条件，做什么");
            }
            Console.WriteLine("************************************");

            //其他使用和if使用时一样
            //嵌套使用也是和if语句一样
            #endregion

            #region 知识点四 if...else if...else语句
            //作用：产生n条分支，多条道路选择，最先满足其中的一个条件，就做什么
            //语法：
            //if (bool类型值)
            //{
            //    满足条件执行的代码;
            //}
            //else if (bool类型值)
            //{
            //    满足条件执行的代码;
            //}
            //...中间有n个 else if语句代码块
            //else
            //{
            //    不满足条件执行的代码;
            //}

            int a3 = 10;
            if( a3 >= 10 )
            {
                Console.WriteLine("a大于等于10");
            }
            else if( a3 > 5 && a3 < 10 )
            {
                Console.WriteLine("a在5和10之间");
            }
            else if( a3 >= 0 && a3 <= 5 )
            {
                Console.WriteLine("a在0和5之间");
            }
            else
            {
                Console.WriteLine("a小于0");
            }
            #endregion
        }
    }
}
