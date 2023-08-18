using Glamping.Logica;

Console.WriteLine("========================== GLAMPING BOOKING SYSTEM ==========================\n");

{
    List<Factura> reservas = new List<Factura>();
    try
    {
        while (true)
        {
            Console.WriteLine("\n\t============ Menú ============");
            Console.WriteLine("\t| 1. Agregar reserva         |");
            Console.WriteLine("\t| 2. Ver reservas y factura  |");
            Console.WriteLine("\t| 3. Salir                   |");
            Console.WriteLine("\t==============================\n\n\n");
            Console.Write("Seleccione una opción: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    Console.Write(" > Ingrese el nombre del reservante: ");
                    string nombre = Console.ReadLine();

                    Console.Write(" > Ingrese el apellido del reservante: ");
                    string apellido = Console.ReadLine();

                    Console.Write(" > Ingrese su correo: ");
                    string correo = Console.ReadLine();

                    Console.Write(" > Ingrese un número celular de contacto: ");
                    int celular = int.Parse(Console.ReadLine());

                    Console.Write(" > Ingrese la cantidad de Adultos: ");
                    int Adultos1 = int.Parse(Console.ReadLine());

                    Console.Write(" > Ingrese la cantidad de Niños: ");
                    int Niños1 = int.Parse(s: Console.ReadLine());  // Lee la cantidad de huéspedes desde la consola

                    Console.Write(" > Ingrese cuantos días va a reservar \n   [MINIMO 2 - MAXIMO 4 DÍAS]: ");
                    int dias = int.Parse(Console.ReadLine());

                    Console.Write(" > Ingrese el número de habitaciones que desea: ");
                    int numeroHabitaciones = int.Parse(Console.ReadLine());

                    Console.Write(" > Ingrese el día que se realizará la reserva \n   [JUEVES VIERNES, SABADO O DOMINGO]: ");
                    string diaReserva = Console.ReadLine();

                    Console.Write(" > Ingrese la forma en que realizara el pago \n   [EFECTIVO, TRANSFERENCIA, TARJETA DE CREDITO]: ");
                    string formaPago = Console.ReadLine();
                    Console.WriteLine("\n=============================================================================\n\n\n");

                    var factura = new Factura()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Correo = correo,
                        Celular = celular,
                        Adultos = Adultos1,
                        Niños = Niños1,
                        Dias = dias,
                        Habitaciones = numeroHabitaciones,
                        Dia = diaReserva,
                        FormaPago = formaPago,

                    };
                    reservas.Add(factura);
                    break;
                case 2:
                    Console.WriteLine("========================== SISTEMA DE RESERVAS GLAMPING ==========================\n");
                    Console.WriteLine("Reservas ingresadas:\n");

                    foreach (var reserva in reservas)
                    {
                        Console.WriteLine(reserva);
                    }

                    Console.WriteLine("\n==============================================\n\n\n");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa.");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR: [{ex.Message}]");
    }
}