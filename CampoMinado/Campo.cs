using System;
using System.Collections.Generic;

namespace CampoMinado
{
    public class Campo
    {
       


        public List<Punto> Elementos { get; set; }
        public Campo()
        {

            Inicializar();
        }


        public void Dibujar()
        {


            foreach (Punto p in this.Elementos)
            {
                Console.SetCursorPosition(p.X, p.Y);
                switch (p.Elemento)
                {
                    case 3:
                        {
                            Console.Write("=");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("||");
                            break;
                        }
                }



            }



        }


        private void Inicializar()
        {


            
            this.Elementos = new List<Punto>();

            //dibujo paredes verticales
            for (int i = 5; i < 25; i++)
            {
                Punto punto = new Punto();
                punto.Elemento = 4;
                punto.X = 5;
                punto.Y = i;
                this.Elementos.Add(punto);
            }

            for (int i = 6; i < 25; i++)
            {
                Punto punto = new Punto();
                punto.Elemento = 4;
                punto.X = 105;
                punto.Y = i;
                this.Elementos.Add(punto);
            }

            //dibujo paredes horizontales
            for (int i = 5; i < 107; i++)
            {
                Punto punto = new Punto();
                punto.Elemento = 3;
                punto.X = i;
                punto.Y = 5;
                this.Elementos.Add(punto);
            }

            for (int i = 5; i < 107; i++)
            {
                Punto punto = new Punto();
                punto.Elemento = 3;
                punto.X = i;
                punto.Y = 25;
                this.Elementos.Add(punto);
            }

                                           


                                  


        }
       


    }
}
