namespace lesson13_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            //对bool类型进行逻辑运算

            #region 知识点一 逻辑与
            //符号：&&
            //规则：对两个bool值进行逻辑运算，有假则假，同真为真

            bool result = true && false;
            Console.WriteLine(result);
            result = true && true;
            Console.WriteLine(result);
            result = false && true;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            //bool相关的类型：bool变量、条件运算符
            //逻辑运算符优先级低于条件运算符和算数运算
            result = 3 > 1 && 1 < 2;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");
            int i = 3;
            result = i > 1 && i < 5;    //1<i<5 true&&true
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            //多个逻辑与组合运用
            //在没有括号的情况下，从左到右依次看即可
            //有括号，先看括号内
            int i2 = 5;
            //true && false && true && true
            result = i2 > 1 && i2 < 5 && i > 1 && i < 5;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");
            #endregion

            #region 知识点二 逻辑或
            //符号：||
            //规则：对两个bool值进行逻辑运算，有真则真，同假为假

            result = true || false;
            Console.WriteLine(result);
            result = true || true;
            Console.WriteLine(result);
            result = false || true;
            Console.WriteLine(result);
            result = false || false;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            result = 3 > 10 || 3 < 5;
            Console.WriteLine(result);

            int a = 5;
            int b = 11;
            result = a > 1 || b < 20 || a > 5;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            //？&&？
            //？||？
            //？可以是写死的bool变量或者bool值
            //还可以是条件运算符相关
            #endregion

            #region 知识点三 逻辑非
            //符号：!
            //规则：对bool值进行取反，真变假，假变真

            result = !true;
            Console.WriteLine(result);
            result = !false;
            Console.WriteLine(result);
            result = !!true;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            //逻辑非的优先级较高
            result = !(3 > 2);
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            a = 5;
            result = !(a > 5);
            Console.WriteLine(result);
            Console.WriteLine("**********************************");

            #endregion

            #region 知识点四 混合使用优先级问题
            //规则：!(逻辑非)优先级最高，&&（逻辑与）高于 ||（逻辑或）
            //逻辑运算符优先级低于算数运算符和条件运算符（逻辑非除外）

            bool gameOver = false;
            int hp = 100;
            bool isDead = false;
            bool isMustOver = true;
            //false||false&&true||true
            //false||false||true
            result = gameOver || hp < 0 && !isDead || isMustOver;
            Console.WriteLine(result);
            Console.WriteLine("**********************************");
            #endregion

            #region 知识点五 逻辑运算符的短路规则
            int i3 = 1;
            //||有真则真
            //只要逻辑与或逻辑或，左边满足了条件
            //i3 >0 true
            //只要满足条件，右边的内容对于我们来说，已经不重要
            result = i3 > 0 || ++i3 >= 1;
            Console.WriteLine(i3);
            Console.WriteLine(result);
            Console.WriteLine("**********************************");
            //false && i3++ > 1; 抛弃右边部分不去计算
            result = i3 < 0 && i3++ > 1;
            Console.WriteLine(i3);
            Console.WriteLine(result);
            #endregion

        }
    }
}
