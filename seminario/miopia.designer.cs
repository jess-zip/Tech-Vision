
namespace seminario
{
    partial class miopia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miopia));
            this.checar = new System.Windows.Forms.Button();
            this.prueba = new System.Windows.Forms.Label();
            this.ingreso = new System.Windows.Forms.TextBox();
            this.paloma = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chat = new System.Windows.Forms.RichTextBox();
            this.resultados = new System.Windows.Forms.RichTextBox();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paloma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checar
            // 
            this.checar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checar.Location = new System.Drawing.Point(1113, 467);
            this.checar.Name = "checar";
            this.checar.Size = new System.Drawing.Size(215, 49);
            this.checar.TabIndex = 0;
            this.checar.Text = "Listo";
            this.checar.UseVisualStyleBackColor = true;
            this.checar.Click += new System.EventHandler(this.checar_Click);
            // 
            // prueba
            // 
            this.prueba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prueba.AutoSize = true;
            this.prueba.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.prueba.Location = new System.Drawing.Point(1134, 295);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(175, 37);
            this.prueba.TabIndex = 1;
            this.prueba.Text = "IBTWFCJY";
            this.prueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingreso
            // 
            this.ingreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.ingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ingreso.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.ingreso.Location = new System.Drawing.Point(1113, 377);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(215, 43);
            this.ingreso.TabIndex = 2;
            this.ingreso.TextChanged += new System.EventHandler(this.ingreso_TextChanged);
            // 
            // paloma
            // 
            this.paloma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paloma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paloma.BackgroundImage")));
            this.paloma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paloma.Location = new System.Drawing.Point(1165, 169);
            this.paloma.Name = "paloma";
            this.paloma.Size = new System.Drawing.Size(182, 213);
            this.paloma.TabIndex = 3;
            this.paloma.TabStop = false;
            this.paloma.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(84, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 428);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(226, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 419);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // chat
            // 
            this.chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat.Location = new System.Drawing.Point(297, 61);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(353, 232);
            this.chat.TabIndex = 6;
            this.chat.Text = resources.GetString("chat.Text");
            this.chat.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // resultados
            // 
            this.resultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.resultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultados.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultados.Location = new System.Drawing.Point(1123, 364);
            this.resultados.Name = "resultados";
            this.resultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.resultados.Size = new System.Drawing.Size(353, 232);
            this.resultados.TabIndex = 7;
            this.resultados.Text = "";
            this.resultados.Visible = false;
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.salir.Location = new System.Drawing.Point(1477, 731);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(215, 49);
            this.salir.TabIndex = 9;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // miopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1739, 825);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.paloma);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.checar);
            this.Name = "miopia";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.paloma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checar;
        private System.Windows.Forms.Label prueba;
        private System.Windows.Forms.TextBox ingreso;
        private System.Windows.Forms.PictureBox paloma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox chat;
        private System.Windows.Forms.RichTextBox resultados;
        private System.Windows.Forms.Button salir;
    }
}