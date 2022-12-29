using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benjamin_Phiri_DDOOCP
{
    public partial class AdminSignedIn : Form
    {
        public AdminSignedIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DeleteItem form1 = new DeleteItem();
            this.Hide();
            form1.Show();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddItem form1 = new AddItem();
            this.Hide();
            form1.Show();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            UpdateItem form1 = new UpdateItem();
            this.Hide();
            form1.Show();
        }
    }
}
