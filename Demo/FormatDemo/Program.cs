using System;

namespace FormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int p=0;
            while (true)
            {
                if (p<3)
                {
                    Console.WriteLine("请输入用户名！");
                    string str;
                    str = Console.ReadLine();
                    if (str=="admin")
                    {
                        Console.WriteLine("登录成功！");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        p++;
                        Console.WriteLine("请重新输入用户名！");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("您输错的次数已经达三次，不能再登录！");
                    Console.ReadKey();
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
