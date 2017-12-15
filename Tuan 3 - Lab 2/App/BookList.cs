using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuan_3___Lab_2.Entities;


namespace Tuan_3___Lab_2.App
{
    class BookList
    {
        
        private ArrayList books = new ArrayList();
        private Book newBook;

        //Input List
        public void Input(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                newBook = new Book();
                newBook.Input();
                books.Add(newBook);
            }
        }

        //Output - Show List
        public void Show()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("-----Danh sach Sach-----");
                book.Show();
            }
        }
    }
}
