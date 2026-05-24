using System;
using System.Collections.Generic;

namespace ProjectHotel.clases
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public int Cedula { get; private set; }
        public string Correo { get; private set; }

        public List<Reserva> Reservas { get; private set; }

        public Cliente(string nombre, int cedula, string correo)
        {
            Nombre = nombre;
            Cedula = cedula;
            Correo = correo;

            Reservas = new List<Reserva>();
        }

        public void AgregarReserva(Reserva reserva)
        {
            Reservas.Add(reserva);
            Console.WriteLine("Reserva agregada correctamente.");
        }

        public void ListarReservas()
        {
            if (Reservas.Count == 0)
            {
                Console.WriteLine("Este cliente no tiene reservas.");
                return;
            }

            Console.WriteLine($"Reservas del cliente {Nombre}:");

            foreach (var reserva in Reservas)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Ingreso: {reserva.FechaIngreso}");
                Console.WriteLine($"Salida: {reserva.FechaSalida}");
                Console.WriteLine($"Noches: {reserva.CantidadNoches}");
                Console.WriteLine($"Personas: {reserva.CantidadPersonas}");
                Console.WriteLine($"Estado: {reserva.Estado}");
                Console.WriteLine($"Total: {reserva.CalcularTotal()}");
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cédula: {Cedula}");
            Console.WriteLine($"Correo: {Correo}");
        }
    }
}