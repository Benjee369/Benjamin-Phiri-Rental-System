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

namespace Benjamin_Phiri_DDOOCP
{
    public partial class AvailableProducts : Form
    {
        public AvailableProducts()
        {
            InitializeComponent();
        }

        private void cmdShowP_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserSignedIn form1 = new UserSignedIn();
            this.Hide();
            form1.Show();
        }
    }
}
