using CampoMinado;
using System;

namespace CicloJuego
{
    static class CargarRecurso
    {
        public static CampoMinado.Tablero Ejecutar(CampoMinado.Tablero tablero)
        {
            tablero = new CampoMinado.Tablero();
            CampoMinado.Campo campo = new CampoMinado.Campo();
            CampoMinado.Personaje personaje = new CampoMinado.Personaje(10, 30, 'N');
            CampoMinado.Enemigo enemigo1 = new CampoMinado.Enemigo(10, 70);
            CampoMinado.Enemigo enemigo2 = new CampoMinado.Enemigo(20,90);
            tablero.Campo = campo;
            tablero.Personaje = personaje;
            tablero.Enemigo1 = enemigo1;
            tablero.Enemigo2= enemigo2;
          
            ListaJugadores listajugadores = new ListaJugadores();
            listajugadores.CargarArchivo();

            Console.WriteLine("Ingrese Nombre del Jugador (Si ya existe se cargarán sus puntos sino se creará uno nuevo):");


            tablero.jugador = listajugadores.DevuelveJugador(Console.ReadLine());
            tablero.jugadores = listajugadores;



           



            return tablero;

        }
    }
}
