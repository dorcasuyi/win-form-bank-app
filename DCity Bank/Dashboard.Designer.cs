namespace DCity_Bank
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deposit_remark_txt = new System.Windows.Forms.RichTextBox();
            this.deposit_acc_text = new System.Windows.Forms.TextBox();
            this.deposit_Amount_txt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.withdrawal_acount_type = new System.Windows.Forms.ComboBox();
            this.withdrawal_amnt_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.withdrawal_remak_txt = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.transf_recevr_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trans_cmb = new System.Windows.Forms.ComboBox();
            this.transf1_amnt_txt = new System.Windows.Forms.TextBox();
            this.transf_btn = new System.Windows.Forms.Button();
            this.tranfs_rmk_txt = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sttmt_list = new System.Windows.Forms.ListView();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Desc = new System.Windows.Forms.ColumnHeader();
            this.Account = new System.Windows.Forms.ColumnHeader();
            this.sttmnt_cmb = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Saving_acc_balance_lbl = new System.Windows.Forms.Label();
            this.Current_acc_balance_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 543);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 554);
            this.panel2.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(72, 486);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(26, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 28);
            this.label13.TabIndex = 32;
            this.label13.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(26, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 33;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(25, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Account Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(26, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 31;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(25, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(26, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, -68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 329);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(233, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(532, 543);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.deposit_btn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.deposit_remark_txt);
            this.tabPage1.Controls.Add(this.deposit_acc_text);
            this.tabPage1.Controls.Add(this.deposit_Amount_txt);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(524, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remark";
            // 
            // deposit_btn
            // 
            this.deposit_btn.BackColor = System.Drawing.Color.DimGray;
            this.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_btn.ForeColor = System.Drawing.Color.White;
            this.deposit_btn.Location = new System.Drawing.Point(337, 218);
            this.deposit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(112, 28);
            this.deposit_btn.TabIndex = 12;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = false;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(45, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Deposit Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account Number";
            // 
            // deposit_remark_txt
            // 
            this.deposit_remark_txt.Location = new System.Drawing.Point(192, 108);
            this.deposit_remark_txt.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_remark_txt.Name = "deposit_remark_txt";
            this.deposit_remark_txt.Size = new System.Drawing.Size(257, 88);
            this.deposit_remark_txt.TabIndex = 13;
            this.deposit_remark_txt.Text = "";
            this.deposit_remark_txt.TextChanged += new System.EventHandler(this.deposit_remark_txt_TextChanged);
            // 
            // deposit_acc_text
            // 
            this.deposit_acc_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deposit_acc_text.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deposit_acc_text.Location = new System.Drawing.Point(192, 62);
            this.deposit_acc_text.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_acc_text.Name = "deposit_acc_text";
            this.deposit_acc_text.Size = new System.Drawing.Size(257, 25);
            this.deposit_acc_text.TabIndex = 12;
            // 
            // deposit_Amount_txt
            // 
            this.deposit_Amount_txt.BackColor = System.Drawing.Color.White;
            this.deposit_Amount_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deposit_Amount_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deposit_Amount_txt.Location = new System.Drawing.Point(192, 23);
            this.deposit_Amount_txt.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_Amount_txt.Name = "deposit_Amount_txt";
            this.deposit_Amount_txt.Size = new System.Drawing.Size(257, 25);
            this.deposit_Amount_txt.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.withdrawal_acount_type);
            this.tabPage2.Controls.Add(this.withdrawal_amnt_txt);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.withdrawal_remak_txt);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(524, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Withdraw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(118, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Enter Amount";
            // 
            // withdrawal_acount_type
            // 
            this.withdrawal_acount_type.FormattingEnabled = true;
            this.withdrawal_acount_type.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.withdrawal_acount_type.Location = new System.Drawing.Point(114, 31);
            this.withdrawal_acount_type.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawal_acount_type.Name = "withdrawal_acount_type";
            this.withdrawal_acount_type.Size = new System.Drawing.Size(302, 23);
            this.withdrawal_acount_type.TabIndex = 20;
            this.withdrawal_acount_type.Text = "Select Account ";
            // 
            // withdrawal_amnt_txt
            // 
            this.withdrawal_amnt_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.withdrawal_amnt_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawal_amnt_txt.Location = new System.Drawing.Point(225, 79);
            this.withdrawal_amnt_txt.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawal_amnt_txt.Name = "withdrawal_amnt_txt";
            this.withdrawal_amnt_txt.Size = new System.Drawing.Size(190, 25);
            this.withdrawal_amnt_txt.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(304, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // withdrawal_remak_txt
            // 
            this.withdrawal_remak_txt.Location = new System.Drawing.Point(113, 129);
            this.withdrawal_remak_txt.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawal_remak_txt.Name = "withdrawal_remak_txt";
            this.withdrawal_remak_txt.Size = new System.Drawing.Size(302, 54);
            this.withdrawal_remak_txt.TabIndex = 17;
            this.withdrawal_remak_txt.Text = "";
            this.withdrawal_remak_txt.TextChanged += new System.EventHandler(this.withdrawal_remak_txt_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.transf_recevr_txt);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.trans_cmb);
            this.tabPage3.Controls.Add(this.transf1_amnt_txt);
            this.tabPage3.Controls.Add(this.transf_btn);
            this.tabPage3.Controls.Add(this.tranfs_rmk_txt);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(524, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transfer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(123, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Receiver\'s Account";
            // 
            // transf_recevr_txt
            // 
            this.transf_recevr_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transf_recevr_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transf_recevr_txt.Location = new System.Drawing.Point(234, 72);
            this.transf_recevr_txt.Margin = new System.Windows.Forms.Padding(2);
            this.transf_recevr_txt.Name = "transf_recevr_txt";
            this.transf_recevr_txt.Size = new System.Drawing.Size(190, 25);
            this.transf_recevr_txt.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(123, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enter Amount";
            // 
            // trans_cmb
            // 
            this.trans_cmb.FormattingEnabled = true;
            this.trans_cmb.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.trans_cmb.Location = new System.Drawing.Point(123, 31);
            this.trans_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.trans_cmb.Name = "trans_cmb";
            this.trans_cmb.Size = new System.Drawing.Size(302, 23);
            this.trans_cmb.TabIndex = 25;
            this.trans_cmb.Text = "Select Account ";
            // 
            // transf1_amnt_txt
            // 
            this.transf1_amnt_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transf1_amnt_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transf1_amnt_txt.Location = new System.Drawing.Point(235, 113);
            this.transf1_amnt_txt.Margin = new System.Windows.Forms.Padding(2);
            this.transf1_amnt_txt.Name = "transf1_amnt_txt";
            this.transf1_amnt_txt.Size = new System.Drawing.Size(190, 25);
            this.transf1_amnt_txt.TabIndex = 24;
            // 
            // transf_btn
            // 
            this.transf_btn.BackColor = System.Drawing.Color.DimGray;
            this.transf_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transf_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transf_btn.ForeColor = System.Drawing.Color.White;
            this.transf_btn.Location = new System.Drawing.Point(313, 232);
            this.transf_btn.Margin = new System.Windows.Forms.Padding(2);
            this.transf_btn.Name = "transf_btn";
            this.transf_btn.Size = new System.Drawing.Size(112, 28);
            this.transf_btn.TabIndex = 22;
            this.transf_btn.Text = "Transfer";
            this.transf_btn.UseVisualStyleBackColor = false;
            this.transf_btn.Click += new System.EventHandler(this.transf_btn_Click);
            // 
            // tranfs_rmk_txt
            // 
            this.tranfs_rmk_txt.Location = new System.Drawing.Point(123, 160);
            this.tranfs_rmk_txt.Margin = new System.Windows.Forms.Padding(2);
            this.tranfs_rmk_txt.Name = "tranfs_rmk_txt";
            this.tranfs_rmk_txt.Size = new System.Drawing.Size(302, 54);
            this.tranfs_rmk_txt.TabIndex = 21;
            this.tranfs_rmk_txt.Text = "";
            this.tranfs_rmk_txt.TextChanged += new System.EventHandler(this.tranfs_rmk_txt_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage4.Controls.Add(this.sttmt_list);
            this.tabPage4.Controls.Add(this.sttmnt_cmb);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(524, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statement";
            // 
            // sttmt_list
            // 
            this.sttmt_list.BackColor = System.Drawing.Color.DimGray;
            this.sttmt_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Amount,
            this.Desc,
            this.Account});
            this.sttmt_list.HideSelection = false;
            this.sttmt_list.Location = new System.Drawing.Point(57, 59);
            this.sttmt_list.Margin = new System.Windows.Forms.Padding(2);
            this.sttmt_list.Name = "sttmt_list";
            this.sttmt_list.Size = new System.Drawing.Size(425, 164);
            this.sttmt_list.TabIndex = 24;
            this.sttmt_list.UseCompatibleStateImageBehavior = false;
            this.sttmt_list.View = System.Windows.Forms.View.Details;
            this.sttmt_list.SelectedIndexChanged += new System.EventHandler(this.sttmt_list_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 150;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 150;
            // 
            // Desc
            // 
            this.Desc.Text = "Description ";
            this.Desc.Width = 150;
            // 
            // Account
            // 
            this.Account.Text = "Account";
            this.Account.Width = 150;
            // 
            // sttmnt_cmb
            // 
            this.sttmnt_cmb.FormattingEnabled = true;
            this.sttmnt_cmb.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.sttmnt_cmb.Location = new System.Drawing.Point(57, 15);
            this.sttmnt_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.sttmnt_cmb.Name = "sttmnt_cmb";
            this.sttmnt_cmb.Size = new System.Drawing.Size(203, 23);
            this.sttmnt_cmb.TabIndex = 21;
            this.sttmnt_cmb.Text = "Select Account ";
            this.sttmnt_cmb.SelectedIndexChanged += new System.EventHandler(this.sttmnt_cmb_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage5.Controls.Add(this.Saving_acc_balance_lbl);
            this.tabPage5.Controls.Add(this.Current_acc_balance_lbl);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(524, 512);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Balance";
            // 
            // Saving_acc_balance_lbl
            // 
            this.Saving_acc_balance_lbl.AutoSize = true;
            this.Saving_acc_balance_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Saving_acc_balance_lbl.ForeColor = System.Drawing.Color.Black;
            this.Saving_acc_balance_lbl.Location = new System.Drawing.Point(160, 38);
            this.Saving_acc_balance_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Saving_acc_balance_lbl.Name = "Saving_acc_balance_lbl";
            this.Saving_acc_balance_lbl.Size = new System.Drawing.Size(14, 13);
            this.Saving_acc_balance_lbl.TabIndex = 22;
            this.Saving_acc_balance_lbl.Text = "#";
            this.Saving_acc_balance_lbl.Click += new System.EventHandler(this.Saving_acc_balance_lbl_Click);
            // 
            // Current_acc_balance_lbl
            // 
            this.Current_acc_balance_lbl.AutoSize = true;
            this.Current_acc_balance_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current_acc_balance_lbl.ForeColor = System.Drawing.Color.Black;
            this.Current_acc_balance_lbl.Location = new System.Drawing.Point(160, 85);
            this.Current_acc_balance_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Current_acc_balance_lbl.Name = "Current_acc_balance_lbl";
            this.Current_acc_balance_lbl.Size = new System.Drawing.Size(14, 13);
            this.Current_acc_balance_lbl.TabIndex = 21;
            this.Current_acc_balance_lbl.Text = "#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(29, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "CURRENT ACCOUNT:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(156, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Refresh Balance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "SAVING ACCOUNT:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 536);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox deposit_remark_txt;
        private System.Windows.Forms.TextBox deposit_Amount_txt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox withdrawal_acount_type;
        private System.Windows.Forms.TextBox withdrawal_amnt_txt;
        private System.Windows.Forms.RichTextBox withdrawal_remak_txt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox transf_recevr_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox trans_cmb;
        private System.Windows.Forms.TextBox transf1_amnt_txt;
        private System.Windows.Forms.Button transf_btn;
        private System.Windows.Forms.RichTextBox tranfs_rmk_txt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView sttmt_list;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Account;
        private System.Windows.Forms.ComboBox sttmnt_cmb;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label Saving_acc_balance_lbl;
        private System.Windows.Forms.Label Current_acc_balance_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deposit_acc_text;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}