using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//实验二   第三题
//3、编写一个名称为MyClass一个类，在该类中编写CountChar（String str，char ch）方法，用于返回第二个参数在第一个参数中出现过的次数。
//此题编写了两个类，一个是MyClass，另一个是Program.

namespace Test
{
    class MyclassMain
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            TestTwo4 tt = new TestTwo4();
            int num;
            num = mc.CountChar("6221982", '2');
            Console.WriteLine(num);
            /*
            string str;
            int i = 123456;
            str = i.ToString();
            str = tt.Reconver(str);
            Console.WriteLine("元数据是：" + i);
            Console.Write("逆序输出：");
            Console.WriteLine(str);
            */
            Console.ReadKey();
        }
    }
}
