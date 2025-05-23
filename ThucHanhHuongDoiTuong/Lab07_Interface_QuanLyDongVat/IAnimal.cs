using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Interface_QuanLyDongVat
{
    interface IAnimal
    {
        int Age { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        void Speak();
    }
}
