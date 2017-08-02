using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FrmStorage : Form
    {
        // variable declarations
        int age;
        string yourName;
        double pay;

        public FrmStorage()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            // assignments
            age = 43;
            yourName = "AJ Speller";
            pay = 134.77;

            // display results
            MessageBox.Show("Your age is " + age.ToString());
            MessageBox.Show("Your name is " + yourName);
            MessageBox.Show("Your pay is " + pay.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is " + yourName);

        }
    }
}
