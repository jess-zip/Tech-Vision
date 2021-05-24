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
        static string path = @"D:\UAA\8vo_Semestre\Seminario_Sistemas_Computacionales\Proyecto\Avance2_proyecto\seminario";
        static string archivo = "historial.txt";
        static int fase = 0;
        static string Prueba1;
        static string Prueba2;
        static string Prueba3;
        static string Prueba4; 
        static bool izquierdo = true;
        static bool derecho = true;

        public Form2()
        {
            InitializeComponent();

            label2.Text = "Bienvenido\nEsta prueba chacara la agudeza visual\n" +
                "1.-observar la tabla a una distancia \nde: si la pantalla tiene un ancho \nde : 34-35cm (tamaño estandar\nde laptop)  alejarse aproximadamente\n3.5m a 4 " +
                "si es 52 cm alejarse aprox. 6m"  + "\n2.-enseguida " +
                "marcara hasta que punto \npuede observar sin entrecerrar los ojos";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            fase =0;
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
                label2.Text = "Ahora repetiremos la prueba\n" +
                "con un ojo a la vez, con el fin\n" +
                "de ver que ojo está mejor. Empecemos\n" +
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
                label2.Text = "Ahora, repetiremos la prueba\n" +
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
                label2.Text = "Última prueba se realizará con\n" +
           "el uso de una hoja negra a la cual se\n" +
           "le hara una insersión con el ancho de\n" +
           "la punta de una pluma y vera a traves.\n" +
           "Esta es una prueba de capacidad visual\n" +
           "que checará hasta donde es capaz de ver con\nel uso de lentes. Si su vista mejora\nesto es un problema de refracción (miopía\no astigmatismo)";
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
                if (!System.IO.File.Exists(path + archivo))
                {
                    using (System.IO.FileStream fs = new System.IO.FileStream(path + archivo, System.IO.FileMode.Append))
                    {
                        for (byte i = 0; i < 100; i++)
                        {
                            fs.WriteByte(i);
                        }
                    }
                    WriteReportFile.WriteLine("PRUEBA1:" + Prueba1 + "\n" +
                        "PRUEBA2:" + Prueba2 + "\nPRUEBA3:" + Prueba3 + "\nPRUEBA4:" + Prueba4 + "\n" +
                        "END");
                    WriteReportFile.Close();
                }
                else
                {

                    WriteReportFile.WriteLine("PRUEBA1:" + Prueba1 + "\n" +
                        "PRUEBA2:" + Prueba2 + "\nPRUEBA3:" + Prueba3 + "\nPRUEBA4:" + Prueba4 + "\n" +
                        "END");
                    WriteReportFile.Close();
                }
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                label2.Visible = false;
                groupBox1.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                pictureBox4.Visible = true;
                button3.Visible = true;
                //panel1.Visible = false;
                //panel2.Visible = false;
                if (Prueba2.Equals("20/16") || Prueba2.Equals("20/20")) {
                    label3.Text = "Ojo derecho tiene un grado de agudeza visual > 8 \nlo que dice que es una vista normal a muy buena";
                    derecho = true;
                }
                else if (Prueba2.Equals("20/25") || Prueba2.Equals("20/30") || Prueba2.Equals("20/40")) {
                    label3.Text = "Ojo derecho tiene un grado de agudeza visual 7-5 \nlo que dice que es una vista tiene problemas visuales y se sugiere ir con un oftalmologo";
                    derecho = false;
                }

                else { label3.Text = "Ojo derecho tiene un grado de agudeza visual < 5 \nurge la visita con el oftalmologo"; derecho = false; }



                if (Prueba3.Equals("20/16") || Prueba3.Equals("20/20")) {
                    derecho = true;
                    label4.Text = "Ojo izquierdo tiene un grado de agudeza visual > 8 \nlo que dice que es una vista normal a muy buena";
                }
                else if (Prueba3.Equals("20/25") || Prueba3.Equals("20/30") || Prueba3.Equals("20/40")) {
                    label4.Text = "Ojo izquierdo tiene un grado de agudeza visual 7-5 \nlo que dice que es una vista tiene problemas visuales y se sugiere ir con un oftalmologo";
                    izquierdo = false;
                }
                else { label4.Text = "Ojo izquierdo tiene un grado de agudeza visual < 5 \nurge la visita con el oftalmologo";
                    izquierdo = false;
                }
                if(izquierdo == false && derecho == true) 
                pictureBox4.Image = Image.FromFile(path +@"\imagenes\cal3.png");

                if (izquierdo == true && derecho == false)
                    pictureBox4.Image = Image.FromFile(path + @"\imagenes\cal2.png");

                if (izquierdo == true && derecho == true)
                    pictureBox4.Image = Image.FromFile(path + @"\imagenes\cal1.png");

                if (izquierdo == false && derecho == false)
                    pictureBox4.Image = Image.FromFile(path + @"\imagenes\cal4.png");


                label5.Text = "Si el probleba es de refraccion la vista puede \nmejorar de " + Prueba1+" hasta "+Prueba4+"con el uso de lentes"; 
              
                /*
                this.Close();
                Form1 prueba1 = new Form1();
                prueba1.Show();
                */
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 prueba1 = new Form1();
            prueba1.Show();
        }
    }
}

   

