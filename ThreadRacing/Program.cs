using System;
using System.Threading;

namespace ThreadRacing
{


    
    /**public class CarrerasConHilos {
        private int i = 0;

        public static void Main (string[] args) {
            CarrerasConHilos threads = new CarrerasConHilos ();
        }

        public CarrerasConHilos () {
            // Creando nuestros dos hilos. El delegado de ThreadStart apunta a
            // el método que se está ejecutando en un nuevo hilo.
            Thread CorredorUno = new Thread (new ThreadStart (this.CorredorUno));
            Thread CorredorDos = new Thread (new ThreadStart (this.CorredorDos));
            //Thread CorredorTres = new Thread (new ThreadStart (this.CorredorTres));
            //Thread CorredorCuatro = new Thread (new ThreadStart (this.CorredorCuatro));
            //Thread CorredorCinco = new Thread (new ThreadStart (this.CorredorCinco));
            //Thread CorredorSeis = new Thread (new ThreadStart (this.CorredorSeis));
            //Thread CorredorSiete = new Thread (new ThreadStart (this.CorredorSiete));
            //Thread CorredorOcho = new Thread (new ThreadStart (this.CorredorOcho));


            // Starting our two threads. Thread.Sleep(10) gives the first Thread
            // 10 miliseconds more time.
            CorredorUno.Start ();
            Thread.Sleep (100);
            CorredorDos.Start ();
            Thread.Sleep (100);
            //CorredorTres.Start ();
            //Thread.Sleep (100);
            //CorredorCuatro.Start ();
            //Thread.Sleep (100);
            //CorredorCinco.Start ();
            //Thread.Sleep (100);
            //CorredorSeis.Start ();
            //Thread.Sleep (100);
            //CorredorSiete.Start ();
            //Thread.Sleep (100);
            //CorredorOcho.Start ();
        }

        // This method is being excecuted on the first thread.
        public void CorredorUno () {
            while(this.i < 100) {
                Console.WriteLine ("First runner incrementing i from "  + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
        public void CorredorDos () {
            while(this.i < 100) {
                Console.WriteLine ("Second runner incrementing i from "  + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
        /**public void CorredorTres () {
            while(this.i < 100) {
                Console.WriteLine ("co3 " + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (1000);
            }
        }
        public void CorredorCuatro () {
            while(this.i < 100) {
                Console.WriteLine ("co4 " + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
        public void CorredorCinco () {
            while(this.i < 100) {
                Console.WriteLine ("co5 " + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
        public void CorredorSeis () {
            while(this.i < 100) {
                Console.WriteLine ("co6 " +  + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
        public void CorredorSiete () {
            while(this.i < 100) {
                Console.WriteLine ("co7 "  + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
        public void CorredorOcho () {
            while(this.i < 100) {
                Console.WriteLine ("co8 "  + ++this.i);
                // This avoids that the first runner does all the work before
                // the second one has even started. (Happens on high performance
                // machines sometimes.)
                Thread.Sleep (100);
            }
        }
    }**/
}
