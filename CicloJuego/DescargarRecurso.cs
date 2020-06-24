namespace CicloJuego
{
    static class DescargarRecurso
    {
        public static CampoMinado.Tablero ejecutar(CampoMinado.Tablero tablero)
        {
            tablero.jugadores.GuardarArchivo();
            tablero = null;
            return tablero;

        }
    }
}
