using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuan_3___Lab_2.Interface;

namespace Tuan_3___Lab_2.Entities
{
    class Book : IBook
    {
        //Tạo list Chapter
        private ArrayList chapters = new ArrayList();

        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string ISBN { get; set; }

        public string Title { get; set; }

        //Input
        public void Input()
        {
            Console.Write("\nISBN: ");
            ISBN = Console.ReadLine();
            Console.Write("Title: ");
            Title = Console.ReadLine();
            //Console.WriteLine("Chapter: ");
            //Nhập Chapter, Exit if NULL
            string str;
            int i = 0;
            do
            {
                //do
                //{
                    Console.Write("Chapter {0} - Name: ", i + 1);
                    str = Console.ReadLine();
                    if (int.TryParse(Console.ReadLine(), out i))
                    {
                        Console.WriteLine("Xin nhay nhap so tu nhien!");
                    }
                //}while()
                if(str.Length > 0)
                {
                    chapters[i] = str;
                    i++;
                }
            } while (true);
        }

        //Output - Show
        public void Show()
        {
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Chapter: ");

            foreach (var item in chapters)
            {
                Console.Write("\t");
                Console.WriteLine(item);
            }
        }
    }
}
