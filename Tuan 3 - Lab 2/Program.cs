using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuan_3___Lab_2.App;

namespace Tuan_3___Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager app = new BookManager();
            app.Input();

            //Dừng màn hình để xem kết quả
            Console.ReadLine();
        }
    }
}
