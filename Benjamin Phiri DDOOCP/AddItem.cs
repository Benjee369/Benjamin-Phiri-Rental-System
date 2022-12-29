using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Benjamin_Phiri_DDOOCP
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblPU_Click(object sender, EventArgs e)
        {

        }

        private void cmdAddI_Click(object sender, EventArgs e)
        {
            if(txtAppl.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Appliance Name");
            }
            else if(txtPU.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Power Usage");
            }
            else if(txtTU.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Typical Usage");
            }
            else if(txtRFM.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Rent Fee/Month");
            }
            else
            {
                SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Benjamin Phiri DDOOCP\Benjamin Phiri DDOOCP\bin\ddoocp.db");
                string ApplianceName = txtAppl.Text;
                string PowerUsage = txtPU.Text;
                string TypicalUsage = txtTU.Text;
                string RentFeePerMonth = txtRFM.Text;
                string query;

                conn.Open();
                query = "INSERT into[Products]([Appliance],[Power_Usage],[Typical_Usage],[Fee_per_Month])" +
                    "VAlUES('" + ApplianceName + "','" + PowerUsage + "','" + TypicalUsage + "','" + RentFeePerMonth + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Added");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSignedIn form1 = new AdminSignedIn();
            this.Hide();
            form1.Show();
        }

        private void cmdSI_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Benjamin Phiri DDOOCP\Benjamin Phiri DDOOCP\bin\ddoocp.db");
            conn.Open();
            string query = "SELECT * FROM Products";
            SQLiteCommand CMD = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(CMD);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
