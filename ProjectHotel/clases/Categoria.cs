using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHotel.clases
{
    public class Categoria
    {
        public string NombreCategoria { get; private set; }

        public double PrecioNoche { get; private set; }

        public List<Servicio> ServiciosDisponibles { get; private set; }

        public Categoria(string nombreCategoria, double precioNoche)
        {
            NombreCategoria = nombreCategoria;

            PrecioNoche = precioNoche;

            ServiciosDisponibles = new List<Servicio>();
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"===== CATEGORIA {NombreCategoria} =====");

            foreach (Servicio servicio in ServiciosDisponibles)
            {
                Console.WriteLine(servicio.NombreServicio);
            }

        }
    }
}
