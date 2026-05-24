using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHotel.clases
{
    public class Reserva
    {
        public DateTime FechaIngreso { get; private set; }

        public DateTime FechaSalida { get; private set; }
        public Categoria Categoria { get; private set; }
        public List<Servicio> ServiciosAgregados { get; private set; }

        public int CantidadNoches { get; private set; }
        public int CantidadPersonas { get; private set; }
        public string Estado { get; private set; }

        public Reserva(DateTime fechaIngreso, DateTime fechaSalida, int cantidadPersonas, Categoria categoria)
        {
            FechaIngreso = fechaIngreso;

            FechaSalida = fechaSalida;

            CantidadNoches = (FechaSalida - FechaIngreso).Days;

            ServiciosAgregados = new List<Servicio>();

            Categoria = categoria;

            CantidadPersonas = cantidadPersonas;

            Estado = "Pendiente";
        }


        public double CalcularTotal()
        {
            double total = CantidadNoches * Categoria.PrecioNoche;

            foreach (Servicio servicio in ServiciosAgregados)
            {
                total += servicio.PrecioServicio;
            }

            return total;
        }

        public void AgregarServicio(Servicio servicio)
        {
            ServiciosAgregados.Add(servicio);

            Console.WriteLine($"Servicio {servicio.NombreServicio} agregado correctamente.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Fecha de Salida: {FechaSalida.ToShortDateString()}");
            Console.WriteLine($"Cantidad de Noches: {CantidadNoches}");
            Console.WriteLine($"Cantidad de Personas: {CantidadPersonas}");
            Console.WriteLine($"Categoría: {Categoria.NombreCategoria}");
            Console.WriteLine($"Estado de la Reserva: {Estado}");
            Console.WriteLine("Servicios Agregados:");
            foreach (Servicio servicio in ServiciosAgregados)
            {
                Console.WriteLine($"- {servicio.NombreServicio} (${servicio.PrecioServicio})");
            }
        }
    }
}
