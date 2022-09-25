using DCity_Bank_Core.Interface;
using Models;
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
    public partial class Dashboard : Form
    {

        private IUserAuthentication _userAuthentication;
        private IUserRegistration userRegistration;
        private IAccountRepo _accountRepo;
        private IUserRepos userRepos;
        private IWriteandRead writeandRead;
        private ITransactionepo transactionepo;
        public Dashboard(IUserAuthentication _userAuthentication, IUserRegistration userRegistration, IAccountRepo _accountRepo, IWriteandRead writeandRead, ITransactionepo transactionepo, IUserRepos userRepos)
        {
            InitializeComponent();
            this._userAuthentication = _userAuthentication;
            this.transactionepo = transactionepo;
            this.userRegistration = userRegistration;
            this.userRepos = userRepos;
            this.writeandRead = writeandRead;
            this._accountRepo = _accountRepo;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void deposit_remark_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tranfs_rmk_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void withdrawal_remak_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string path = Filepath.LogInSessionPath;
            list = writeandRead.readFile(path);
            string line = list[list.Count - 1];

            string Id = line.Split(",")[0];
            string firstname = line.Split(",")[1];
            string lastname = line.Split(",")[2];
            string email = line.Split(",")[3];
            string phonenumber = line.Split(",")[4];

            label14.Text = firstname + "," + lastname;

            List<string> accdits = new List<string>();
            accdits = _accountRepo.getAccountByID(Id);

            foreach(var acc in accdits)
            {
                string acctype = acc.Split(",")[5];

                if(acctype == "Current")
                {
                    label5.Text = "Current";
                    label8.Text = acc.Split(",")[4];
                }
                else
                {
                    label5.Text = "Savings";
                    label8.Text = acc.Split(",")[4];
                }
            }
        }

        private void sttmt_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deposit_btn_Click_1(object sender, EventArgs e)
        {
            if (deposit_Amount_txt.Text == "")
            {
                MessageBox.Show("Please Enter an Amount");
                deposit_Amount_txt.Focus();
            }
            else if(deposit_acc_text.Text == "")
            {
                MessageBox.Show("Please Enter your account Number");
                deposit_acc_text.Focus();
            }
            else if (deposit_Amount_txt.Text == "0")
            {
                MessageBox.Show("Deposit Amount is too small");
                deposit_Amount_txt.Focus();
            }
            else
            {
                string accNumber = deposit_acc_text.Text;
                string accsetails = _accountRepo.confirmAccount(accNumber);
                if(accsetails != "")
                {

                    if (MessageBox.Show($"Confirm Deposit of {deposit_Amount_txt.Text}", "Deposit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Useracc = deposit_acc_text.Text;
                        string amount = deposit_Amount_txt.Text;
                        string remark = deposit_remark_txt.Text;

                        if (transactionepo.DepsoitToAccount(Useracc, amount, remark))
                        {
                            MessageBox.Show("Deposit was Successful");
                            deposit_Amount_txt.Text = "";
                            deposit_acc_text.Text = "";
                            deposit_remark_txt.Text = "";
                            deposit_Amount_txt.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Inavlid Account number try with a valid accNumber");
                    deposit_acc_text.Focus();

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acctype = withdrawal_acount_type.Text;
            string amount = withdrawal_amnt_txt.Text;
            string remark = withdrawal_remak_txt.Text;

            string ID = _userAuthentication.GetLoginCustomerByID();

            if(acctype != "Savings" && acctype != "Current")
            {
                MessageBox.Show("Invalid Account type Selection");
                withdrawal_acount_type.Focus();
            }
            else if(amount == "0")
            {
                MessageBox.Show("input amount greater then 0");
                withdrawal_amnt_txt.Focus();
            }
            else if(amount == "")
            {
                MessageBox.Show("Input an amount");
                withdrawal_amnt_txt.Focus();
            }
            else
            {
                decimal balance = _accountRepo.checkBalance(ID, acctype);
                decimal amountToWithdraw = decimal.Parse(amount);

                if(balance < amountToWithdraw)
                {
                    MessageBox.Show("Insufficient Balance");
                }
                if((balance - amountToWithdraw) < 1000)
                {
                    MessageBox.Show("Insufficient Balance, the minimum Balance is #1000");
                }
                else
                {
                    amount = "-" + amount;
                    amountToWithdraw = decimal.Parse(amount);

                    if(transactionepo.Withdraw(ID,amountToWithdraw ,remark, acctype))
                    {
                        MessageBox.Show("Withdrawal was Successful");
                        withdrawal_amnt_txt.Text = "";
                        withdrawal_remak_txt.Text = "";
                        withdrawal_acount_type.Text = "Select Account";
                    }
                }
            }
        }

        private void transf_btn_Click(object sender, EventArgs e)
        {
            //getting costumer id
            List<string> data = new List<string>();
            string path = Filepath.LogInSessionPath;
            data = writeandRead.readFile(path);
            string line = data[data.Count - 1];
            string id = line.Split(",")[0];

            //verifying input
            if (trans_cmb.Text != "Savings" && trans_cmb.Text != "Current Account")
            { MessageBox.Show("Please select the account you want to transfer from"); }
            else if (transf_recevr_txt.Text == "") { MessageBox.Show("please enter the receiver's account number"); transf_recevr_txt.Focus(); }
            else if (transf1_amnt_txt.Text == "") { MessageBox.Show("please enter the amount you want to transfer"); transf1_amnt_txt.Focus(); }
            else if (transf1_amnt_txt.Text == "0") { MessageBox.Show("The transfer amount is too small"); transf1_amnt_txt.Focus(); }
            else if (tranfs_rmk_txt.Text == "") { MessageBox.Show("please enter a narrative"); tranfs_rmk_txt.Focus(); }


            //input is OK!
            else
            {
                decimal balance = _accountRepo.checkBalance(id, trans_cmb.Text);
                decimal amountToTransfer = decimal.Parse(transf1_amnt_txt.Text);
                // restricting minimum balance
                if (trans_cmb.Text == "Savings" && (balance - amountToTransfer) <= 1000)
                {
                    MessageBox.Show("Unable to transfer the minimum balance for savings account is 1000 Naira");
                    transf1_amnt_txt.Focus();
                }
                else if (balance < amountToTransfer)
                {
                    MessageBox.Show("Unable to transfer Insufficient Balance");
                    transf1_amnt_txt.Focus();
                }
                else
                {
                    if (MessageBox.Show($"Confirm the transfer of {transf1_amnt_txt.Text} to {transf_recevr_txt.Text}", "Transfer Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string respond = transactionepo.transfer(id, transf_recevr_txt.Text, amountToTransfer, tranfs_rmk_txt.Text, trans_cmb.Text);
                        if (respond == "OK")
                        {
                            MessageBox.Show("Transfer was successful ");
                            trans_cmb.Text = "";
                            transf_recevr_txt.Text = "";
                            transf1_amnt_txt.Text = "";
                            tranfs_rmk_txt.Text = "";
                            trans_cmb.Focus();
                        }
                        else
                        {
                            MessageBox.Show(respond);
                        }
                    }

                }

            }
        }

        private void prnt_sttmnt_btn_Click(object sender, EventArgs e)
        {

        }

        private void sttmnt_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string path = Filepath.LogInSessionPath;
            list = writeandRead.readFile(path);
            string dataLine = list[list.Count - 1];
            string ID = dataLine.Split(",")[0];
            string accType = sttmnt_cmb.Text;
            string statement = "";
            list.Clear();

            list = transactionepo.AccountStatement(ID, accType);

            List<string> list2 = new List<string> { "boy", "girl" };

            if (list[0] == list2[0])
            {
                MessageBox.Show($"You Do not have a {accType}  Account");
            }
            else
            {
                foreach(var item in list)
                {
                    sttmt_list.Items.Add(new ListViewItem(new string[] { item.Split(",")[3], item.Split(",")[2], item.Split(",")[4], item.Split(",")[1] }));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            string path = Filepath.LogInSessionPath;
            data = writeandRead.readFile(path);
            string line = data[data.Count - 1];
            //getting logged in costumer email
            string id = line.Split(",")[0]; ;
            //showing balance
            decimal savingbalance = _accountRepo.checkBalance(id, "Savings");
            decimal currentbalance = _accountRepo.checkBalance(id, "Current");
            Saving_acc_balance_lbl.Text = savingbalance.ToString();
            Current_acc_balance_lbl.Text = currentbalance.ToString();
        }

        private void Saving_acc_balance_lbl_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want to Logout", " Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login newhome = new Login(_userAuthentication, userRegistration, _accountRepo, writeandRead, transactionepo, userRepos);
                this.Hide();
                newhome.Show();
            }
        }
    }
}
