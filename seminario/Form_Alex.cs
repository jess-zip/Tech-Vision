using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminario
{
    public partial class Form_Alex : Form
    {
        int banderademexico = 0;
        static int tamOriginal = 28;
        static int DistOriginal = 6;
        static string path = @"D:\seminario\";
        static string archivo = "historial.txt";
        static int fase = 0;
        static string Prueba1;
        static string Prueba2;
        static string Prueba3;
        static string Prueba4;
        public Form_Alex()
        {
            InitializeComponent();

            label2.Text = "Bienvenido!!!\nEsta prueba consiste en hacer los\n" +
                "siguientes movimientos, de 4 a 5 veces,\nsolamente con los ojos. " + "Con el fin de\nejercitar los" +
                "musculos y eliminar la fatiga,\n también ayuda con problemas de\nestrabismo. Debajo de cada ejercicio\nse puede bservar una animación\nque muestra cómo hacerlo.";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            pictureBox10.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox1.Visible = false;
            label2.Text = "Bien hecho!!! \nAhora intentemos con estos ejercicios.";
            button2.Text = "Terminar";
            if(banderademexico == 1) { 
                Form1 obj = new Form1();
                this.Close();
                obj.Show();
            }
            banderademexico++;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

   

