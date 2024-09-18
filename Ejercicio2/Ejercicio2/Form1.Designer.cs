namespace Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbReversa = new System.Windows.Forms.TextBox();
            this.rbFumador = new System.Windows.Forms.RadioButton();
            this.rbNoFumador = new System.Windows.Forms.RadioButton();
            this.lbReserva = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tbReversa
            // 
            this.tbReversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReversa.ForeColor = System.Drawing.Color.Navy;
            this.tbReversa.Location = new System.Drawing.Point(251, 24);
            this.tbReversa.Name = "tbReversa";
            this.tbReversa.Size = new System.Drawing.Size(211, 29);
            this.tbReversa.TabIndex = 1;
            this.tbReversa.Text = "Reserve su vuelo";
            // 
            // rbFumador
            // 
            this.rbFumador.AutoSize = true;
            this.rbFumador.Location = new System.Drawing.Point(366, 254);
            this.rbFumador.Name = "rbFumador";
            this.rbFumador.Size = new System.Drawing.Size(110, 17);
            this.rbFumador.TabIndex = 2;
            this.rbFumador.TabStop = true;
            this.rbFumador.Text = "Pasajero Fumador";
            this.rbFumador.UseVisualStyleBackColor = true;
            // 
            // rbNoFumador
            // 
            this.rbNoFumador.AutoSize = true;
            this.rbNoFumador.Location = new System.Drawing.Point(366, 301);
            this.rbNoFumador.Name = "rbNoFumador";
            this.rbNoFumador.Size = new System.Drawing.Size(127, 17);
            this.rbNoFumador.TabIndex = 3;
            this.rbNoFumador.TabStop = true;
            this.rbNoFumador.Text = "Pasajero No Fumador";
            this.rbNoFumador.UseVisualStyleBackColor = true;
            // 
            // lbReserva
            // 
            this.lbReserva.FormattingEnabled = true;
            this.lbReserva.Location = new System.Drawing.Point(50, 149);
            this.lbReserva.Name = "lbReserva";
            this.lbReserva.Size = new System.Drawing.Size(310, 251);
            this.lbReserva.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbReserva);
            this.Controls.Add(this.rbNoFumador);
            this.Controls.Add(this.rbFumador);
            this.Controls.Add(this.tbReversa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReversa;
        private System.Windows.Forms.RadioButton rbFumador;
        private System.Windows.Forms.RadioButton rbNoFumador;
        private System.Windows.Forms.ListBox lbReserva;
        private System.Windows.Forms.Button button1;
    }
}

