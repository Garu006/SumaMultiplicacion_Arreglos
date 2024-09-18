using Ejercicio2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Reservacion reserva = new Reservacion();
        int reservaNum = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (rbFumador.Checked)
                {
                   reservaNum  = 1;
                }
                else if (rbNoFumador.Checked)
                {
                    reservaNum = 2;
                }
                else
                {
                    MessageBox.Show("Por favor selecciones una opcion de seccion");
                    return;
                }

                menu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void menu()
        {
            switch (reservaNum)
            {
                case 1:
                    int Fumador = reserva.PasajeroFumador();
                    if (Fumador != -1)
                    {
                        lbReserva.Items.Add($"su asiento es {Fumador}, en la seccion de fumadores");
                    }
                    else
                    {
                        lbReserva.Items.Add(reserva.Convertir(1));
                    }
                    break;

                case 2:
                    int asientoNoFumador = reserva.PasajeroNoFumador();
                    if (asientoNoFumador != -1)
                    {
                        lbReserva.Items.Add($"Su asiento es  {asientoNoFumador} en la sección de no fumar.");
                    }
                    else
                    {
                        lbReserva.Items.Add(reserva.Convertir(2));
                    }
                    break;
                default:
                    MessageBox.Show("opcion invalida");
                    break;

            }
        }
    }
}
