using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffiHelman
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Сложение точек P != Q \n   L = (y2 - y1) / (x2-x1) mod p \n   x3 = L^2 - x1 - x2 mod p \n   y3 = L * (x1 - x3) - y1 mod p \n Удвоение точек 2P\n   L = (3 * x^2 + a) / ( 2 * y1) mod p\n   x3 = L^2 - 2 * x1 mod p\n   y3 = L * (x1 - x3) - y1 mod p";
        }
    }
}
