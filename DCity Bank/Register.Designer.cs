namespace DCity_Bank
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.darklogopictureBox = new System.Windows.Forms.PictureBox();
            this.slogandarklabel1 = new System.Windows.Forms.Label();
            this.existingUserlabel1 = new System.Windows.Forms.Label();
            this.signinlinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.logintoexistingaccountlabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.fillpersonaldetailsLabel = new System.Windows.Forms.Label();
            this.emailtextBox2 = new System.Windows.Forms.TextBox();
            this.emailLabel2 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.passwordlabel2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.darklogopictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darklogopictureBox
            // 
            this.darklogopictureBox.BackColor = System.Drawing.Color.DarkOrange;
            this.darklogopictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("darklogopictureBox.BackgroundImage")));
            this.darklogopictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.darklogopictureBox.Location = new System.Drawing.Point(-3, -59);
            this.darklogopictureBox.Name = "darklogopictureBox";
            this.darklogopictureBox.Size = new System.Drawing.Size(314, 538);
            this.darklogopictureBox.TabIndex = 0;
            this.darklogopictureBox.TabStop = false;
            this.darklogopictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // slogandarklabel1
            // 
            this.slogandarklabel1.AutoSize = true;
            this.slogandarklabel1.BackColor = System.Drawing.Color.DarkOrange;
            this.slogandarklabel1.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.slogandarklabel1.ForeColor = System.Drawing.Color.Black;
            this.slogandarklabel1.Location = new System.Drawing.Point(85, 281);
            this.slogandarklabel1.Name = "slogandarklabel1";
            this.slogandarklabel1.Size = new System.Drawing.Size(136, 26);
            this.slogandarklabel1.TabIndex = 1;
            this.slogandarklabel1.Text = "...my bank and i";
            this.slogandarklabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // existingUserlabel1
            // 
            this.existingUserlabel1.AutoSize = true;
            this.existingUserlabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.existingUserlabel1.ForeColor = System.Drawing.Color.White;
            this.existingUserlabel1.Location = new System.Drawing.Point(401, 380);
            this.existingUserlabel1.Name = "existingUserlabel1";
            this.existingUserlabel1.Size = new System.Drawing.Size(102, 15);
            this.existingUserlabel1.TabIndex = 23;
            this.existingUserlabel1.Text = "Existing customer?";
            // 
            // signinlinkLabel1
            // 
            this.signinlinkLabel1.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.signinlinkLabel1.AutoSize = true;
            this.signinlinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.signinlinkLabel1.Location = new System.Drawing.Point(651, 380);
            this.signinlinkLabel1.Name = "signinlinkLabel1";
            this.signinlinkLabel1.Size = new System.Drawing.Size(69, 15);
            this.signinlinkLabel1.TabIndex = 22;
            this.signinlinkLabel1.TabStop = true;
            this.signinlinkLabel1.Text = "Home Page";
            this.signinlinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signinlinkLabel1_LinkClicked);
            // 
            // logintoexistingaccountlabel
            // 
            this.logintoexistingaccountlabel.AutoSize = true;
            this.logintoexistingaccountlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.logintoexistingaccountlabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.logintoexistingaccountlabel.Location = new System.Drawing.Point(509, 380);
            this.logintoexistingaccountlabel.Name = "logintoexistingaccountlabel";
            this.logintoexistingaccountlabel.Size = new System.Drawing.Size(136, 15);
            this.logintoexistingaccountlabel.TabIndex = 21;
            this.logintoexistingaccountlabel.Text = "Login to existing account";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.DimGray;
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(310, 308);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(75, 27);
            this.signupButton.TabIndex = 20;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // fillpersonaldetailsLabel
            // 
            this.fillpersonaldetailsLabel.AutoSize = true;
            this.fillpersonaldetailsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.fillpersonaldetailsLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.fillpersonaldetailsLabel.Location = new System.Drawing.Point(396, 138);
            this.fillpersonaldetailsLabel.Name = "fillpersonaldetailsLabel";
            this.fillpersonaldetailsLabel.Size = new System.Drawing.Size(182, 15);
            this.fillpersonaldetailsLabel.TabIndex = 19;
            this.fillpersonaldetailsLabel.Text = "Please fill in your personal details";
            // 
            // emailtextBox2
            // 
            this.emailtextBox2.Location = new System.Drawing.Point(191, 204);
            this.emailtextBox2.Name = "emailtextBox2";
            this.emailtextBox2.Size = new System.Drawing.Size(194, 23);
            this.emailtextBox2.TabIndex = 18;
            // 
            // emailLabel2
            // 
            this.emailLabel2.AutoSize = true;
            this.emailLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.emailLabel2.Location = new System.Drawing.Point(83, 204);
            this.emailLabel2.Name = "emailLabel2";
            this.emailLabel2.Size = new System.Drawing.Size(46, 20);
            this.emailLabel2.TabIndex = 16;
            this.emailLabel2.Text = "Email";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.welcomeLabel.Location = new System.Drawing.Point(396, 91);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(89, 21);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "WELCOME";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeBackLabel_Click);
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Location = new System.Drawing.Point(191, 263);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(194, 23);
            this.passwordtextBox2.TabIndex = 25;
            // 
            // passwordlabel2
            // 
            this.passwordlabel2.AutoSize = true;
            this.passwordlabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordlabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.passwordlabel2.Location = new System.Drawing.Point(83, 263);
            this.passwordlabel2.Name = "passwordlabel2";
            this.passwordlabel2.Size = new System.Drawing.Size(73, 20);
            this.passwordlabel2.TabIndex = 24;
            this.passwordlabel2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordtextBox2);
            this.panel1.Controls.Add(this.signupButton);
            this.panel1.Controls.Add(this.passwordlabel2);
            this.panel1.Controls.Add(this.emailLabel2);
            this.panel1.Controls.Add(this.emailtextBox2);
            this.panel1.Location = new System.Drawing.Point(309, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 456);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 453);
            this.panel2.TabIndex = 27;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.existingUserlabel1);
            this.Controls.Add(this.signinlinkLabel1);
            this.Controls.Add(this.logintoexistingaccountlabel);
            this.Controls.Add(this.fillpersonaldetailsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.slogandarklabel1);
            this.Controls.Add(this.darklogopictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.darklogopictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox darklogopictureBox;
        private System.Windows.Forms.Label slogandarklabel1;
        private System.Windows.Forms.Label existingUserlabel1;
        private System.Windows.Forms.LinkLabel signinlinkLabel1;
        private System.Windows.Forms.Label logintoexistingaccountlabel;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label fillpersonaldetailsLabel;
        private System.Windows.Forms.TextBox emailtextBox2;
        private System.Windows.Forms.Label emailLabel2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.Label passwordlabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}