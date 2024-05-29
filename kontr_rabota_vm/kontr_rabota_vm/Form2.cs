using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontr_rabota_vm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form1 f1;
        private void button4_Click(object sender, EventArgs e)
        {
            f1= new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
