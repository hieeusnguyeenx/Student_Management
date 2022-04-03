using DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login : Form
    {
        private QLSV_Context context = new QLSV_Context();
        public string role;

        public Login()
        {
            InitializeComponent();
        }

        private void regist_buton_Click(object sender, EventArgs e)
        {
            Regist regist_Form = new Regist();
            regist_Form.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(context.Users.Any(p => p.UserName == this.username.Text) && context.Users.Any(p => p.Password == this.password.Text))
            {
                if (this.username.Text.Contains("@student.com"))
                {
                    Homepage_Student homepage_Student = new Homepage_Student();
                    homepage_Student.Show();
                }
                else if (this.username.Text.Contains("@teacher.com"))
                {
                    Homepage_Teacher homepage_Teacher = new Homepage_Teacher();
                    homepage_Teacher.Show();
                }
                else if (this.username.Text.Contains("@admin.com"))
                {
                    Homepage_Admin homepage_Admin = new Homepage_Admin();
                    homepage_Admin.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }
    }
}
