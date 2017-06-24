using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LamToan
{
    public partial class frmMultiplicationTable : Form
    {
        public frmMultiplicationTable()
        {
            InitializeComponent();
            SetToolTip();
        }

        private void multiplicationTable_Load(object sender, EventArgs e)
        {
            CreatMultiTable();
        }

        void CreatMultiTable()
        {
            int iMulti = 9;
            lblMultiTable.Text = string.Empty;
            for (int i = 1; i <= iMulti; i++)
            {
                for (int j = 2; j <= iMulti; j++)
                {
                    if (i * j < 10)
                        lblMultiTable.Text += j + " x " + i + " = \t " + i * j + " \t ";
                    else
                        lblMultiTable.Text += j + " x " + i + " = \t" + i * j + " \t ";
                    if (j == iMulti)
                        lblMultiTable.Text += "\n";
                }
            }
            Width = lblMultiTable.Width + 15;
            Height = lblMultiTable.Height + 110;
            lblTitle.Width = lblMultiTable.Width;
            lblTitle.Left = lblMultiTable.Left;
        }
        void SetToolTip()
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(lblTitle, "Click to Hide Multiplication Table");
            TT.IsBalloon=true;
            TT.ToolTipIcon = ToolTipIcon.Info;           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
