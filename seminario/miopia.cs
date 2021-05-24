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
    public partial class miopia : Form
    {
        int test;
        public miopia()
        {
            InitializeComponent();
            test = 0;
        }

        private void checar_Click(object sender, EventArgs e)
        {
            if (prueba.Text == ingreso.Text)
            {
                test++;
                switch (test)
                {
                    case 1:
                        prueba.Font = new Font("Bookman Old Style", 16);
                        prueba.Text = "HZEKAVDY";
                        ingreso.Text = "";
                        break;
                    case 2:
                        prueba.Font = new Font("Bookman Old Style", 14);
                        prueba.Text = "ZDTRBKFX";
                        ingreso.Text = "";
                        break;
                    case 3:
                        prueba.Font = new Font("Bookman Old Style", 12);
                        prueba.Text = "VDFPMYGA";
                        ingreso.Text = "";
                        break;
                    case 4:
                        prueba.Font = new Font("Bookman Old Style", 10);
                        prueba.Text = "DNJVPMSZ";
                        ingreso.Text = "";
                        break;
                    case 5:
                        prueba.Font = new Font("Bookman Old Style", 8);
                        prueba.Text = "RILJPSBF";
                        ingreso.Text = "";
                        break;
                    default:
                        prueba.Visible = false;
                        ingreso.Visible = false;
                        checar.Visible = false;
                        paloma.Visible = true;
                        resultados.Visible = true;
                        chat.Text = "Bien hecho! Sus resultados se encuentran del lado derecho de la pantalla";
                        resultados.Text = "¡Felicidades! \n " +
                            "Su vista no cuenta con Miopía.";
                        break;
                }
            }
            else
            {
                prueba.Visible = false;
                ingreso.Visible = false;
                checar.Visible = false;
                paloma.Visible = true;
                resultados.Visible = true;
                chat.Text = "Bien hecho! Sus resultados se encuentran del lado derecho de la pantalla";
                resultados.Text = "¡On no! \n" + "Puede que usted cuenta con Miopía \n" + "Favor de consultar a su Oftamólogo para mayor información";
            }
        }

        private void ingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 prueba1 = new Form1();
            prueba1.Show();
        }
    }
}
