using DataAccess;
using Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Regist : Form
    {
        private QLSV_Context context = new QLSV_Context();

        public Regist()
        {
            InitializeComponent();
        }

        private void regist_button_Click(object sender, EventArgs e)
        {
            if (context.Users.Any(p => p.UserName == this.username.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            }
            else
            {
                if (this.username.Text.Contains("@student.com") && !string.IsNullOrWhiteSpace(this.password.Text))
                {
                    context.Users.AddRange(new Student[] {new Student {UserName = this.username.Text, Password = this.password.Text}});
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                else if (this.username.Text.Contains("@teacher.com") && !string.IsNullOrWhiteSpace(this.password.Text))
                {
                    context.Users.AddRange(new Teacher[] {new Teacher {UserName = this.username.Text, Password = this.password.Text}});
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                else if (this.username.Text.Contains("@admin.com") && !string.IsNullOrWhiteSpace(this.password.Text))
                {
                    context.Users.AddRange(new Admin[] {new Admin {UserName = this.username.Text, Password = this.password.Text}});
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!");
                }

                context.SaveChangesAsync();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
