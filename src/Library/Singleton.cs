using System;

namespace Library
{
    public class Singleton<T> where T : new() // T significa que puede ser cualquiera cualquier clase o interfaz
    {

        private Singleton()
        {
            
        }

        private static T instance;

        public static T GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}    

// Leer sobre tipo generico 
// Aparte de solo tener 1 instancia de clase, no se puede modificar, osea no hay setters. 
