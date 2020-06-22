using System;
using System.Threading.Tasks;

namespace CicloJuego
{
    static class Actualizar
    {
        public static CampoMinado.Tablero ejecutar(CampoMinado.Tablero tablero)
        {

            ConsoleKey tecla;
            
            tecla = Console.ReadKey().Key;

            
            if (tecla == ConsoleKey.Spacebar) {
                
                tablero.Personaje.Disparar(tablero.Personaje.X, tablero.Personaje.Y,tablero.Personaje.O);
            
            }
            tablero.Personaje.Mover(tecla);

            if (tecla == ConsoleKey.Escape)
            {
                tablero.Salir = true;
            }
           


            return tablero;
        }

    }
}
