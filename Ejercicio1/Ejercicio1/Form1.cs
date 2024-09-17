using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Dados dadillo = new Dados();
        private const int lanzamientos = 3600;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lanzar();
        }

        private void lanzar()
        {
           dadillo.LanzarDado(lanzamientos);
            int[] resultado = dadillo.Resultado();
            lbResultado.Items.Clear();

            for (int i = 0; i <= 12; i++)
            {
                lbResultado.Items.Add($"Suma: {i}" + $"---------- Frecuencia: {resultado[i]}");
            }

            MessageBox.Show($"El numero 7 aparecio {resultado[7]} veces", "resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
