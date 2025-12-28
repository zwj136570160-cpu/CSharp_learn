namespace lesson10_算数运算符知识点
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算数运算符");

            #region 赋值符号
            //=
            //关键知识点:先看右侧，再看左侧，把右侧的值赋值给左侧的变量

            string myName = "味精";
            int myAge = 19;
            float myHeight = 177.5f;
            #endregion

            #region 算数运算符
            #region 加+
            //用自己计算 先算右侧结果，再赋值给左侧变量
            int i = 1;
            i = i + 2;
            //i=3
            Console.WriteLine(i);

            //连续运算，先算右侧结果，再赋值给左侧变量
            i = i + 3 + 89 + i + i;
            //i=99
            Console.WriteLine(i);
            i = 1 + 2 + 1;
            Console.WriteLine(i);
            //i=4

            //初始化时就运算，先算右侧结果，再赋值给左侧变量
            int i2 = 1 + 2 + 4;
            Console.WriteLine(i2);
            //i2=7

            #endregion

            #region 减-
            //和‘+’同理
            #endregion

            #region 乘*
            //和‘+’、‘-’同理，只是改变符号和数学计算，写法一样
            #endregion

            #region 除/
            //和‘+’、‘-’、‘*’同理，只是改变符号和数学计算，写法一样
            //默认的整数是int，如果用来做除法运算要注意会丢失小数点后的小数，如果想用浮点数来存储，一定是在运算时要有浮点数的特征

            float f = 1.1f / 2f;
            Console.WriteLine(f);
            #endregion

            #region 取余%
            //用自己计算，先算右侧结果，再赋值给左侧变量
            int y = 4;
            // 4 / 2得到余数 0
            y = y % 2;

            //连续运算，先算右侧结果，再赋值给左侧变量
            y = 4 % 3 % 2;
            Console.WriteLine(y);
            //得到余数1
            #endregion
            #endregion

            #region 算数运算符的优先级
            //优先级是指，在混合运算时的运算顺序
            //乘除取余 > 加减，先算乘除取余，后算加减
            int a = 1 + 2 * 3 / 2 + 1;
            //a=1+3+1=5
            a = 1 + 4 % 2 * 3 / 2 + 1;
            //a=1+0+1=2

            //括号可以改变优先级，有限计算括号内内容
            a = 1 + 4 % (2 * 3 / 2) + 1;
            //a=1+1+1=3

            //多组括号，先算最里层括号，依次往外算
            a = 1 + 4 % (2 * (3 / 2)) + 1;
            //a = 1 + 4 % (2 * 1) + 1 = 1 + 0 + 1 = 2, a=2
            #endregion

            #region 算数运算符的符合运算符
            //固定写法：运算符=
            //+=、-=、*=、/=、%=
            //符合运算符，是用于自己=自己进行运算
            int i3 = 1;
            i3 = i3 + 2;
            //i3 = 3
            i3 = 1;
            i3 += 2;    //等同于i3 = i3 + 2;

            i3 = 2; 
            i3 += 2;    //4
            i3 -= 2;    //2
            i3 *= 2;    //4
            i3 /= 2;    //2
            i3 %= 2;    //0

            int i4 = 10;
            i4 += 20 * 2 / 10;
            //i4 += 4
            //i4 = 14

            //注意：符合运算符，只能进行一种运算，不能混合运算
            //i4 */-= 2;(此写法为错误 不能这样写)
            #endregion

            #region 算数运算符的自缩减
            int a2 = 1;
            a2 = a2 + 1;

            a2 = 1;
            a2 += 1;

            //自增运算符 （++）
            a2 = 1;
            a2++;   //先用再加
            Console.WriteLine(a2);
            ++a2;   //先加再用
            Console.WriteLine(a2);

            a2 = 1;
            Console.WriteLine(a2++);    //1
            //a2 = 2(因为是a2++，所以是先用再加，输出为1之后，再用1+a2=1+1=2)
            Console.WriteLine(++a2);    //3(因为是++a2，所以是先加在用，在a2=2的基础上再进行+1,最后得出结果a2=3)

            //自减运算符（--）
            //和自加运算符同理，只是改变了符号
            
            //没有自乘或自除
            #endregion
        }
    }
}
