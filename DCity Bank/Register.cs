using DCity_Bank_Core.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCity_Bank
{
    public partial class Register : Form
    {

        private IUserAuthentication _userAuthentication;
        private IUserRegistration userRegistration;
        private IAccountRepo _accountRepo;
        private IUserRepos userRepos;
        private IWriteandRead writeandRead;
        private ITransactionepo transactionepo;
        public Register(IUserAuthentication _userAuthentication, IUserRegistration userRegistration, IAccountRepo _accountRepo, IWriteandRead writeandRead, ITransactionepo transactionepo, IUserRepos userRepos)
        {
            InitializeComponent();
            this._userAuthentication = _userAuthentication;
            this.transactionepo = transactionepo;
            this.userRegistration = userRegistration;
            this.userRepos = userRepos;
            this.writeandRead = writeandRead;
            this._accountRepo = _accountRepo;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeBackLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string RegisterEmail = emailtextBox2.Text;
            string RegisterPassword = passwordtextBox2.Text;

            string message = userRegistration.RegisterCustomer(RegisterEmail, RegisterPassword);

            if(message != "OK")
            {
                MessageBox.Show(message);
                emailtextBox2.Text = "";
                emailtextBox2.Focus();
            }
            else
            {
                this.Hide();
                CreateAccountPage createAccountPage = new CreateAccountPage(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
                createAccountPage.Show();
            }
        }

        private void emailLabel1_Click(object sender, EventArgs e)
        {

        }

        private void signinlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
            login.Show();    
        }
    }
}
