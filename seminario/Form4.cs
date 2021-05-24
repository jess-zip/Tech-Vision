using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminario
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (prueba.Text == ingreso.Text)
            {
                checar.ForeColor = System.Drawing.Color.White;
                prueba.Text = "HZEKAVDY";
                ingreso.Text = "";
            }
            else
            {
                checar.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
