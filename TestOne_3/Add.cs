using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3、从键盘输入两个整数，输出和；如：输入a=123，b=456,求a+b=？。
namespace TestOne_3
{
    class Add
    {
        static void Main(string[] args)
        {
            int a,b,sum;
            String c, d;//用于接受键盘输入
            Console.WriteLine("请输入第一个数字，按回车键确定。");
            c = Console.ReadLine();
            a = int.Parse(c);//将数字字符串转化成数字
            Console.WriteLine("请输入第二个数字，按回车键得出答案。");
            d = Console.ReadLine();
            b = int.Parse(d);//将数字字符串转化成数字
            sum = a + b;
            Console.WriteLine(a+"+"+b+"="+sum);//打印结果
            Console.Read();
        }
    }
}
