using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSDemoGDI
{
    public partial class Form1 : Form
    {
        private DemosVisualesGDI _demosVisuales;
        public Form1()
        {
            InitializeComponent();
            _demosVisuales = new DemosVisualesGDI(picPantalla);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            _demosVisuales.contar();
            timer1.Start();
        }
    }
}
