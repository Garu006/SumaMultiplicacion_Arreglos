using Ejercicio4.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        Vendedor ventas = new Vendedor();
        int venta;
        int producto;
        double dinero;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tbVendedor.Text, out venta) || venta < 1 || venta > 4)
                {
                    MessageBox.Show("Ingrese un numero valido");
                    return;
                }

                if (!int.TryParse(tbProducto.Text, out producto) || producto < 1 || producto > 5)
                {
                    MessageBox.Show("ingrese un numero valido");
                    return;
                }

                if (!double.TryParse(lbTotalDolares.Text, out dinero) || dinero <= 0)
                {
                    MessageBox.Show("Ingrese un numero valido");
                    return;
                }
                //aqui agrego la venta
                ventas.AñadirVenta(venta, producto, dinero);
                MessageBox.Show("Se agrego la venta");

                lbRespuesta.Items.Clear();
                lbRespuesta.Items.Add("Se agrego la venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
