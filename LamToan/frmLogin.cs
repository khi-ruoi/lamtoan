using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace LamToan
{
    public partial class frmLogin : Form
    {
        //Kiểm tra kết nối Internet
        public static bool CheckIC()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static int id;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var lamtoanContext = new LamToanContext();
            var user = lamtoanContext.Users.FirstOrDefault(x => x.UserName != "" && x.Password != "");
            frmLamToan.name = user.Name;
            id = user.Id;
            Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLamToan.iLoad = 1;
            if(CheckIC())
            { 
                //Dùng tạo mới đối tượng context để tương tác với cơ sở dữ liệu.
                var lamtoanContext = new LamToanContext();
                //y tuong: so sanh user name password
                // lamtoanContext.Users bang user, cai nay la danh sach cac username
                //firstordefault la lay 1 phan tu trong day ma dieu kien la
                //hehe
                var test = lamtoanContext.Users.ToList();
                var d = lamtoanContext.Users.Count();

                txtUName.SelectionStart = 0;
                txtUName.SelectionLength = 0;
                txtUName.ForeColor = Color.Gray;
                txtUName.Text = "Type User Name here...";
                //txtUName.Text = frmRegister.uname.Trim();
                //txtPass.Text = frmRegister.upass.Trim();
            }
            else
            {
                Hide();
                //new frmLamToan().Show();
            }
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

        private void txtUName_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.IBeam;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().ShowDialog();
            Hide();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
             
            //Dùng tạo mới đối tượng context để tương tác với cơ sở dữ liệu.
            var lamtoanContext = new LamToanContext();
            //y tuong: so sanh user name password
            // lamtoanContext.Users bang user, cai nay la danh sach cac username
            //firstordefault la lay 1 phan tu trong day ma dieu kien la
            //var test = lamtoanContext.Users.ToList();
            var user = lamtoanContext.Users.FirstOrDefault(x => x.UserName == txtUName.Text && x.Password == txtPass.Text);
            if (user == null)
            {
                //dang nhap fail
                MessageBox.Show("Thông tin đăng nhập không đúng!\nKiểm tra lại Username và Password",
                    "Login Failed!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtUName.Focus();
            }
            else
            {
                //passed Login
                //MessageBox.Show("welcome");
                frmLamToan.name = user.Name;
                id = user.Id;
                Hide();
                //MessageBox.Show("Successful!");
                //frmLamToan().Show();

            }

        }

        private void txtUName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUName.Text == "Type User Name here...")
                txtUName.SelectionStart = 0;
        }

        private void txtUName_Leave(object sender, EventArgs e)
        {
            if (txtUName.Text.Equals(null) == true || txtUName.Text.Equals("") == true)
            {
                txtUName.Text = "Type User Name here...";
                txtUName.ForeColor = Color.Gray;
            }
        }

        private void txtUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btLog.Focus();
            }
        }
    }
}
