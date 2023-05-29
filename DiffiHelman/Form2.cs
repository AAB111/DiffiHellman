using System;
using System.Windows.Forms;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DiffiHelman
{
    internal partial class Form2 : Form
    {
        internal EllipCurves curves;
        internal Form2(EllipCurves curves)
        {
            InitializeComponent();
            this.curves = curves;
            chart1.Titles.Add($"График y^2 = x^3+{curves.A}*x+{curves.B} mod{curves.p}");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<uint> x = new List<uint>();
            List<uint> y = new List<uint>();

            for (long i = 0; i < curves.p; i++)
            {
                x.Add(curves.Right(i));
                y.Add(curves.Left(i));
            }
            for (int i = 0; i < x.Count; i++)
            {
                var Y = y.Select((element, index) => new KeyValuePair<uint, int>(element, index)).Where((elem) => elem.Key == x[i]).Select((element) => element.Value).ToList();
                Y.ForEach((elem) => chart1.Series[0].Points.AddXY(i, elem));
                    
            }
        }
    }
}
