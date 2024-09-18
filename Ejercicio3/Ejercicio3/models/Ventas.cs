using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.models
{
    internal class Ventas
    {
        public int[] ventas = new int[10];
        
        public void Resultados(double gananciasBrutas)
        {
            double ganancia = 200 + (gananciasBrutas * 0.09);
            if (ganancia >= 200 && ganancia < 300)
            {
                ventas[0]++;
            }
            else if (ganancia >= 300 && ganancia < 400)
            {
                ventas[1]++;
            }
            else if (ganancia >= 400 && ganancia < 500)
            {
                ventas[2]++;
            }
            else if (ganancia >= 500 && ganancia < 600)
            {
                ventas[3]++;
            }
            else if (ganancia >= 600 && ganancia < 700)
            {
                ventas[4]++;
            }
            else if (ganancia >= 700 && ganancia < 800)
            {
                ventas[5]++;
            }
            else if (ganancia >= 800 && ganancia < 900)
            {
                ventas[6]++;
            }
            else if (ganancia >= 900 && ganancia < 1000)
            {
                ventas[7]++;
            }
            else if (ganancia >= 1000)
            {
                ventas[8]++;
            }
        }
        public string MostrarResultados()
        {
            string resultado = "Salarios:\n";
            resultado += "$200 - $299: " + ventas[0] + "\n";
            resultado += "$300 - $399: " + ventas[1] + "\n";
            resultado += "$400 - $499: " + ventas[2] + "\n";
            resultado += "$500 - $599: " + ventas[3] + "\n";
            resultado += "$600 - $699: " + ventas[4] + "\n";
            resultado += "$700 - $799: " + ventas[5] + "\n";
            resultado += "$800 - $899: " + ventas[6] + "\n";
            resultado += "$900 - $999: " + ventas[7] + "\n";
            resultado += "$1000 o más: " + ventas[8] + "\n";
            return resultado;
        }
    }
}
