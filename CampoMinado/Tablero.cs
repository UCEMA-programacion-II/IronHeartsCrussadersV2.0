namespace CampoMinado
{
    public class Tablero
    {




        public Personaje Personaje { get; set; }

        public Personaje Enemigo1 { get; set; }

        public Personaje Enemigo2 { get; set; }

        public Personaje Enemigo3 { get; set; }

        public Campo Campo { get; set; }

        public bool Salir { get; set; }

        public bool HayColision()
        {
            return this.Campo.Colision(this.Personaje);

        }

    }
}
