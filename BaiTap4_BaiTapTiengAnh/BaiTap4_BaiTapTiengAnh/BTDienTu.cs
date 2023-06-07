using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4_BaiTapTiengAnh
{
    class Data
    {
        public static BTDienTu data = new BTDienTu();
    }
    class BTDienTu
    {
        private string debai, dapan;
        private List<string> dapantungcau;

        public BTDienTu() { }
        
        public string Debai { get; set; }
        public string Dapan { get; set; }
        public List<string> Dapantungcau { get; set; }
    }
}
