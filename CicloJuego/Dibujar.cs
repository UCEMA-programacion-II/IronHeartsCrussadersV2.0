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
            tablero.Enemigo3.Dibujar();

            tablero.Personaje.Dibujar();

            //Parallel.Invoke( () => tablero.Personaje.Dibujar());





            if (tablero.HayColision())
            {


                Console.SetCursorPosition(20, 20);

                Console.Write("UPSS");




            }


        }
    }
}
