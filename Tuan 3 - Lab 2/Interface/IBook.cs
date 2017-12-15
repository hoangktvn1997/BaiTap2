using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_3___Lab_2.Interface
{
    interface IBook
    {
        string this[int index] { get; set; }

        string ISBN { get; set; }

        string Title { get; set; }
    }
}
