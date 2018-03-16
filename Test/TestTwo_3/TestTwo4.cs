using System.Collections.Generic;
using System.Linq;
using System.Text;
//实验二   第四题
//4、在第三题的基础上继续编程，设计一个Reconvert(string str)方法,用于逆序输出。
//此题编写了两个类，一个是MyClass，另一个是TestTwo4。

namespace Test
{
    class TestTwo4
    {
        public TestTwo4()
        {
        }
        public string Reconver(string s)
        {
            char[] c = s.ToArray();
            for (int i = 0; i < (c.Length - 1) / 2 + 1; i++)
            {
                char temp = c[i];
                c[i] = c[c.Length - 1 - i];
                c[c.Length - 1 - i] = temp;
            }
            string done = "";
            for (int i = 0; i < c.Length; i++)
            {
                done += c[i].ToString();
            }
            return done;
        }
    }
}