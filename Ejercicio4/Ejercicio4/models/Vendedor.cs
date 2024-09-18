using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.models
{
    internal class Vendedor
    {
        public double[,] venta = new double[4, 5];
        string solucion;


        public void AñadirVenta(int vendedor, int producto, double dinero)
        {
            if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5)
            {
                venta[producto - 1, vendedor - 1] += dinero;
            }
            else
            {
                throw new ArgumentException("El numero esta fuera del rango");
            }

        }

        public double TotalVendedor(int vendedor)
        {
            double total = 0;
            for (int i = 0;i<4; i++)
            {
                total += venta[vendedor - 1, i];
            }
            return total;
        }

        public double TotalProductos(int productos)
        {
            double sum = 0; 
            for(int i=0; i<4; i++)
            {
                sum += venta[productos - 1, i];
            }
            return sum;
        }

        public string Show1()
        {


            for (int i = 0; i < 5; i++)
            {
                solucion = "ventas por producto y vendedor:\n";

                solucion += $"producto {i + 1} :";

                for (int j = 0; j < 4; j++)
                {
                    solucion += venta[i, j].ToString("F2") + "\t"; //formato con dos decimales

                }

                solucion += "total producto: " + TotalProductos(i + 1).ToString("F2") + "\n";


            }

            solucion += "Totales por vendedor:\n";
            for (int k = 0; k < 4; k++)
            {
                solucion += "Vendedor " + (k + 1) + ":" + TotalVendedor(k + 1) + ":" + TotalVendedor(k + 1).ToString("F2") + "\n";
            }

            return solucion;
        }
    }   }