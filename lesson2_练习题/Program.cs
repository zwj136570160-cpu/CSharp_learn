namespace lesson2_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量_练习题");
            Console.WriteLine();
            
            //请定义一系列变量来存储你的名字、年龄、性别、身高、体重、家庭住址等，并打印出来。
            string name = "张三";
            byte age = 25;
            char sex = '男';
            float height = 175.5f;
            float weight = 70.0f;
            string address = "北京市朝阳区幸福大街100号";
            Console.WriteLine("我的名字是：" + name);
            Console.WriteLine("我的年龄是：" + age + "岁");
            Console.WriteLine("我的性别是：" + sex);
            Console.WriteLine("我的身高是：" + height + "cm");
            Console.WriteLine("我的体重是：" + weight + "kg");
            Console.WriteLine("我的家庭住址是：" + address);
        }
    }
}
