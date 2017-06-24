using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace LamToan
{
    public partial class frmLamToan : Form
    {
        //Kiểm tra kết nối Internet của Client
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
        // Make Form Movable        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Off Initialize


        // Biến tạm
        public static string name;
        public static int iLoad = 0;
        
        const int iCount = 21;
        //Making Question UI
        Panel[] pn = new Panel[iCount];
        Label[] cau = new Label[iCount];
        Label[] SoA = new Label[iCount];
        Label[] Pt = new Label[iCount];
        Label[] SoB = new Label[iCount];
        Label[] EMark = new Label[iCount];
        TextBox[] gtkq = new TextBox[iCount];
        Label[] pb = new Label[iCount];
        //End Question UI
        int[] Answer = new int[iCount];
        int NumOfSentence = 20;
        int timeSpend;
        string Opera;
        string pt;

        Random rd = new Random();

        int a;
        int b;
        int limit;
        public frmLamToan()
        {
            InitializeComponent();
            if (iLoad == 0)
            {
                if (CheckIC())
                {
                    new frmLogin().ShowDialog();
                    lbWelcome.Visible = true;
                    lblExit.Visible = true;
                    Hide();
                    var lamtoanContext = new LamToanContext();
                    var user = lamtoanContext.Users.FirstOrDefault(x => x.Id == frmLogin.id);
                    name = user.Name;

                }
                else
                {
                    name = " Baby ";
                    lblExit.Visible = false;
                }
                iLoad++;
            }

            //Tạo liên kết với DataBase SQL

            //var lamtoanContext = new LamToanContext();
            lbWelcome.Text = name;
            //lbWelcome.Visible = false;
            //pnMain.Location =new(((this.Size.Width - pnMain.Size.Width) / 2),pnMain.Size.Height);
            int InitA = 50;
            //Welcome khách
            //Mức giới hạn của phép tính
            for (int i=1;i<5;i++)
            {
                InitA *= 2;
                cmbLimit.Items.Add(InitA.ToString());
                InitA *= 5;
                cmbLimit.Items.Add(InitA.ToString());
            }
            InitA *= 2;
            cmbLimit.Items.Add(InitA.ToString());
            cmbLimit.SelectedIndex = 0;
            //Chọn phép tính
            cmbOperation.Items.Add("Cộng");
            cmbOperation.Items.Add("Trừ");
            cmbOperation.Items.Add("Nhân");
            cmbOperation.Items.Add("Chia");
            cmbOperation.Items.Add("Tổng hợp");
            cmbOperation.SelectedIndex = 0;

            //Show Blank Question
            //iBreak = 6;
            MakeQsUI();

        }

        void MakeQsUI()
        {
            int j = 0;
            int k = 300;
            for (int i = 1; i <= 20; i++)
            {
                //j++;
                if (i % 2 == 0)
                {
                    k += 300;
                    //j=1;
                }
                else
                {
                    k -= 300;
                    j++;
                }
                // Make Panel for Question
                pn[i] = new Panel()
                {
                    Size = new Size(280, 50),
                    Location = new Point(10 + k, j * 50 - 50),
                    BackColor = Color.Aqua,
                };
                //Make label cau
                cau[i] = new Label()
                {
                    Size = new Size(135, 25),
                    Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 1),
                    ForeColor = Color.Green,
                    Location = new Point(0, 3),
                    Text = "Câu "+i+":",
                };

                //Make label SoA
                SoA[i] = new Label()
                {
                    Size = new Size(65, 23),
                    Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 1),
                    ForeColor = Color.Red,
                    Location = new Point(0, 25),
                    Text = "",
                };
                //Make label Phep toan
                Pt[i] = new Label()
                {
                    Size = new Size(15, 23),
                    Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 1),
                    ForeColor = Color.Navy,
                    Location = new Point(65, 23),
                    Text="",
                };

                //Make label SoB
                SoB[i] = new Label()
                {
                    Size = new Size(65, 23),
                    Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 1),
                    ForeColor = Color.Red,
                    Location = new Point(80, 25),
                    Text = "",
                };

                //Make label dau bang
                EMark[i] = new Label()
                {
                    Size = new Size(15, 23),
                    Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 1),
                    ForeColor = Color.Red,
                    //BackColor=Color.Red,
                    Location = new Point(145, 25),
                    Text="=",
                };

                //Make Answer TextBox
                #region Make new answer Textbox
                gtkq[i] = new TextBox()
                {
                    Location = new Point(165,22),
                    Size = new Size(68, 80),
                    MaxLength = 6,
                    Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Text="",
                };
                gtkq[i].KeyPress += new KeyPressEventHandler(gtkq_KeyPress);
                #endregion

                //Make label Feedback
                pb[i] = new Label()
                {
                    Size = new Size(235, 38),
                    Font = new Font("Wingdings 2", 32F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2))),
                    Location = new Point(230,15),
                    Text= "",
                };
                //Show Question
                pn[i].Controls.Add(cau[i]);
                pn[i].Controls.Add(SoA[i]);
                pn[i].Controls.Add(SoB[i]);
                pn[i].Controls.Add(Pt[i]);
                pn[i].Controls.Add(EMark[i]);
                pn[i].Controls.Add(gtkq[i]);
                pn[i].Controls.Add(pb[i]);

                pnContent.Controls.Add(pn[i]);
            }
        }

        void MakeMultiplication()
        {

            lblCaption.Text = "Ôn bảng cửu chương [" + nudMulti.Value + "] số lượng: [10 câu]";
            for (int i = 1; i <= 10; i++)
            {
                SoA[i].Text = nudMulti.Value.ToString();
                Pt[i].Text = "x";
                SoB[i].Text = i.ToString();
                Answer[i] = (int)nudMulti.Value * i;
            }
        }
        void TaoSo()
        {
            #region Các phép tính
            void operaAdd()
            {
                a = rd.Next(limit / 10, limit / 3);
                b = rd.Next(limit / 10, (limit - a));
                pt = "+";

            }

            void operaMinus()
            {
                a = rd.Next(limit / 3, limit);
                b = rd.Next(a / 5, a);
                pt = "-";
            }

            void operaMulti()
            {
                a = rd.Next(2, limit / 10);
                b = rd.Next(3, (limit / a));

                pt = "x";
            }

            void operaDivide()
            {
                b = rd.Next(2, limit / 10);
                int uoc = rd.Next(2, (limit / b));
                //uoc = rd.Next(uoc/2, (uoc));
                a = uoc * b;
                pt = "÷";
            }
            #endregion
            int x;
            void swOpera(int y)
            {
                if (y == 0)
                    Opera = "+";
                if (y == 1)
                    Opera = "-";
                if (y == 2)
                    Opera = "x";
                if (y == 3)
                    Opera = "÷";
            }

            lblCaption.Text = "Làm toán [" + cmbOperation.Text + "] trong phạm vi [" + cmbLimit.Text + "] số lượng: [20 câu]";


            limit = int.Parse(cmbLimit.SelectedItem.ToString());
            #region Make Question
            for (int i = 1; i <= NumOfSentence; i++)
            {
                #region Xác định phép toán
                if (cmbOperation.SelectedIndex < 4)
                {
                    x = cmbOperation.SelectedIndex;
                    swOpera(x);
                }
                else
                {
                    x = rd.Next(0, 4);
                    swOpera(x);
                }
                #endregion

                #region Initualize Operation
                switch (Opera)
                {
                    case "+":
                        operaAdd();
                        Answer[i] = a + b;
                        break;
                    case "-":
                        operaMinus();
                        Answer[i] = a - b;
                        break;
                    case "x":
                        operaMulti();
                        Answer[i] = a * b;
                        break;
                    case "÷":
                        operaDivide();
                        Answer[i] = a / b;
                        break;
                }
                #endregion
                SoA[i].Text = a.ToString();
                SoB[i].Text = b.ToString();
                Pt[i].Text = pt;
                gtkq[i].Text = "";
                EMark[i].Text = "=";
                pb[i].Text = "";
            }
            #endregion
            gtkq[1].Focus();
        }

        private void bntKT_Click(object sender, EventArgs e)
        {
            int iCountRight = 0;
            int iCountMiss = 0;
            int iCountWrong = 0;

            string miss = "";
            string wrong = "";

            lblMarks.Visible = true;
            lblMarkCaption.Visible = true;
            for (int i = 1; i <= NumOfSentence; i++)
            {
                if (gtkq[i].Text == "")
                {
                    iCountMiss++;
                    miss += Convert.ToString(i) + " ";
                    if (iCountMiss % 10 == 0)
                        miss += "\n   ";
                    pb[i].Text = "";
                    pb[i].ForeColor = Color.Red;
                }
                else if (Answer[i] != Convert.ToInt32(gtkq[i].Text))
                {
                    iCountWrong++;
                    wrong += Convert.ToString(i) + " ";
                    if (iCountWrong % 10 == 0)
                        wrong += "\n   ";
                    pb[i].Text = "";
                    pb[i].ForeColor = Color.Red;
                }
                else
                {
                    pb[i].Text = "";
                    pb[i].ForeColor = Color.Green;
                }

            }
            iCountRight = NumOfSentence - iCountMiss - iCountWrong;
            lblMarks.Text = Convert.ToString(Math.Round(((float)iCountRight / NumOfSentence), 3) * 10);

        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            //Làm trống Panel
            
            lblMarks.Visible = false;
            lblMarkCaption.Visible = false;
            DoTime.Enabled = true;
            if (rdbNormal.Checked == true)
            {
                TaoSo();
                for(int i=11;i<=20;i++)
                {
                    pn[i].Visible = true;
                }
            }
            else
            {
                MakeMultiplication();
                for (int i = 11; i <= 20; i++)
                {
                    pn[i].Visible = false;
                }
            }
            btnKT.Enabled = true;
            timeSpend = -1;
        }

        private void gtkq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit() ;
        }

        private void btnMultiTable_Click(object sender, EventArgs e)
        {
            Form mtTable = new frmMultiplicationTable();
            mtTable.Show();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.DayOfWeek+", "+DateTime.Now.Day+" / "+DateTime.Now.Month+" / "+DateTime.Now.Year + "\n"+"Bây giờ là:    "+DateTime.Now.ToLongTimeString();
        }

        private void rdbMultiTable_CheckedChanged(object sender, EventArgs e)
        {
            NumOfSentence = 10;
            if (rdbMultiTable.Checked == true)
            {
                pnInitual.Visible = false;
                pnMulti.Visible = true;
                rdbMultiTable.ForeColor = Color.Red;
            }
            else
                rdbMultiTable.ForeColor = Color.Blue;
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            NumOfSentence = 20;
            if (rdbNormal.Checked == true)
            {
                pnInitual.Visible = true;
                pnMulti.Visible = false;
                rdbNormal.ForeColor = Color.Red;
            }
            else
                rdbNormal.ForeColor = Color.Blue;

        }

        private void DoTime_Tick(object sender, EventArgs e)
        {
            string TSpend;
            timeSpend += 1;
            if (timeSpend >= 60)
                TSpend = (timeSpend / 60).ToString() + " phút " + (timeSpend % 60).ToString() + " giây ";
            else TSpend = timeSpend.ToString() + " giây ";
            lblCaptionTime.Text ="Thời gian làm bài: " + TSpend;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmLamToan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckIC())
            {
                new frmLogin().ShowDialog();
                lbWelcome.Text = name;
            }
            else
            {
                MessageBox.Show("Không thể kết nối Internet!", "Noticed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLamToan_Load(object sender, EventArgs e)
        {
        }

        private void frmLamToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}