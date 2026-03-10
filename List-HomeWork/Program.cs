using List_HomeWork.Entities;

namespace List_HomeWork;

class Program
{
    static void Main(string[] args)
    {
        int flag = 0;
        int opt;

        while (flag == 0)
        {
            Console.Clear();
            Console.WriteLine("\n\t -- Tarea LINQ --\n");

            Console.WriteLine("Menú:\n");

            Console.WriteLine("1. Ejercicio: Sistema de Facturas.");
            Console.WriteLine("2. Ejercicio: Gestión de Empleados.");
            Console.WriteLine("3. Salir");

            Console.Write("\nIngrese su opción: ");

            if (int.TryParse(Console.ReadLine(), out opt))
            {
                Console.Clear();
                if (opt == 1)
                {
                    POS_Sistem();
                }
                else if(opt == 2)
                {
                    HR_Sistem();
                }
                else if(opt == 3)
                {
                    flag = 1;
                    Console.Write("\nPresiona cualquier tecla para finalizar.");
                    Console.ReadKey();
                }
            
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t ¡Error!\n");
                Console.WriteLine("Opción no válida :|");
                Console.Write("\nPresiona cualquier tecla para continuar. ➡️ ");
                Console.ReadKey();
            }
        }
    }

    static void POS_Sistem()
    {
        List<Factura> facturas = new List<Factura>{
            new Factura { Id = 1, NumeroFactura = "F-001", Cliente = "Nequi", Total = 1500000, Pagada = true },
            new Factura { Id = 2, NumeroFactura = "F-002", Cliente = "Bancolombia", Total = 3200000, Pagada = false },
            new Factura { Id = 3, NumeroFactura = "F-003", Cliente = "Claro", Total = 850000, Pagada = true },
            new Factura { Id = 4, NumeroFactura = "F-004", Cliente = "Ecopetrol", Total = 5000000, Pagada = false },
            new Factura { Id = 5, NumeroFactura = "F-005", Cliente = "Nutresa", Total = 450000, Pagada = true },
            new Factura { Id = 6, NumeroFactura = "F-006", Cliente = "Exito", Total = 1200000, Pagada = false },
            new Factura { Id = 7, NumeroFactura = "F-007", Cliente = "Avianca", Total = 950000, Pagada = true },
            new Factura { Id = 8, NumeroFactura = "F-008", Cliente = "Movistar", Total = 2100000, Pagada = false },
            new Factura { Id = 9, NumeroFactura = "F-009", Cliente = "Tigo", Total = 300000, Pagada = true },
            new Factura { Id = 10, NumeroFactura = "F-010", Cliente = "Argos", Total = 4800000, Pagada = false }
            };      

        int flag = 0;
        int option;

        while(flag == 0)
        {
            Console.Clear();
            Console.WriteLine("\n\t -- Menú --\n");

            Console.WriteLine("1. Mostrar todas las facturas.");
            Console.WriteLine("2. Mostrar solo las facturas NO pagadas.");
            Console.WriteLine("3. Calcular el total pendiente por pagar.");
            Console.WriteLine("4. Ordenarlas por total descendente.");
            Console.WriteLine("5. Mostrar las facturas mayores a un 1M.");
            Console.WriteLine("6. Salir.");

            Console.Write("\nIngrese su opción: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("\n\tTodas las facturas\n");

                    foreach (var factura in facturas)
                    {
                        Console.WriteLine($"[{factura.NumeroFactura}] Cliente: {factura.Cliente} | Total: ${factura.Total} | Pagada: {factura.Pagada}");
                    }
                    Console.Write("\nPresiona cualquier letra para continuar.");
                    Console.ReadKey();
                }
                else if(option == 2)
                {
                    Console.WriteLine("\n\tFacturas NO pagadas\n");

                    var facturasNoPagadas = facturas.Where(f => !f.Pagada);
                    foreach (var factura in facturasNoPagadas)
                    {
                        Console.WriteLine($"[{factura.NumeroFactura}] Cliente: {factura.Cliente} | Total: ${factura.Total}");
                    }

                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else if(option == 3)
                {
                    Console.WriteLine("\n\tTotal pendiente por pagar\n");

                    var totalPendiente = facturas.Where(f => !f.Pagada).Sum(f => f.Total);
                    Console.WriteLine($"Total a recaudar: ${totalPendiente}");

                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else if( option == 4)
                {
                    Console.WriteLine("\n\tFacturas ordenadas por total - Descendete\n");

                    var facturasOrdenadas = facturas.OrderByDescending(f => f.Total);
                    foreach (var factura in facturasOrdenadas)
                    {
                        Console.WriteLine($"[{factura.NumeroFactura}] Cliente: {factura.Cliente} | Total: ${factura.Total}");
                    }
                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();    
                }
                else if(option == 5)
                {
                    Console.WriteLine("\n\tFacturas mayores a 1M\n");
                    var facturasMayoresUnMillon = facturas.Where(f => f.Total > 1000000);
                    foreach (var factura in facturasMayoresUnMillon)
                    {
                        Console.WriteLine($"[{factura.NumeroFactura}] Cliente: {factura.Cliente} | Total: ${factura.Total}");
                    }
                }
                else if(option == 6 )
                {
                    flag = 1;
                    Console.Write("\nPresiona cualquier tecla para finalizar. ➡️ ");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t ¡Error!\n");
                Console.WriteLine("Opción no válida :|");
                Console.Write("\nPresiona cualquier tecla para continuar. ➡️ ");
                Console.ReadKey();
            }                                                                                        
        }

    }

    static void HR_Sistem()
    {
        
    }
}
