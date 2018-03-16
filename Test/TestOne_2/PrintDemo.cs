using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2、输入某人姓名XX，输出“XX，你好！”。
namespace TestOne_2
{
    class PrintDemo
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("请在键盘上输入姓名！");
            str = Console.ReadLine();//接受键盘输入
            Console.WriteLine(str + ",你好！");
            Console.ReadKey();
        }
    }
}
