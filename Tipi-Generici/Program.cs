using System;

namespace Tipi_Generici
{
    class Program
    {
        static void Main(string[] args)
        {
            Stampante printer = new Stampante();

            //stampa una stringa grazie all'overload (firma diversa) metodo Stampa
            printer.Stampa("Marco");

            //stampa un int grazie sempre all'overload (firma diversa) del metodo Stampa
            printer.Stampa(30);

            //stampa un qualsiasi tipo specificato grazie all'uso di un tipo generico
            printer.Stampa<double>(5.20); //potresti anche omettere la specifica del tipo passato (ossia <char>) perché grazie all'"inferenza di tipo" il compilatore lo riconosce da solo

            //uso di due tipi generici
            printer.Stampa<string, int>("Anno", 1920);

            Console.ReadLine();
        }
    }
}