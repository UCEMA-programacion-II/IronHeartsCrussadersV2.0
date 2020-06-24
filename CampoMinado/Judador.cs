
namespace CampoMinado
{
    public class Jugador
    {
        public Jugador(string _nombre) {
            Nombre = _nombre;
            Puntaje = 0;
            puntos = 0;
        }

        public Jugador(string _nombre,int _puntaje)
        {
            Nombre = _nombre;
            Puntaje = _puntaje;
            puntos = _puntaje;
        }

        private int puntos;
        public string Nombre { get; }
        public int Puntaje { get; set; }

        public int sumauno() {
            this.puntos++;
            Puntaje = puntos;

            return puntos;
        }

    }
}
