using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercBeisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Número { get; set; }

        public Jugador()
        {

        }

        public Jugador(string nombre, string número)
        {
            Nombre = nombre;
            número = "Sin asignar";
        }

    }
}
