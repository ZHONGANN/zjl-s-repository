using System;

namespace _2
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            string a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
            Console.WriteLine("请输入第二个数：");
            string b = Console.ReadLine();
            int num2 = Convert.ToInt32(b);
            Console.WriteLine("两个数的和：{0}", num1 + num2);
            Console.WriteLine("两个数的差：{0}", num1 - num2);
            Console.WriteLine("两个数相乘：{0}", num1 * num2);
            Console.WriteLine("两个数相除：{0}", (double)num1 / num2);
            return 0;
        }

    }
}
