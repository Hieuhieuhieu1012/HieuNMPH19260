using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nguyen_Manh_Hieu_Assignment_1_Csharp_3
{
    internal class SV
    {
        private string masv;
        private string hoten;
        private string email;
        private string sđt;
        private string điachi;

        public SV(string masv, string hoten, string email, string sđt,  string điachi, string type)
        {
            ArrayList al = new ArrayList();
            this.Masv = masv;
            this.Hoten = hoten;
            this.Email = email;
            this.Sđt = sđt;
            this.Điachi = điachi;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Email { get => email; set => email = value; }
        public string Sđt { get => sđt; set => sđt = value; }
        public string Điachi { get => điachi; set => điachi = value; }

        public override string ToString()
        {

            return hoten + " ;" + "Email :" + email + "; sdt: " + sđt + "; Địa chỉ : "+ điachi;
        }
  
    }
    class Nam { }
    
    class Nu { }
}
