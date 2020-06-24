using System;
using System.Collections.Generic;
using System.IO;

namespace CampoMinado
{
    public class ListaJugadores
    {


        public string nombre { get; set; }
        public int puntaje { get; set; }
        public List<Jugador> jugadores = new List<Jugador>();




        public Jugador DevuelveJugador(string nombre) {

            foreach (var j in jugadores) {
                if (j.Nombre == nombre) {

                    return j;
                    
                }
                
            }
            AgregarJugador(nombre);
            return jugadores[jugadores.Count-1];

        }



    


        public void AgregarJugador(string nombre)
        {


            Jugador jugador = new Jugador(nombre);

            jugadores.Add(jugador);

        }
                
        public void CargarArchivo()
        {
          
            

                               
            string basepath = Environment.CurrentDirectory;
            string path = basepath+ @"\jugadores.txt";
           
            
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Mariano-4565484");
                   
                    sw.Close();
                }
            }

           


             


            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    

                    string[] partes = s.Split('-');

                    try
                    {

                        Jugador jugador = new Jugador(partes[0], Int32.Parse(partes[1]));
                        jugadores.Add(jugador);
                    }
                    catch (FormatException)
                    {

                        Jugador jugador = new Jugador(partes[0]);
                        jugadores.Add(jugador);
                    }

            



                }
            }
        }

        public void GuardarArchivo() {

            string basepath = Environment.CurrentDirectory;
            string path = basepath + @"\jugadores.txt";


            using (StreamWriter sw2 = File.CreateText(path)) {

                foreach (var j in jugadores)
                {

                    sw2.WriteLine($"{j.Nombre}-{j.Puntaje}");

                }
                sw2.Close();


            }


        }





    }
}
            


           



                    






                    





                
       


    

