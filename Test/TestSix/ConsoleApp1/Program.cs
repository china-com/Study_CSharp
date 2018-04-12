using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "server=localhost;User Id=root;password=296200336;Database=StudyDemo";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("insert into student(xh) values (111)", mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("数据插入成功！");
            }
            Console.ReadLine();
            mycon.Close();
        }
    }
}
