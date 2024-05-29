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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form2 f2;
        private void button2_Click(object sender, EventArgs e)
        {
            f2= new Form2();
            f2.ShowDialog();
        }

        Form3 f3;
        private void button1_Click(object sender, EventArgs e)
        {
            f3= new Form3();
            f3.ShowDialog();
        }
    }
}
