using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHotel.clases
{
    public class Cobro
    {
        public double MontoTotal { get; private set; }
        public string MetodoPago { get; private set; }
        public string Estado { get; private set; }

        public Cobro(double montoTotal, string metodoPago)
        {
            MontoTotal = montoTotal;
            MetodoPago = metodoPago;
            Estado = "Pendiente";
        }

        public void GenerarFactura()
        {
            Console.WriteLine("===== FACTURA =====");
            Console.WriteLine($"Monto Total: ${MontoTotal}");
            Console.WriteLine($"Método de Pago: {MetodoPago}");
            Console.WriteLine($"Estado del Cobro: {Estado}");
        }
    }
}
