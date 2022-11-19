namespace Nguyen_Manh_Hieu_Assignment_1_Csharp_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var User = "hieunmph19260";
            var Pass = "123456";
            if (User.Equals(txtUserName.Text) && Pass.Equals(txtPassWord.Text))
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                var mainFrom = new QuanLyDiem();
                this.Hide();
                mainFrom.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui Long thử lại !");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked == true) {
               txtPassWord.UseSystemPasswordChar= true;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}