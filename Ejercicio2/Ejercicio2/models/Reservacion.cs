using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.models
{
    internal class Reservacion
    {
        private int[] reservas = new int[10];

        public Reservacion()
        {
            for (int i = 0; i <10; i++)
            {
                reservas[i] = 0;
            }
        }

        public int PasajeroFumador()
        {
            for (int i = 0; i < 5; i++)
            {
                if (reservas[i] == 0)
                {
                    reservas[i] = 1;
                    return i + 1;
                }
            }

            return -1;
        }

        public int PasajeroNoFumador()
        {
            for (int i = 5; i < 10; i++)
            {
                if (reservas[i] == 0)
                {
                    reservas[i] = 1;
                    return i + 1;
                }
            }
            
            return -1;
        }

        public string Convertir(int grupo)
        {
            if(grupo==0)
            {
                int Nofumador = PasajeroNoFumador();
                if(Nofumador!=-1)
                {
                    return $"La seccion de fumadores esta llena, se le asignara un nuevo asiento {Nofumador} en el grupo de los no fumadores";
                }
            }
            else if(grupo==2)
            {
                int Fumador = PasajeroFumador();
                if(Fumador!=-1)
                {
                    return $"El grupo de no fumadores ha llegado a la maxima capacidad, se le asignara un asiento {Fumador} en el grupo de los fumadores";
                }
                
            }
            return "El vuelo esta lleno, el siguiente vuelo saldra dentro de poco";
        }
    }
}
