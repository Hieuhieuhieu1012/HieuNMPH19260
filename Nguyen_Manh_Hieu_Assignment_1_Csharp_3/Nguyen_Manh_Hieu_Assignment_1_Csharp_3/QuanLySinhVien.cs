using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace Nguyen_Manh_Hieu_Assignment_1_Csharp_3
{
    public partial class QuanLySinhVien : Form
    {
        string[] arr = new string[6];
        string type;
        ArrayList StudentList = new ArrayList();
        ArrayList Temp = new ArrayList();

        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        public void UpdateList(ArrayList a)
        {
            ListViewItem itm;
            listView1.Items.Clear();
            foreach (SV sv in a)
            {
                arr[0] = sv.Masv;
                arr[1] = sv.Hoten;
                arr[2] = sv.Email;
                arr[3] = sv.Sđt;
                arr[4] = sv.Điachi;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (textMSSV.Text != "" && textHoTen.Text != "" && textEmail.Text != "" && textSDT.Text != "" && textDiaChi.Text != "")
            {
                SV a = new SV(textMSSV.Text, textHoTen.Text, textEmail.Text, textDiaChi.Text, textSDT.Text, type);
                this.StudentList.Add(a);
            }
            ListViewItem itm;
            arr[0] = textMSSV.Text;
            arr[1] = textHoTen.Text;
            arr[2] = textEmail.Text;
            arr[3] = textSDT.Text;
            arr[4] = textDiaChi.Text;
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            arr[5] = "Nam";
            type = "Nam";
               
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            arr[5] = "Nữ";
            type = "Nữ";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList;
            selectedList = listView1.SelectedItems;
            foreach (ListViewItem item in selectedList)
            {
                string ms = item.Text;
                foreach (SV sv in StudentList)
                {
                    if (sv.Masv != ms) Temp.Add(sv);
                }
            }
            UpdateList(Temp);
            StudentList = (ArrayList)Temp.Clone();

            this.Temp.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainFrom = new QuanLyDiem();
            this.Hide();
            mainFrom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
