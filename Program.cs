
using ProjectHotel.clases;

Console.WriteLine("=======================================================================");
Console.WriteLine("                           HOTEL PIPE KING                             ");
Console.WriteLine("=======================================================================\n");



Empleado empleadoTurno = new Empleado("Carlos Mendoza", "Recepcionista");
Console.WriteLine("--- Personal de Gestión ---");
empleadoTurno.MostrarInformacion();
Console.WriteLine();


Servicio restaurante = new Servicio("Restaurante", 35.0);
Servicio spa = new Servicio("Spa", 50.0);
Servicio lavanderia = new Servicio("Lavandería", 12.0);
Servicio parqueadero = new Servicio("Parqueadero", 10.0);


Categoria catVIP = new Categoria("VIP", 150.0);

catVIP.ServiciosDisponibles.Add(spa);
catVIP.ServiciosDisponibles.Add(parqueadero);

Categoria catEstandar = new Categoria("Estándar", 80.0);
catEstandar.ServiciosDisponibles.Add(restaurante);
catEstandar.ServiciosDisponibles.Add(lavanderia);


Habitacion habitacionAsignada = new Habitacion(304, "VIP", 150.0);

Console.WriteLine("--- Datos de la Habitación Creada ---");
habitacionAsignada.MostrarInformacion();
Console.WriteLine();


habitacionAsignada.CambiarEstado("Ocupada");
Console.WriteLine("-> Modificando estado por asignación de hospedaje:");
habitacionAsignada.MostrarInformacion();
Console.WriteLine("\n-----------------------------------------------------------------------\n");


Cliente clienteHuesped = new Cliente("Andrés Felipe Rey", 10987654, "andres.rey@correo.com");
Console.WriteLine("--- Datos del Cliente Registrado ---");
clienteHuesped.MostrarInformacion();
Console.WriteLine();


DateTime fechaIngreso = DateTime.Now;
DateTime fechaSalida = DateTime.Now.AddDays(4); 
Reserva nuevaReserva = new Reserva(fechaIngreso, fechaSalida, 2, catVIP);
Console.WriteLine($"-> Solicitud de Reserva creada con éxito para la categoría: {nuevaReserva.Categoria.NombreCategoria}");
Console.WriteLine("\n-----------------------------------------------------------------------\n");

nuevaReserva.AgregarServicio(restaurante);
nuevaReserva.AgregarServicio(spa);
nuevaReserva.AgregarServicio(lavanderia);
Console.WriteLine();

clienteHuesped.AgregarReserva(nuevaReserva);
Console.WriteLine("\n-----------------------------------------------------------------------\n");



double totalLiquidado = nuevaReserva.CalcularTotal();

Cobro cobroEstadia = new Cobro(totalLiquidado, "Tarjeta de Crédito");
Console.WriteLine("-> El proceso de cobro se ha registrado exitosamente en el sistema.");
Console.WriteLine("\n-----------------------------------------------------------------------\n");




Console.WriteLine("=================================================================");
Console.WriteLine("               INFORME GLOBAL DE OPERACIÓN HOTELERA              ");
Console.WriteLine("=================================================================");
Console.WriteLine($"Gestor del Sistema: {empleadoTurno.Nombre} | Cargo: {empleadoTurno.Cargo}");
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("ALOJAMIENTO:");
habitacionAsignada.MostrarInformacion();
Console.WriteLine("-----------------------------------------------------------------");

clienteHuesped.ListarReservas();

Console.WriteLine("-----------------------------------------------------------------");

cobroEstadia.GenerarFactura();
Console.WriteLine("=================================================================");

Console.ReadLine();
