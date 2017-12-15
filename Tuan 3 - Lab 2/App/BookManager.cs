using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuan_3___Lab_2.Entities;

namespace Tuan_3___Lab_2.App
{
    class BookManager
    {
        private BookList booklist = new BookList();

        //Chạy chương trình
        public void Run()
        {
            int Choose = -1;

            do
            {
                Console.WriteLine("\n1. Nhap danh sach");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Thoat");
                Console.Write("Chon Thao Tac: ");

                try
                {
                    Choose = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("\nChon sai roi! Xin hay nhap lai.");
                }

                switch (Choose)
                {
                    case 1:
                        int soLuong = -1;
                        do
                        {
                            Console.Write("Nhap so luong sach can nhap: ");
                            if (int.TryParse(Console.ReadLine(), out soLuong) == false)
                            {
                                Console.Write("\nNhap sai! Xin hay nhap lai.\n");
                            }
                        } while (soLuong == -1);
                        booklist.Input(soLuong);
                        break;

                    case 2:
                        booklist.Show();
                        break;

                    case 3:
                        break;

                    default:
                        break;
                }
            } while (Choose != -1);
        }
    }
}
