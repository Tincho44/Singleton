using System;

namespace Library
{
    public class Greeter
    {
        public Greeter()
        {
            // Intentionally left blank
        }

        private static Greeter instance; // Atributo donde guardas la unica instancia que puede tener la clase
                                         // Es una instancia de Greeter, es un atributo de la clase

        // public static Greeter Instance
        // {
        //     get
        //     {
        //         if (instance == null)
        //         {
        //             instance = new Greeter();
        //         }

        //         return instance;
        //     }

        //     // Verifica si hay una instancia para que no puedas hacer mas instancias de la clase Greeter
        //     // Si quiero crear una nueva instancia de clase, me va a tirar la instancia que ya esta creada 
        // }

        // esto no va por que cuando se  hace el singleton, agarraba el constructo de Greeter y no de Singleton

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
