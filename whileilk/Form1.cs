using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileilk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int toplam = 0;
            int deger=0;
            while (i <20)                
            {
                deger = Convert.ToInt32(listBox1.Items[i]);
                toplam = toplam +deger ;
                i++;
            }
            MessageBox.Show("Döngü toplam "+toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
