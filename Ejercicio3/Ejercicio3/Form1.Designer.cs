namespace Ejercicio3
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbVentas = new System.Windows.Forms.TextBox();
            this.lbVentas = new System.Windows.Forms.ListBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(100, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ventas";
            // 
            // tbVentas
            // 
            this.tbVentas.Location = new System.Drawing.Point(100, 100);
            this.tbVentas.Name = "tbVentas";
            this.tbVentas.Size = new System.Drawing.Size(330, 20);
            this.tbVentas.TabIndex = 1;
            // 
            // lbVentas
            // 
            this.lbVentas.FormattingEnabled = true;
            this.lbVentas.Location = new System.Drawing.Point(100, 171);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(316, 212);
            this.lbVentas.TabIndex = 2;
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(546, 212);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(117, 86);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "button1";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.lbVentas);
            this.Controls.Add(this.tbVentas);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbVentas;
        private System.Windows.Forms.ListBox lbVentas;
        private System.Windows.Forms.Button btnVentas;
    }
}

