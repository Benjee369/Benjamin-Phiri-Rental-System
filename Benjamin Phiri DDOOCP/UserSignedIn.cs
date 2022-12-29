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
    public partial class UserSignedIn : Form
    {
        public UserSignedIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvailableProducts form1 = new AvailableProducts();
            this.Hide();
            form1.Show();
        }
    }
}
