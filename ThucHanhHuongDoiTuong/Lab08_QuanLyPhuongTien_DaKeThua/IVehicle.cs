﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_QuanLyPhuongTien_DaKeThua
{
    interface IVehicle
    {
        string Ten { get; set; }
        int TocDo { get; set; }

        void Chay();
        void Dung();
        
    }
}
