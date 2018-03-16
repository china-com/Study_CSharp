using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*实验二   第一题
 *姓名：陈红鹃
 *班级：N15计科一班
 *日期：2018/3/15
 */
//1、从键盘上输入字符串，统计字母，数字，和空格的个数，并输出结果。
namespace Test
{
    class PrintDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请在键盘上输入信息:");
            String str = Console.ReadLine();
            int alpha = 0, digit = 0, other = 0;
            foreach (char c in str)//遍历键盘输入的字符串
            {
                if (Char.IsLetter(c))
                {
                    ++alpha;
                }
                else if (Char.IsDigit(c))
                {
                    ++digit;
                }
                else
                {
                    ++other;
                }
            }
            Console.WriteLine("您在键盘上输入的数据中有：字母有{0}个，数字有{1}个，其他有：{2}个!", alpha, digit, other);//输出信息
            Console.ReadKey();
        }
    }
}
