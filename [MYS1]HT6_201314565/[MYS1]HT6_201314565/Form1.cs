using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _MYS1_HT6_201314565
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crear_modelo_Click(object sender, EventArgs e)
        {
            _201314565 generador = new _201314565();
            generador.construir_Modelo();
        }
    }
}
