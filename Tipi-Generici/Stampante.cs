using System;
using System.Collections.Generic;
using System.Text;

namespace Tipi_Generici
{
    class Stampante
    {

        //metodo stampa che vuole come argomento una stringa
        public void Stampa(string stringa)
        {
            Console.WriteLine("Stampa stringa: " + stringa);
        }

        //overload del primo metodo Stampa, in argomento ora c'è un int
        public void Stampa(int intero)
        {
            Console.WriteLine("Stampa int: " + intero);
        }

        //metodo generico, che fa uso di tipi generici e può accettare qualsiasi tipo come argomento
        public void Stampa<T>(T v)
        {
            Console.WriteLine("Stampa grazie a tipo generico: " + v);
        }

        //passaggio di due tipi generici, notare che il segnaposto T, può anche cambiare nome a proprio piacimento
        public void Stampa<S, T>(S s, T t)
        {
            Console.WriteLine("Stampa con due tipi generici, il primo: " + s + " il secondo: " + t);
        }

    }
}