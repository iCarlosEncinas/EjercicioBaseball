using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercBeisbol
{
    class Equipo
    {
        public string NombreT { get; set; }
        public string cOrigen { get; set; }
        public string Entrenador { get; set; }
        public  List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            cOrigen = "Sin asignar";
            Entrenador = "No nombrado";
            
        }

        public Equipo(string nombreT)
        {
            NombreT = nombreT;
            Jugadores = new List<Jugador>();
        }

    }
}
