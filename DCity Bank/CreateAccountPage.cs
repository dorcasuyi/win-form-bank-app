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
    public partial class CreateAccountPage : Form
    {

        private IUserAuthentication _userAuthentication;
        private IUserRegistration userRegistration;
        private IAccountRepo _accountRepo;
        private IUserRepos userRepos;
        private IWriteandRead writeandRead;
        private ITransactionepo transactionepo;
        public CreateAccountPage(IUserAuthentication _userAuthentication, IUserRegistration userRegistration, IAccountRepo _accountRepo, IWriteandRead writeandRead, ITransactionepo transactionepo, IUserRepos userRepos)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> CustomerDetails = new List<string>();

            CustomerDetails.Add(textBox1.Text);
            CustomerDetails.Add(textBox2.Text);
            CustomerDetails.Add(textBox3.Text);
            CustomerDetails.Add(textBox4.Text);

            string acctype = "";
            bool ischecked = radioButton1.Checked;
            if(ischecked)
            {
                acctype = radioButton1.Text;
            }
            else
            {
                acctype = radioButton2.Text;
            }

            string initialDeposit = "0";

            string customerID = userRepos.Add_NewCustomer(CustomerDetails);
            if(customerID != "ERROR:")
            {
                if(_accountRepo.CreatNewAccount(customerID, initialDeposit, acctype))
                {
                    string CustomerData = userRepos.GetCustomerDetails(customerID);
                    string CustomerEmail = CustomerData.Split(",")[3];
                    _userAuthentication.SetLog(CustomerEmail);

                    MessageBox.Show("Congratulations Your Account Has Been Created, Click Ok To Go To Your Dashboard");
                    Dashboard dashboard = new Dashboard(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
                    dashboard.Show();
                    this.Hide();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
            login.Show();
        }
    }
}
