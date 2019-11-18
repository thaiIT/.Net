using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGUI
{
    class CanNha : Shape, ChiPhiSon
    {
        public int tinhDienTich()
        {
            return (chieu_rong * chieu_cao);
        }
        public int tinhChiPhi(int dien_tich)
        {
            return dien_tich * 70;
        }
    }
}
