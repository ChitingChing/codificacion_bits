namespace Simulador_de_señales
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pctSeñalOriginal = new System.Windows.Forms.PictureBox();
            this.pctNRZ = new System.Windows.Forms.PictureBox();
            this.pctNRZI = new System.Windows.Forms.PictureBox();
            this.pctManchester = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pctManchesterD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctSeñalOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNRZI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctManchester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctManchesterD)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Señal de bits";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Graficar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctSeñalOriginal
            // 
            this.pctSeñalOriginal.BackColor = System.Drawing.Color.White;
            this.pctSeñalOriginal.Location = new System.Drawing.Point(184, 86);
            this.pctSeñalOriginal.Name = "pctSeñalOriginal";
            this.pctSeñalOriginal.Size = new System.Drawing.Size(500, 60);
            this.pctSeñalOriginal.TabIndex = 3;
            this.pctSeñalOriginal.TabStop = false;
            // 
            // pctNRZ
            // 
            this.pctNRZ.BackColor = System.Drawing.Color.White;
            this.pctNRZ.Location = new System.Drawing.Point(184, 178);
            this.pctNRZ.Name = "pctNRZ";
            this.pctNRZ.Size = new System.Drawing.Size(500, 60);
            this.pctNRZ.TabIndex = 4;
            this.pctNRZ.TabStop = false;
            // 
            // pctNRZI
            // 
            this.pctNRZI.BackColor = System.Drawing.Color.White;
            this.pctNRZI.Location = new System.Drawing.Point(184, 270);
            this.pctNRZI.Name = "pctNRZI";
            this.pctNRZI.Size = new System.Drawing.Size(500, 60);
            this.pctNRZI.TabIndex = 5;
            this.pctNRZI.TabStop = false;
            // 
            // pctManchester
            // 
            this.pctManchester.BackColor = System.Drawing.Color.White;
            this.pctManchester.Location = new System.Drawing.Point(184, 362);
            this.pctManchester.Name = "pctManchester";
            this.pctManchester.Size = new System.Drawing.Size(500, 60);
            this.pctManchester.TabIndex = 6;
            this.pctManchester.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Señal Original:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NRZ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NRZ-I:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manchester:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Manchester Diferencial:";
            // 
            // pctManchesterD
            // 
            this.pctManchesterD.BackColor = System.Drawing.Color.White;
            this.pctManchesterD.Location = new System.Drawing.Point(184, 456);
            this.pctManchesterD.Name = "pctManchesterD";
            this.pctManchesterD.Size = new System.Drawing.Size(500, 60);
            this.pctManchesterD.TabIndex = 11;
            this.pctManchesterD.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 558);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pctManchesterD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctManchester);
            this.Controls.Add(this.pctNRZI);
            this.Controls.Add(this.pctNRZ);
            this.Controls.Add(this.pctSeñalOriginal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Codificacion de bits by Chiting Ching!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSeñalOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNRZI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctManchester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctManchesterD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctSeñalOriginal;
        private System.Windows.Forms.PictureBox pctNRZ;
        private System.Windows.Forms.PictureBox pctNRZI;
        private System.Windows.Forms.PictureBox pctManchester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pctManchesterD;
    }
}

