namespace CampoMinado
{
    public class Tablero
    {




        public Personaje Personaje { get; set; }

        public Personaje Enemigo { get; set; }

        public Campo Campo { get; set; }

        public bool Salir { get; set; }

        public bool HayColision()
        {
            return this.Campo.Colision(this.Personaje);

        }

    }
}
