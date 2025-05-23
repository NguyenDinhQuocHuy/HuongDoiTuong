using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KeThua_VD5_CheTraiCay
{
    class Che
    {
        List<TraiCay> dst = new List<TraiCay>();
        List<NguyenLieu> dsn = new List<NguyenLieu>();
        public void CheBien()
        {
            foreach (TraiCay t in dst)
                t.CheBien();
            foreach (NguyenLieu l in dsn)
                l.CheBien();
        }
    }
}
