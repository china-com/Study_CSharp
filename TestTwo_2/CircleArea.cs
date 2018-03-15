using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//实验二   第二题
//构造一个Circle，求圆的面积。

namespace TestTwo
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.Write("请输入圆的半径：");
            string str = Console.ReadLine();
            int r = int.Parse(str);
            Circle c = new Circle(r);
            c.Girth();
            c.Area();
            Console.ReadKey();
        }
    }
    class Circle
    {
        double PI = 3.14;
        private int r;
        public Circle(int a)
        {
            r = a;
        }
        public void Girth()
        {
            double girth;
            girth = 2 * PI * r;
            Console.WriteLine("圆的周长为：{0}", girth);
        }
        public void Area()
        {
            double area;
            area = PI * r * r;
            Console.WriteLine("圆的面积为：{0}", area);
        }

    }

}

