using System;
using System.Threading;

namespace ThreadRacing
{


    
    public class CarrerasConHilos {
        private int i = 0;

        public static void Main (string[] args) {
            CarrerasConHilos threads = new CarrerasConHilos ();
        }

        public CarrerasConHilos () {
            // Creando nuestros dos hilos. El delegado de ThreadStart apunta a
            // el método que se está ejecutando en un nuevo hilo.
            Thread CorredorUno = new Thread (new ThreadStart (this.CorredorUno));
            Thread CorredorDos = new Thread (new ThreadStart (this.CorredorDos));
            Thread CorredorTres = new Thread (new ThreadStart (this.CorredorTres));
            Thread CorredorCuatro = new Thread (new ThreadStart (this.CorredorCuatro));
            Thread CorredorCinco = new Thread (new ThreadStart (this.CorredorCinco));
            Thread CorredorSeis = new Thread (new ThreadStart (this.CorredorSeis));
            Thread CorredorSiete = new Thread (new ThreadStart (this.CorredorSiete));
            Thread CorredorOcho = new Thread (new ThreadStart (this.CorredorOcho));

            //No pude encontrar el .exe para linux :,v, ya se que no existe pero quería que funcione de manera gráfica

            
            CorredorUno.Start ();
            Thread.Sleep (100);
            CorredorDos.Start ();
            Thread.Sleep (100);
            CorredorTres.Start ();
            Thread.Sleep (100);
            CorredorCuatro.Start ();
            Thread.Sleep (100);
            CorredorCinco.Start ();
            Thread.Sleep (100);
            CorredorSeis.Start ();
            Thread.Sleep (100);
            CorredorSiete.Start ();
            Thread.Sleep (100);
            CorredorOcho.Start ();
        }
        
        public void CorredorUno () {
            while(this.i < 100) {
                Console.WriteLine ("El primero corredor incremento sus pasos en "  + ++this.i);
                Thread.Sleep (100);
            }
        }
        public void CorredorDos () {
            while(this.i < 100) {
                Console.WriteLine ("El segundo corredor incremento sus pasos en "  + ++this.i);
                Thread.Sleep (100);
            }
        }
        public void CorredorTres () {
            while(this.i < 100) {
                Console.WriteLine ("El tercer corredor incremento sus pasos en " + ++this.i);
                Thread.Sleep (1000);
            }
        }
        public void CorredorCuatro () {
            while(this.i < 100) {
                Console.WriteLine ("El cuarto corredor incremento sus pasos en " + ++this.i);
                Thread.Sleep (100);
            }
        }
        public void CorredorCinco () {
            while(this.i < 100) {
                Console.WriteLine ("El quinto corredor incremento sus pasos en" + ++this.i);
                Thread.Sleep (100);
            }
        }
        public void CorredorSeis () {
            while(this.i < 100) {
                Console.WriteLine ("El sexto corredor incremento sus pasos en " +  + ++this.i);
                Thread.Sleep (100);
            }
        }
        public void CorredorSiete () {
            while(this.i < 100) {
                Console.WriteLine ("El septimo corredor incremento sus pasos en "  + ++this.i);
                Thread.Sleep (100);
            }
        }
        public void CorredorOcho () {
            while(this.i < 100) {
                Console.WriteLine ("El octavo corredor incremento sus pasos en "  + ++this.i);
                Thread.Sleep (100);
            }
        }
    }
}
