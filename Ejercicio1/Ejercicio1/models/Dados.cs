using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class Dados
    {
        private int[] Dado = new int[13];
        public void LanzarDado(int intento)
        {
            Random rand = new Random();

            Random aleatorio = new Random();

            for(int i=0; i<intento; i++)
            {
                int dado1=rand.Next(1,7);

                int dado2 = rand.Next(1, 7);

                int suma = dado1 + dado2;

                
            }
        }

        public int[] Resultado()
        {
            return Dado;
        }
    }
}
