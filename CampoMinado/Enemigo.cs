using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
namespace CampoMinado
{
    public class Enemigo
    {
                        
            public Enemigo(int fila, int columna)
            {
                this.fila = fila;
                this.columna = columna;
              
               
            }


            private int fila;
            private int columna;
    

            public int X { get { return columna; } }
            public int Y { get { return fila; } }
            

            

            private void Borrar()
            {


                Console.SetCursorPosition(this.columna + 2, this.fila + 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 2, this.fila + 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 2, this.fila);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 2, this.fila - 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 2, this.fila - 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 1, this.fila + 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 1, this.fila + 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 1, this.fila);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 1, this.fila - 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna + 1, this.fila - 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna, this.fila + 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna, this.fila + 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna, this.fila);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna, this.fila - 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna, this.fila - 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 1, this.fila + 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 1, this.fila + 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 1, this.fila);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 1, this.fila - 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 1, this.fila - 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 2, this.fila + 2);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 2, this.fila + 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 2, this.fila);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 2, this.fila - 1);
                Console.Write(" ");
                Console.SetCursorPosition(this.columna - 2, this.fila - 2);
                Console.Write(" ");

            }
            
            public void CambiarUbicacion (){
         
                Borrar();
                Random rnd = new Random();
                this.columna = rnd.Next(9, 100);
                this.fila = rnd.Next(8, 23);

                Dibujar();

        
        }

            public void Dibujar()
            {
                    Borrar();

                Console.SetCursorPosition(this.columna + 1, this.fila + 1);
                Console.Write("O");
                Console.SetCursorPosition(this.columna - 1, this.fila - 1);
                Console.Write("O");
                Console.SetCursorPosition(this.columna + 1, this.fila - 1);
                Console.Write("O");
                Console.SetCursorPosition(this.columna - 1, this.fila + 1);
                Console.Write("O");
                Console.SetCursorPosition(this.columna + 1, this.fila);
                Console.Write("O");
                Console.SetCursorPosition(this.columna, this.fila + 1);
                Console.Write("O");
                Console.SetCursorPosition(this.columna - 1, this.fila);
                Console.Write("O");
                Console.SetCursorPosition(this.columna, this.fila - 1);
                Console.Write("O");
                Console.SetCursorPosition(this.columna, this.fila);
                Console.Write("X");


            }

            

                }

            }


        
    




