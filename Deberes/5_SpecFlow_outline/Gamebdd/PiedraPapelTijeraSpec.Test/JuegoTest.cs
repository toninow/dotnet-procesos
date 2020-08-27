using System;
using NUnit.Framework;
using PiedraPapelTijeraSpec.steps;
using TestMethod = NUnit.Framework.TestAttribute;

namespace PiedraPapelTijeraSpec.Test
{
    public class Tests
    {
        [TestMethod]
        public void ComputadoraPiedra_JugadorPapel_JugadorGana()
        {
            var juego = new Juego();
            juego.MueveJugador = "Piedra";
            Assert.AreEqual("Jugador Gana!", juego.Result());
        }

        [TestMethod]
        public void ComputadoraPiedra_JugadorTijera_ComputadoraGana()
        {
            var juego = new Juego();
            juego.MueveJugador = "Tijeras";
            Assert.AreEqual("Computadora Gana!", juego.Result());
        }

        [TestMethod]
        public void MuestraErrorSiNoMueveJugador()
        {
            var juego = new Juego();
            juego.Result();
        }
    }
}