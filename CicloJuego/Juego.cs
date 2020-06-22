using System;
using System.Threading;
using System.Threading.Tasks;

namespace CicloJuego
{
    public class Juego
    {
        private CampoMinado.Tablero tablero;
        public void jugar()
        {

            Console.CursorVisible = false;


            this.tablero = CargarRecurso.Ejecutar(this.tablero);





            do
            {
                


                Dibujar.ejecutar(this.tablero);

                this.tablero = Actualizar.ejecutar(this.tablero);





            } while (!this.tablero.Salir);

            this.tablero = DescargarRecurso.ejecutar(this.tablero);


            Salir.ejecutar();



        }


       


    }
}
