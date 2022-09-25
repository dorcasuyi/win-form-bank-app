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
    public partial class Login : Form
    {
        private IUserAuthentication _userAuthentication;
        private IUserRegistration userRegistration;
        private IAccountRepo _accountRepo;
        private IUserRepos userRepos;
        private IWriteandRead writeandRead;
        private ITransactionepo transactionepo;
        public Login(IUserAuthentication _userAuthentication, IUserRegistration userRegistration, IAccountRepo _accountRepo, IWriteandRead writeandRead, ITransactionepo transactionepo, IUserRepos userRepos)
        {
            InitializeComponent();
            this._userAuthentication = _userAuthentication;
            this.transactionepo = transactionepo;
            this.userRegistration = userRegistration;
            this.userRepos = userRepos;
            this.writeandRead = writeandRead;
            this._accountRepo = _accountRepo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void newUserlabel1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string LoginEmail = emailtextBox1.Text;
            string LoginPass = passwordtxb1.Text;

            var CheckLogin = _userAuthentication.LogIn(LoginEmail, LoginPass);
            if(CheckLogin != "OK")
            {
                MessageBox.Show(CheckLogin);
            }
            else
            {
                _userAuthentication.SetLog(LoginEmail);
                Dashboard dashboard = new Dashboard(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
                dashboard.Show();
                this.Hide();
            }


        }

        private void signuplinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
            register.Show();
        }
    }
}
