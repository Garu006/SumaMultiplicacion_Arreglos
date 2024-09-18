using Ejercicio3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Ventas gestion = new Ventas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            double ventas;

            // Validar que el usuario haya ingresado un número válido
            if (double.TryParse(tbVentas.Text, out ventas))
            {
                // Calcular el salario y actualizar el contador correspondiente
                gestion.Resultados(ventas);

                // Mostrar el resultado en el ListBox
                lbVentas.Items.Clear();
                lbVentas.Items.Add(gestion.MostrarResultados());
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido");
            }
        }

    }
}

