namespace LamToan
{
    partial class frmLamToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLamToan));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblCaptionTime = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pnCommand = new System.Windows.Forms.Panel();
            this.btnKT = new System.Windows.Forms.Button();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblMarkCaption = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.pnInitual = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLimit = new System.Windows.Forms.ComboBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnTypeOfWork = new System.Windows.Forms.Panel();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbMultiTable = new System.Windows.Forms.RadioButton();
            this.pnMulti = new System.Windows.Forms.Panel();
            this.lblChooseMulti = new System.Windows.Forms.Label();
            this.nudMulti = new System.Windows.Forms.NumericUpDown();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.DoTime = new System.Windows.Forms.Timer(this.components);
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.pnCommand.SuspendLayout();
            this.pnInitual.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnTypeOfWork.SuspendLayout();
            this.pnMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMulti)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnTitle.Controls.Add(this.lblCaptionTime);
            this.pnTitle.Controls.Add(this.lblCaption);
            this.pnTitle.Location = new System.Drawing.Point(3, 83);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(470, 57);
            this.pnTitle.TabIndex = 0;
            // 
            // lblCaptionTime
            // 
            this.lblCaptionTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionTime.ForeColor = System.Drawing.Color.Blue;
            this.lblCaptionTime.Location = new System.Drawing.Point(0, 29);
            this.lblCaptionTime.Name = "lblCaptionTime";
            this.lblCaptionTime.Size = new System.Drawing.Size(470, 29);
            this.lblCaptionTime.TabIndex = 2;
            this.lblCaptionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Green;
            this.lblCaption.Location = new System.Drawing.Point(1, 3);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(469, 26);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Luyện khả năng tính toán cho trẻ từ 8 đến 14 tuổi";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCommand
            // 
            this.pnCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnCommand.Controls.Add(this.btnKT);
            this.pnCommand.Controls.Add(this.lblMarks);
            this.pnCommand.Controls.Add(this.lblMarkCaption);
            this.pnCommand.Location = new System.Drawing.Point(473, -2);
            this.pnCommand.Name = "pnCommand";
            this.pnCommand.Size = new System.Drawing.Size(153, 141);
            this.pnCommand.TabIndex = 10;
            // 
            // btnKT
            // 
            this.btnKT.AutoSize = true;
            this.btnKT.Enabled = false;
            this.btnKT.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKT.ForeColor = System.Drawing.Color.Red;
            this.btnKT.Location = new System.Drawing.Point(4, 3);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(143, 36);
            this.btnKT.TabIndex = 0;
            this.btnKT.Text = "Chấm Điểm";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.bntKT_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.Font = new System.Drawing.Font("Bradley Hand ITC", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.ForeColor = System.Drawing.Color.Red;
            this.lblMarks.Location = new System.Drawing.Point(1, 40);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(143, 58);
            this.lblMarks.TabIndex = 7;
            this.lblMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarkCaption
            // 
            this.lblMarkCaption.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkCaption.ForeColor = System.Drawing.Color.Red;
            this.lblMarkCaption.Location = new System.Drawing.Point(1, 98);
            this.lblMarkCaption.Name = "lblMarkCaption";
            this.lblMarkCaption.Size = new System.Drawing.Size(143, 40);
            this.lblMarkCaption.TabIndex = 7;
            this.lblMarkCaption.Text = "Điểm";
            this.lblMarkCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMarkCaption.Visible = false;
            // 
            // btnInit
            // 
            this.btnInit.AutoSize = true;
            this.btnInit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.ForeColor = System.Drawing.Color.Blue;
            this.btnInit.Location = new System.Drawing.Point(55, 141);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(198, 46);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "Tạo Bài Tập";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblClock.Location = new System.Drawing.Point(259, 143);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(366, 47);
            this.lblClock.TabIndex = 11;
            this.lblClock.Text = "label4";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnInitual
            // 
            this.pnInitual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnInitual.Controls.Add(this.label3);
            this.pnInitual.Controls.Add(this.cmbOperation);
            this.pnInitual.Controls.Add(this.label2);
            this.pnInitual.Controls.Add(this.cmbLimit);
            this.pnInitual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnInitual.Location = new System.Drawing.Point(189, 3);
            this.pnInitual.Name = "pnInitual";
            this.pnInitual.Size = new System.Drawing.Size(240, 74);
            this.pnInitual.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phép Tính";
            // 
            // cmbOperation
            // 
            this.cmbOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperation.ForeColor = System.Drawing.Color.Teal;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(128, 40);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(107, 30);
            this.cmbOperation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phạm vi tính";
            // 
            // cmbLimit
            // 
            this.cmbLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLimit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbLimit.FormattingEnabled = true;
            this.cmbLimit.Location = new System.Drawing.Point(128, 5);
            this.cmbLimit.Name = "cmbLimit";
            this.cmbLimit.Size = new System.Drawing.Size(107, 30);
            this.cmbLimit.TabIndex = 5;
            // 
            // pnMain
            // 
            this.pnMain.AutoSize = true;
            this.pnMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.pnContent);
            this.pnMain.Controls.Add(this.lblClock);
            this.pnMain.Controls.Add(this.pnTitle);
            this.pnMain.Controls.Add(this.btnInit);
            this.pnMain.Controls.Add(this.pnTypeOfWork);
            this.pnMain.Controls.Add(this.pnCommand);
            this.pnMain.Location = new System.Drawing.Point(3, 32);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(629, 473);
            this.pnMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(1, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhấn Tab để sang câu tiếp theo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContent
            // 
            this.pnContent.AutoScroll = true;
            this.pnContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnContent.Location = new System.Drawing.Point(3, 193);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(622, 250);
            this.pnContent.TabIndex = 7;
            // 
            // pnTypeOfWork
            // 
            this.pnTypeOfWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnTypeOfWork.Controls.Add(this.rdbNormal);
            this.pnTypeOfWork.Controls.Add(this.rdbMultiTable);
            this.pnTypeOfWork.Controls.Add(this.pnMulti);
            this.pnTypeOfWork.Controls.Add(this.pnInitual);
            this.pnTypeOfWork.ForeColor = System.Drawing.Color.Navy;
            this.pnTypeOfWork.Location = new System.Drawing.Point(2, 0);
            this.pnTypeOfWork.Name = "pnTypeOfWork";
            this.pnTypeOfWork.Size = new System.Drawing.Size(470, 82);
            this.pnTypeOfWork.TabIndex = 10;
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdbNormal.Checked = true;
            this.rdbNormal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormal.ForeColor = System.Drawing.Color.Red;
            this.rdbNormal.Location = new System.Drawing.Point(10, 8);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(94, 23);
            this.rdbNormal.TabIndex = 0;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Làm Toán";
            this.rdbNormal.UseVisualStyleBackColor = false;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // rdbMultiTable
            // 
            this.rdbMultiTable.AutoSize = true;
            this.rdbMultiTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdbMultiTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMultiTable.ForeColor = System.Drawing.Color.Blue;
            this.rdbMultiTable.Location = new System.Drawing.Point(10, 43);
            this.rdbMultiTable.Name = "rdbMultiTable";
            this.rdbMultiTable.Size = new System.Drawing.Size(145, 23);
            this.rdbMultiTable.TabIndex = 0;
            this.rdbMultiTable.Text = "Học Cửu Chương";
            this.rdbMultiTable.UseVisualStyleBackColor = false;
            this.rdbMultiTable.CheckedChanged += new System.EventHandler(this.rdbMultiTable_CheckedChanged);
            // 
            // pnMulti
            // 
            this.pnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnMulti.Controls.Add(this.lblChooseMulti);
            this.pnMulti.Controls.Add(this.nudMulti);
            this.pnMulti.Location = new System.Drawing.Point(189, 3);
            this.pnMulti.Name = "pnMulti";
            this.pnMulti.Size = new System.Drawing.Size(240, 71);
            this.pnMulti.TabIndex = 0;
            this.pnMulti.Visible = false;
            // 
            // lblChooseMulti
            // 
            this.lblChooseMulti.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseMulti.ForeColor = System.Drawing.Color.Blue;
            this.lblChooseMulti.Location = new System.Drawing.Point(4, 1);
            this.lblChooseMulti.Name = "lblChooseMulti";
            this.lblChooseMulti.Size = new System.Drawing.Size(141, 69);
            this.lblChooseMulti.TabIndex = 4;
            this.lblChooseMulti.Text = "Chọn Bảng Cửu Chương";
            this.lblChooseMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMulti
            // 
            this.nudMulti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMulti.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMulti.ForeColor = System.Drawing.Color.Blue;
            this.nudMulti.Location = new System.Drawing.Point(188, 23);
            this.nudMulti.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudMulti.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMulti.Name = "nudMulti";
            this.nudMulti.Size = new System.Drawing.Size(45, 25);
            this.nudMulti.TabIndex = 1;
            this.nudMulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMulti.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // DoTime
            // 
            this.DoTime.Interval = 1000;
            this.DoTime.Tick += new System.EventHandler(this.DoTime_Tick);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Red;
            this.lbWelcome.Location = new System.Drawing.Point(100, 7);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(20, 22);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Text = "  ";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(484, 7);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(141, 22);
            this.lblExit.TabIndex = 6;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "Change Account";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xin chào";
            // 
            // frmLamToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(632, 504);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLamToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÉ HỌC CỘNG - TRỪ - NHÂN - CHIA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLamToan_FormClosing);
            this.Load += new System.EventHandler(this.frmLamToan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLamToan_MouseDown);
            this.pnTitle.ResumeLayout(false);
            this.pnCommand.ResumeLayout(false);
            this.pnCommand.PerformLayout();
            this.pnInitual.ResumeLayout(false);
            this.pnInitual.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnTypeOfWork.ResumeLayout(false);
            this.pnTypeOfWork.PerformLayout();
            this.pnMulti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMulti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnCommand;
        private System.Windows.Forms.Button btnKT;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblMarkCaption;
        private System.Windows.Forms.Panel pnInitual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLimit;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel pnTypeOfWork;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbMultiTable;
        private System.Windows.Forms.NumericUpDown nudMulti;
        private System.Windows.Forms.Label lblChooseMulti;
        private System.Windows.Forms.Panel pnMulti;
        private System.Windows.Forms.Timer DoTime;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblCaptionTime;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

