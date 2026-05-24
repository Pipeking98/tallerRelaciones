using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHotel.clases
{
    public class Servicio
    {
       
            public string NombreServicio { get; private set; }

            public double PrecioServicio { get; private set; }

            public Servicio(string nombre, double precio)
            {
                NombreServicio = nombre;

                PrecioServicio = precio;
            }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Servicio: {NombreServicio}");
            Console.WriteLine($"Precio del servicio: ${PrecioServicio}");
        }

    }
}
