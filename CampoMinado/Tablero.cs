namespace CampoMinado
{
    public class Tablero
    {


        public ListaJugadores jugadores{ get; set; }

        public Jugador jugador { get; set; }

        public Personaje Personaje { get; set; }

        public Enemigo Enemigo1 { get; set; }

        public Enemigo Enemigo2 { get; set; }

        public int Puntaje{get;set;}
       

        public Campo Campo { get; set; }

        public bool Salir { get; set; }

        public bool HayColision()
        {
            return this.Personaje.haycolision;

        }

    }
}
