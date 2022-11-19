using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyen_Manh_Hieu_Assignment_1_Csharp_3
{
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var mainFormQLSV = new QuanLySinhVien();
            this.Hide();
            mainFormQLSV.Show();
        }
    }
}
