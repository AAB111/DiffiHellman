using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffiHelman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal EllipCurves Curves { get; private set; }
        internal DiffiHellman DH1 { get; private set; }
        internal DiffiHellman DH2 { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textbox_a.Text);
                int b = int.Parse(textbox_b.Text);
                int p = int.Parse(textbox_p.Text);
                uint c = uint.Parse(textbox_c.Text);
                uint d = uint.Parse(textbox_d.Text);
                (BigInteger, BigInteger) P = (BigInteger.Parse(textbox_x.Text), BigInteger.Parse(textbox_y.Text));
                Curves = new EllipCurves(a, b, p);
                DH1 = new DiffiHellman(Curves, c, P);
                DH2 = new DiffiHellman(Curves, d, P);
                (BigInteger, BigInteger) R = DH1.GetPartKey();
                (BigInteger, BigInteger) Q = DH2.GetPartKey();
                (BigInteger, BigInteger) S1 = DH1.GetFullKey(Q);
                (BigInteger, BigInteger) S2 = DH2.GetFullKey(R);
                label7.Text = $"S(x = {S1.Item1} ; y = {S1.Item2})\n" + $"R(x = {R.Item1}, y = {R.Item2})";
                label9.Text = $"S(x = {S2.Item1} ; y = {S2.Item2})\n" + $"Q(x = {Q.Item1}, y = {Q.Item2})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(textbox_a.Text);
                int b = int.Parse(textbox_b.Text);
                int p = int.Parse(textbox_p.Text);
                Curves = new EllipCurves(a, b, p);
                new Form2(Curves).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
