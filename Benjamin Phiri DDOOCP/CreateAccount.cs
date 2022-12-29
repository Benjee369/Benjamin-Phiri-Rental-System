using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Benjamin_Phiri_DDOOCP
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Benjamin Phiri DDOOCP\Benjamin Phiri DDOOCP\bin\ddoocp.db");
                string FirstName = txtUserN.Text;
                string LastName = txtLastN.Text;
                string Username = txtUserN.Text;
                string EmailAddress = txtEmail.Text;
                string Password = txtPass.Text;
                string CPassword = txtCPass.Text;
                string query;
               
                    if (txtFirstN.Text == string.Empty)
                    {
                        MessageBox.Show("PLease Enter Details");
                    }
                    else if(txtUserN.Text == string.Empty)
                    {
                    MessageBox.Show("Please Enter User Name");
                    }
                    else if(txtEmail.Text == string.Empty)
                    {
                    MessageBox.Show("Please Enter Email Address");
                    }
                    else if (txtPass.Text == string.Empty)
                    {
                    MessageBox.Show("Please Enter Password");
                    }
                    else if(txtCPass.Text == string.Empty)
                    {
                    MessageBox.Show("Please Confirm Password");
                    }
                    else
                    {
                        if (txtPass.Text == txtCPass.Text)
                        {
                            if(txtPass.Text.Length < 8 && txtCPass.Text.Length < 8)
                            {
                               MessageBox.Show("Password Is Too Short");
                            }
                            else
                            {
                                conn.Open();
                                query = "INSERT into[Customers]([FirstName],[LastName],[UserName],[EmailAddress],[Password],[ConfirmPassword])" +
                                    "VAlUES('" + FirstName + "','" + LastName + "','" + Username + "','" + EmailAddress + "','" + Password + "','" + CPassword + "')";
                                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Account Succesfully Created");
                                conn.Close();
                                new Form1().Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords Are Different");
                        }
                    }
            }
            else
            {
                MessageBox.Show("Please agree To the Terms and Conditions");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        private void lblCrtUs_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
