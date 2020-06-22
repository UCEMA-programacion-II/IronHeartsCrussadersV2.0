namespace CicloJuego
{
    static class CargarRecurso
    {
        public static CampoMinado.Tablero Ejecutar(CampoMinado.Tablero tablero)
        {
            tablero = new CampoMinado.Tablero();
            CampoMinado.Campo campo = new CampoMinado.Campo();
            CampoMinado.Personaje personaje = new CampoMinado.Personaje(10, 30, 'N');
            CampoMinado.Personaje enemigo = new CampoMinado.Personaje(10, 70, 'E');
            tablero.Campo = campo;
            tablero.Personaje = personaje;
            tablero.Enemigo = enemigo;
            return tablero;

        }
    }
}
