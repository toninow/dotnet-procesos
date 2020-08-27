using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Collections.Generic;


namespace PiedraPapelTijeraSpec.steps
{
    [Binding]
    public class JuegoSteps
    {
        
        private const string GameKey = "juego";

        [Given(@"la computadora escoge secretamente roca")]
        [System.Obsolete]
        public void LaComputadoraEscogeSecretamenteRoca()
        {
            var juego = new Juego();
            ScenarioContext.Current.Add(GameKey, juego);
        }

        [When(@"Yo escojo papel")]
        [System.Obsolete]
        public void YoEscojoPapel()
        {
            var juego = ScenarioContext.Current.Get<Juego>();
            juego.MueveJugador = "Papel";
        }

        [When(@"Yo escojo tijeras")]
        [System.Obsolete]
        public void YoEscojoTijeras()
        {
            var juego = ScenarioContext.Current.Get<Juego>();
            juego.MueveJugador = "Tijeras";
        }

        [Then(@"el resultado deberia ser ""ganaste humano!""")]
        [System.Obsolete]
        public void ElResultadoDeberiaSerHumanoGana()
        {
            var juego = ScenarioContext.Current.Get<Juego>();
            Assert.AreEqual("ganaste humano!", juego.Result());
        }

        [Then(@"el resultado deberia ser ""ganaste Computadora!""")]
        [System.Obsolete]
        public void ElResultadoDeberiaSerComputadoraGana()
        {
            var juego = ScenarioContext.Current.Get<Juego>();
            Assert.AreEqual("ganaste Computadora!", juego.Result());
        }

    }

}
