using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//实验二   第三题
//3、编写一个名称为MyClass一个类，在该类中编写CountChar（String str，char ch）方法，用于返回第二个参数在第一个参数中出现过的次数。
//此题编写了两个类，一个是MyClass，另一个是Program.

namespace Test
{
    class MyClass
    {
        public MyClass()
        {
        }
        public int CountChar(string str, char ch)
        {
            string st;
            st = str;
            int num = 0;
            foreach (char c in st)
            {
                if (Char.IsDigit(c))
                {
                    if (c.Equals(ch))
                    {

                        ++num;
                    }
                }
                else
                {
                    Console.WriteLine("输入有误！");
                }
            }
            return num;
        }
    }
}
