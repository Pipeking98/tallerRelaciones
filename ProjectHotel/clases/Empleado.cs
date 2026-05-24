using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHotel.clases
{
    public class Empleado
    {
        public string Nombre { get; private set; }
        public string Cargo { get; private set; }

        public Empleado(string nombre, string cargo)
        {
            Nombre = nombre;
            Cargo = cargo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cargo: {Cargo}");
        }
    }
    
}
