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
    public partial class Form2 : Form
    {
        static int tamOriginal = 28;
        static int DistOriginal = 6;
        static string path = @"D:\seminario\";
        static string archivo = "historial.txt";
        static int fase = 0;
        static string Prueba1;
        static string Prueba2;
        static string Prueba3;
        static string Prueba4;
        public Form2()
        {
            InitializeComponent();

            label2.Text = "bienvenido\n la primera prueba es la de siempre \n" +
                "1.- tendra que observar la tabla a \nuna distancia de: " + this.Width + "\n2.-enseguida" +
                "marcara hasta que punto \npuede observar sin entrecerrar los ojos";
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
            Boolean isChecked = (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked ||
                radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked
                || radioButton8.Checked);
            if (isChecked || fase == 3) fase++;
            if (fase == 1 && isChecked == true)
            {
                if (radioButton1.Checked) Prueba1 = radioButton1.Text;
                if (radioButton2.Checked) Prueba1 = radioButton2.Text;
                if (radioButton3.Checked) Prueba1 = radioButton3.Text;
                if (radioButton4.Checked) Prueba1 = radioButton4.Text;
                if (radioButton5.Checked) Prueba1 = radioButton5.Text;
                if (radioButton6.Checked) Prueba1 = radioButton6.Text;
                if (radioButton7.Checked) Prueba1 = radioButton7.Text;
                if (radioButton8.Checked) Prueba1 = radioButton8.Text;
                label2.Text = "ahora repetiremos la prueba\n" +
                "con un ojo a la vez con el fin\n" +
                "de ver que ojo esta mejor empecemos\n" +
                "por el derecho";
            }
            if (fase == 2 && isChecked == true)
            {
                if (radioButton1.Checked) Prueba2 = radioButton1.Text;
                if (radioButton2.Checked) Prueba2 = radioButton2.Text;
                if (radioButton3.Checked) Prueba2 = radioButton3.Text;
                if (radioButton4.Checked) Prueba2 = radioButton4.Text;
                if (radioButton5.Checked) Prueba2 = radioButton5.Text;
                if (radioButton6.Checked) Prueba2 = radioButton6.Text;
                if (radioButton7.Checked) Prueba2 = radioButton7.Text;
                if (radioButton8.Checked) Prueba2 = radioButton8.Text;
                label2.Text = "ahora repetiremos la prueba\n" +
            "pero con el ojo izquierdo";
            }
            if (fase == 3 && isChecked == true)
            {
                if (radioButton1.Checked) Prueba3 = radioButton1.Text;
                if (radioButton2.Checked) Prueba3 = radioButton2.Text;
                if (radioButton3.Checked) Prueba3 = radioButton3.Text;
                if (radioButton4.Checked) Prueba3 = radioButton4.Text;
                if (radioButton5.Checked) Prueba3 = radioButton5.Text;
                if (radioButton6.Checked) Prueba3 = radioButton6.Text;
                if (radioButton7.Checked) Prueba3 = radioButton7.Text;
                if (radioButton8.Checked) Prueba3 = radioButton8.Text;
                label2.Text = "esta ultima prueba se realizara con\n" +
           "el uso de una hoja negra a la\n" +
           "cual se le hara una insercion con el \n" +
           "ancho de la punta de una pluma y vera\n" +
           "atraves esta es una prueba de \n" +
           "capacidad visual";
            }
            if (fase == 4)
            {
                
                if (radioButton1.Checked) Prueba4 = radioButton1.Text;
                if (radioButton2.Checked) Prueba4 = radioButton2.Text;
                if (radioButton3.Checked) Prueba4 = radioButton3.Text;
                if (radioButton4.Checked) Prueba4 = radioButton4.Text;
                if (radioButton5.Checked) Prueba4 = radioButton5.Text;
                if (radioButton6.Checked) Prueba4 = radioButton6.Text;
                if (radioButton7.Checked) Prueba4 = radioButton7.Text;
                if (radioButton8.Checked) Prueba4 = radioButton8.Text;
                StreamWriter WriteReportFile = File.AppendText(path + archivo);
                if (!System.IO.File.Exists(path+archivo))
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(path+archivo,System.IO.FileMode.Append))
                    {
                        for (byte i = 0; i < 100; i++)
                        {
                            fs.WriteByte(i);
                        }
                    }
                    WriteReportFile.WriteLine("PRUEBA1 :" + Prueba1 + "\n" +
                        "PRUEBA2: " + Prueba2 + "\nPRUEBA3: " + Prueba3 + "\nPRUEBA4: " + Prueba4 + "\n" +
                        "END");
                    WriteReportFile.Close();
                }
                else
                {
                    
                    WriteReportFile.WriteLine("PRUEBA1 :"+Prueba1+"\n" +
                        "PRUEBA2: "+Prueba2+ "\nPRUEBA3: "+Prueba3+ "\nPRUEBA4: "+Prueba4+"\n" +
                        "END");
                    WriteReportFile.Close();
                }
                    this.Close();
                Form1 prueba1 = new Form1();
                prueba1.Show();

            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }
    }
}

   

