using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHotel.clases
{
    public class Habitacion
    {
        public int NumeroHabitacion { get; private set; }
        public string TipoHabitacion { get; private set; }
        public string Estado { get; private set; }

        public Habitacion(int numeroHabitacion, string tipoHabitacion, double precioNoche)
        {
            NumeroHabitacion = numeroHabitacion;
            TipoHabitacion = tipoHabitacion;
            Estado = "Disponible";
        }

        public void CambiarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
        }


        public void MostrarInformacion()
        {
            Console.WriteLine($"Número de Habitación: {NumeroHabitacion}");
            Console.WriteLine($"Tipo de Habitación: {TipoHabitacion}");
            Console.WriteLine($"El estado de la habitación ahora es: {Estado}");
        }
    }
}

