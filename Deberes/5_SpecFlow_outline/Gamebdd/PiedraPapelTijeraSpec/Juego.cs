using System;

namespace PiedraPapelTijeraSpec.steps
{
    public class Juego
    {
        public string _mueveJugador;
        public string MueveJugador
        {
            private get
            {
                if (String.IsNullOrEmpty(_mueveJugador))
                    throw new ArgumentNullException("MueveJugador");
                return _mueveJugador;
            }
            set
            {
                _mueveJugador = value;
            }
        }
 
        public string Result()
        {
            return MueveJugador == "Paper" ? "Player Wins!" : "Computer Wins!";
        }
    }
}