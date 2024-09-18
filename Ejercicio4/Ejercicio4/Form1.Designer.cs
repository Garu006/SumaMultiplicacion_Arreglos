namespace Ejercicio4
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
            this.lbVendedor = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbTotalDolares = new System.Windows.Forms.Label();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbRespuesta = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVendedor
            // 
            this.lbVendedor.AutoSize = true;
            this.lbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendedor.Location = new System.Drawing.Point(49, 49);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(113, 25);
            this.lbVendedor.TabIndex = 0;
            this.lbVendedor.Text = "Vendedor";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(267, 49);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(106, 25);
            this.lbProducto.TabIndex = 1;
            this.lbProducto.Text = "Producto";
            this.lbProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTotalDolares
            // 
            this.lbTotalDolares.AutoSize = true;
            this.lbTotalDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDolares.Location = new System.Drawing.Point(469, 49);
            this.lbTotalDolares.Name = "lbTotalDolares";
            this.lbTotalDolares.Size = new System.Drawing.Size(186, 25);
            this.lbTotalDolares.TabIndex = 2;
            this.lbTotalDolares.Text = "Total en Dolares";
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(39, 97);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(139, 20);
            this.tbVendedor.TabIndex = 3;
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(260, 96);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(138, 20);
            this.tbProducto.TabIndex = 4;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(465, 96);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(207, 20);
            this.tbTotal.TabIndex = 5;
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.FormattingEnabled = true;
            this.lbRespuesta.Location = new System.Drawing.Point(54, 181);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(279, 186);
            this.lbRespuesta.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(453, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 91);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbRespuesta);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.lbTotalDolares);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.lbVendedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbTotalDolares;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ListBox lbRespuesta;
        private System.Windows.Forms.Button btnAgregar;
    }
}

