using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo Team1 = new Equipo("Yaquis");
            Equipo Team2 = new Equipo("Mayos");

            equipos.Add(Team1);
            equipos.Add(Team2);

            Jugador J1 = new Jugador("Pedro", "1");
            Jugador J2 = new Jugador("Luis", "2");
            Jugador J3 = new Jugador("Ramiro", "3");
            Jugador J4 = new Jugador("Negro", "4");
            Jugador J5 = new Jugador("Wero", "5");
            Jugador J6 = new Jugador("Wilo", "6");
            Jugador J7 = new Jugador("Sergio", "7");
            Jugador J8 = new Jugador("Valdo", "8");
            Jugador J9 = new Jugador("Emi", "9");

            Jugador J10 = new Jugador("Carlos", "1");
            Jugador J12 = new Jugador("Nico", "2");
            Jugador J13 = new Jugador("John", "3");
            Jugador J14 = new Jugador("White", "4");
            Jugador J15 = new Jugador("Prieto", "5");
            Jugador J16 = new Jugador("Alberto", "6");
            Jugador J17 = new Jugador("Yibus", "7");
            Jugador J18 = new Jugador("Alex", "8");
            Jugador J19 = new Jugador("Dani", "9");

            Team1.Jugadores.Add(J1);
            Team1.Jugadores.Add(J2);
            Team1.Jugadores.Add(J3);
            Team1.Jugadores.Add(J4);
            Team1.Jugadores.Add(J5);
            Team1.Jugadores.Add(J6);
            Team1.Jugadores.Add(J7);
            Team1.Jugadores.Add(J8);
            Team1.Jugadores.Add(J9);

            Team2.Jugadores.Add(J10);
            Team2.Jugadores.Add(J12);
            Team2.Jugadores.Add(J13);
            Team2.Jugadores.Add(J14);
            Team2.Jugadores.Add(J15);
            Team2.Jugadores.Add(J16);
            Team2.Jugadores.Add(J17);
            Team2.Jugadores.Add(J18);
            Team2.Jugadores.Add(J19);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("\n");
                Console.WriteLine("     Equipo: " + equipo.NombreT);

                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("         - " + jugador.Nombre);
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
