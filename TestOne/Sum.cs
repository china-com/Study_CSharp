using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C#实验一
 * 姓名：陈红鹃
 * 班级：15计科一班
 * 日期：2018/3/8
 */

//1、编程求1+2+3+......+100的和。
namespace TestOne
{
    class Sum
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            for (a = 0; a <= 100; a++)
            {
                sum += a;
            }
            Console.WriteLine("1+2+3+.....+100的和是：" + sum);
            Console.ReadKey();
        }
    }
}
