using CampoMinado;
using System;
using System.Threading.Tasks;

namespace CicloJuego
{
    static class Dibujar
    {

       

        public static void ejecutar(CampoMinado.Tablero tablero)
        {
            
            tablero.Campo.Dibujar();
            tablero.Enemigo1.Dibujar();
             tablero.Enemigo2.Dibujar();
         
            tablero.Personaje.Dibujar();

            //Parallel.Invoke( () => tablero.Personaje.Dibujar());




            Console.SetCursorPosition(2, 4);

            Console.Write($"Jugador:  {tablero.jugador.Nombre}");

            Console.SetCursorPosition(4, 4);

            Console.Write($"Enemigos abatidos:  {tablero.jugador.Puntaje}");

            Console.SetCursorPosition(40, 4);
            Console.Write($"Presione Esc para salir y guardar la partida");




            if (tablero.HayColision())
            {

               tablero.Enemigo1.CambiarUbicacion();
               tablero.Enemigo2.CambiarUbicacion();
                tablero.Personaje.haycolision=false;
                 int cuenta= tablero.jugador.sumauno();
                Console.SetCursorPosition(4, 4);

                Console.Write($"Enemigos abatidos:  {tablero.jugador.Puntaje}");







            }


        }
    }
}
