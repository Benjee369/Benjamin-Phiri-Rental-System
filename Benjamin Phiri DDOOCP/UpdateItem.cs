using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Benjamin_Phiri_DDOOCP
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSignedIn form1 = new AdminSignedIn();
            this.Hide();
            form1.Show();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void something(string txtAID)
        {
            string AppID = dataGridView1.Rows[2].Cells[4].Value.ToString();

            if (AppID == "")
            {
                MessageBox.Show("Enter valid ApplianceID");
            }
        }
        private void cmdAddI_Click(object sender, EventArgs e)
        {

            //if (something = "")
            //{

            //}
            if (txtAID.Text == string.Empty)
            {
                MessageBox.Show("Please enter ApplianceID");
            }
            else if (txtAppl.Text == string.Empty)
            {
                MessageBox.Show("Enter new Appliance Name");
            }
            else if (txtPU.Text == string.Empty)
            {
                MessageBox.Show("Enter new Power Usage");
            }
            else if (txtTU.Text == string.Empty)
            {
                MessageBox.Show("Enter new Typical Usage");
            }   
            else if (txtRFM.Text == string.Empty)
            {
                MessageBox.Show("Enter Rent Fee/Month");
            }
            else
            {
                
                    SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\Benjamin\OneDrive\Documents\School Shit\Assignments\ass\Benjamin Phiri DDOOCP\Benjamin Phiri DDOOCP\bin\ddoocp.db");
                    conn.Open();
                    string query = "UPDATE Products SET Appliance = '" + txtAppl.Text + "', Power_Usage = '" + txtPU.Text + "', Typical_Usage = '" + txtTU.Text + "', Fee_per_Month = '" + txtRFM.Text + "' " +
                        "WHERE ApplianceID = '" + txtAID.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Updated");
                    conn.Close();
               
             
            }
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
