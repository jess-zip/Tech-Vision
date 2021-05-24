
namespace seminario
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.prueba = new System.Windows.Forms.Label();
            this.ingreso = new System.Windows.Forms.TextBox();
            this.checar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2098, 1082);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 148);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prueba.Location = new System.Drawing.Point(229, 150);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(175, 37);
            this.prueba.TabIndex = 20;
            this.prueba.Text = "IBTWFCJY";
            // 
            // ingreso
            // 
            this.ingreso.Location = new System.Drawing.Point(236, 203);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(168, 30);
            this.ingreso.TabIndex = 21;
            this.ingreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checar
            // 
            this.checar.Location = new System.Drawing.Point(245, 240);
            this.checar.Name = "checar";
            this.checar.Size = new System.Drawing.Size(150, 33);
            this.checar.TabIndex = 22;
            this.checar.Text = "Listo";
            this.checar.UseVisualStyleBackColor = true;
            this.checar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1443, 879);
            this.Controls.Add(this.checar);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label prueba;
        private System.Windows.Forms.TextBox ingreso;
        private System.Windows.Forms.Button checar;
    }
}