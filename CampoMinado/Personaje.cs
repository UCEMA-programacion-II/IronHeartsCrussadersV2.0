using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace CampoMinado
{
    public class Personaje
    {


        public Personaje(int fila, int columna, char orientacion)
        {
            this.fila = fila;
            this.columna = columna;
            this.filaAnterior = fila;
            this.columnnaanterior = columna;
            this.orientacion = orientacion;
        }
        private char orientacion;
        private  int fila;
        private int  columna;
        private int filaAnterior;
        private int columnnaanterior;
        


        public int X { get { return columna; } }
        public int Y { get { return fila; } }
        public char O { get { return orientacion; } }
        
        public bool haycolision {get; set;}
        public void Mover(ConsoleKey tecla)
        {

            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    {

                        if (this.fila - 2 > 6)
                        {
                            this.filaAnterior = this.fila;
                            this.columnnaanterior = this.columna;
                            this.fila -= 1;
                        }
                        
                        this.orientacion = 'N';
                        break;
                    }

                case ConsoleKey.DownArrow:
                    {

                        if (this.fila + 2 < 24)
                        {
                            this.filaAnterior = this.fila;
                            this.columnnaanterior = this.columna;
                            this.fila += 1;
                        }
                        this.orientacion = 'S';
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        if (this.columna - 2 > 7) { 
                        this.filaAnterior = this.fila;
                        this.columnnaanterior = this.columna;
                        this.columna -= 1;
                    }
                        this.orientacion = 'E';
                        

                        break;
                    }

                case ConsoleKey.RightArrow:
                    {

                        this.filaAnterior = this.fila;
                        this.columnnaanterior = this.columna;
                        this.orientacion = 'O';
                        this.columna += 1;


                        break;

                    }
                //case ConsoleKey.Spacebar:
                //    {
                //        Parallel.Invoke(() => Disparar()); 
                //        break;
                //    }


            }

        }

        public void Dibujar()
        {

            Borrar();


            switch (this.orientacion)
            {
                case 'N':
                    DibujarN();

                    break;

                case 'S':
                    DibujarS();

                    break;

                case 'E':
                    DibujarE();
                    break;
                case 'O':
                    DibujarO();
                    break;


            }


        }

        private void Borrar()
        {


            Console.SetCursorPosition(this.columnnaanterior + 2, this.filaAnterior + 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 2, this.filaAnterior + 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 2, this.filaAnterior);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 2, this.filaAnterior - 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 2, this.filaAnterior - 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 1, this.filaAnterior + 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 1, this.filaAnterior + 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 1, this.filaAnterior);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 1, this.filaAnterior - 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior + 1, this.filaAnterior - 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior, this.filaAnterior + 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior, this.filaAnterior + 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior, this.filaAnterior);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior, this.filaAnterior - 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior, this.filaAnterior - 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 1, this.filaAnterior + 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 1, this.filaAnterior + 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 1, this.filaAnterior);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 1, this.filaAnterior - 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 1, this.filaAnterior - 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 2, this.filaAnterior + 2);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 2, this.filaAnterior + 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 2, this.filaAnterior);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 2, this.filaAnterior - 1);
            Console.Write(" ");
            Console.SetCursorPosition(this.columnnaanterior - 2, this.filaAnterior - 2);
            Console.Write(" ");

        }

        private void DibujarN()
        {

            Console.SetCursorPosition(this.columna, this.fila - 2);
            Console.Write("*");
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
            Console.Write("*");
            Console.SetCursorPosition(this.columna - 1, this.fila);
            Console.Write("O");
            Console.SetCursorPosition(this.columna, this.fila - 1);
            Console.Write("*");
            Console.SetCursorPosition(this.columna, this.fila);
            Console.Write("*");


        }

        private void DibujarS()
        {

            Console.SetCursorPosition(this.columna, this.fila + 2);
            Console.Write("*");
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
            Console.Write("*");
            Console.SetCursorPosition(this.columna - 1, this.fila);
            Console.Write("O");
            Console.SetCursorPosition(this.columna, this.fila - 1);
            Console.Write("*");
            Console.SetCursorPosition(this.columna, this.fila);
            Console.Write("*");


        }

        private void DibujarE()
        {

            Console.SetCursorPosition(this.columna - 2, this.fila);
            Console.Write("*");
            Console.SetCursorPosition(this.columna + 1, this.fila + 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna - 1, this.fila - 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna + 1, this.fila - 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna - 1, this.fila + 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna + 1, this.fila);
            Console.Write("*");
            Console.SetCursorPosition(this.columna, this.fila + 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna - 1, this.fila);
            Console.Write("*");
            Console.SetCursorPosition(this.columna, this.fila - 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna, this.fila);
            Console.Write("*");


        }

        private void DibujarO()
        {

            Console.SetCursorPosition(this.columna + 2, this.fila);
            Console.Write("*");
            Console.SetCursorPosition(this.columna + 1, this.fila + 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna - 1, this.fila - 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna + 1, this.fila - 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna - 1, this.fila + 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna + 1, this.fila);
            Console.Write("*");
            Console.SetCursorPosition(this.columna, this.fila + 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna - 1, this.fila);
            Console.Write("*");
            Console.SetCursorPosition(this.columna, this.fila - 1);
            Console.Write("O");
            Console.SetCursorPosition(this.columna, this.fila);
            Console.Write("*");


        }

        public void Disparar(int x,int y, char o,int xe1,int ye1,int xe2,int ye2)
        {

            Borrar();



            switch (o)
            {
                case 'N':
                    DispararN(x,y,xe1,ye1,xe2,ye2);

                    break;

                case 'S':
                    DispararS(x,y,xe1,ye1,xe2,ye2);

                    break;

                case 'E':
                    DispararE(x,y,xe1,ye1,xe2,ye2);
                    break;

                case 'O':
                    DispararO(x,y,xe1,ye1,xe2,ye2);
                    break;



            }



        }


        private void DispararE(int x,int y,int xe1,int ye1,int xe2,int ye2)
        {
            



            for (int i = x; i > 6; i--)
            {
                DibujarE();

                if ((i== xe1 && y ==ye1)||((i== xe2 && y ==ye2))){
                Console.SetCursorPosition(i + 1, y);
                Console.Write(" ");
                this.haycolision= true;

                break;
                }
                else {this.haycolision=false;}



                Console.SetCursorPosition(i + 1, y);
                Console.Write(" ");

                Console.SetCursorPosition(i, y);
                Console.Write("o");
                Thread.Sleep(18);
               
                
                if (i < 8)
                {
                    Console.SetCursorPosition(7, y);
                    Console.Write(" ");
                  
                }




            }

        }

        private void DispararO(int x,int y,int xe1,int ye1,int xe2,int ye2)
        {
            for (int i =x; i < 105; i++)
            {
                
                DibujarO();

                
                
                if ((i== xe1 && y ==ye1)||((i== xe2 && y ==ye2))){
                Console.SetCursorPosition(i - 1, y);
                Console.Write(" ");
                this.haycolision= true;
                    

                break;
                }
                else {this.haycolision=false;}


                
                Console.SetCursorPosition(i - 1, y);
                
                Console.Write(" ");

                Console.SetCursorPosition(i,y);
                Console.Write("o");

                Thread.Sleep(7);


                if (i > 103)
                {
                    Console.SetCursorPosition(104, y);
                    Console.Write(" ");

                }

            }

        }


        private void DispararN(int x,int y,int xe1,int ye1,int xe2,int ye2)
        {
            
            for (int i = y; i > 5; i--)
            {
                DibujarN();


                   if ((x== xe1 && i ==ye1)||((x== xe2 && i ==ye2))){
                
                    Console.SetCursorPosition(x, i + 1);
                    Console.Write(" ");
                    this.haycolision= true;
                    break;
                
                }
                else {this.haycolision=false;}


                Console.SetCursorPosition(x, i + 1);
                Console.Write(" ");

                Console.SetCursorPosition(x, i);
                Console.Write("o");
                Thread.Sleep(25);


                if (i < 7)
                {
                    Console.SetCursorPosition(x, 6);
                    Console.Write(" ");

                }

            }

        }


        private void DispararS(int x,int y,int xe1,int ye1,int xe2,int ye2)
        {
                                 
            for (int i = y; i < 26; i++)
            {
                DibujarS();
                  if ((x== xe1 && i ==ye1)||((x== xe2 && i ==ye2))){
                 Console.SetCursorPosition(x, i - 1);
                Console.Write(" ");
                this.haycolision= true;

                    break;
                
                }
                else {this.haycolision=false;}


                Console.SetCursorPosition(x, i - 1);
                Console.Write(" ");

                Console.SetCursorPosition(x, i);
                Console.Write("o");
                Thread.Sleep(25);


                if (i > 24)
                {
                    Console.SetCursorPosition(x, 24);
                    Console.Write(" ");

                }

            }

        }


    }
}
