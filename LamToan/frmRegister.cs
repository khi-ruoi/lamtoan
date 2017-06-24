using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LamToan
{
    public partial class frmRegister : Form
    {
        public static string uname = "", upass = "";

        public frmRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new frmLogin().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var lamtoanContext = new LamToanContext();
            var user = lamtoanContext.Users.FirstOrDefault(x => x.UserName != "" && x.Password != "");
            frmLamToan.name = user.Name;
            frmLogin.id = user.Id;
            Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            var lamtoanContext = new LamToanContext();
            var test = lamtoanContext.Users.ToList();
            txtUName.SelectionStart = 0;
            txtUName.SelectionLength = 0;
            txtUName.ForeColor = Color.Gray;
            txtUName.Text = "Type User Name here...";
        }

        private void txtUName_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUName.Text.Equals("Type User Name here...") == true)
            {
                txtUName.Text = "";
                txtUName.ForeColor = Color.Black;
            }
        }

        private void txtUName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUName.Text.Equals(null) == true || txtUName.Text.Equals("") == true)
            {
                txtUName.Text = "Type User Name here...";
                txtUName.ForeColor = Color.Gray;
            }
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            var lamtoanContext = new LamToanContext();
            // check user name ko cho trung
            // so sanh vs cac user name duoi db
            var checkUsername = lamtoanContext.Users.Where(x => x.UserName == txtUName.Text);
            if (txtUName.Text.Trim() == "" || txtUName.Text.Trim() == "" || txtPass.Text == "" || txtPassReType.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ", "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPass.Text != txtPassReType.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác!\nKiểm tra lại", "Cảnh báo đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (checkUsername.Count() > 0)
                {
                    MessageBox.Show("Tài khoản " + txtUName.Text.Trim() + " đã được sử dụng");
                }
                else
                {
                    //tao doi tượng user từ form nhập vào
                    var user = new User
                    {
                        //Id = 4,
                        Name = txtName.Text,
                        UserName = txtUName.Text,
                        Password = txtPass.Text,
                        Point = 0
                    };
                    //lưu xuống db
                    //Dùng tạo mới đối tượng context để tương tác với cơ sở dữ liệu.
                    lamtoanContext.Users.Add(user);
                    lamtoanContext.SaveChanges();
                    MessageBox.Show("Đăng ký tên tài khoản " + txtUName.Text.Trim() + " thành công");
                    frmLogin.id = user.Id;
                    frmLamToan.name = txtName.Text;
                    uname = txtName.Text;
                    upass = txtPass.Text;
                    Hide();
                }
            }
        }

        private void txtUName_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == "Type User Name here...")
            {
                txtUName.SelectionStart = 0;
            }
        }
    }
}
