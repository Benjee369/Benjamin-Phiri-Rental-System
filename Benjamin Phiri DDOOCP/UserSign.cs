using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 

namespace Benjamin_Phiri_DDOOCP
{
    public partial class UserSign : Form
    {
        public UserSign()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        public void SignIn()
        {
            string query = "SELECT * FROM Customers WHERE UserName = @Admin AND Password = @Admin123";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Benjamin Phiri DDOOCP\Benjamin Phiri DDOOCP\bin\ddoocp.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Admin", txtUserN.Text);
            cmd.Parameters.AddWithValue("@Admin123", txtPass.Text);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Successfully Logged In as Admin");
                AdminSignedIn form1 = new AdminSignedIn();
                this.Hide();
                form1.Show();
            }
        }

        private void cmdUS_SignIn_Click(object sender, EventArgs e)
        {
            txtUserN.Focus();
            if (txtUserN.Text.Trim() == "" && txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Details");
            }
            else if (txtUserN.Text.Trim() == "Admin" && txtPass.Text.Trim() == "Admin123")
            {
                SignIn();
            }
            else
            {
                string query = "SELECT * FROM Customers WHERE UserName = @username AND Password = @password";
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Eh ndatope\Eh ndatope\bin\ddoocp.db");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", txtUserN.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully Logged In");
                    UserSignedIn form1 = new UserSignedIn();
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customers WHERE UserName = @username AND Password = @password";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Eh ndatope\Eh ndatope\bin\ddoocp.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", txtUserN.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully Logged In");
                UserSignedIn form1 = new UserSignedIn();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Invalid login details");
            }
        }
    }
}
