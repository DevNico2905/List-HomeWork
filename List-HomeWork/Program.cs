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
                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();  
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
        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado { Id = 1, Nombre = "Pedro", Departamento = "IT", Salario = 6000000, Activo = true },
            new Empleado { Id = 2, Nombre = "Ana", Departamento = "RRHH", Salario = 3500000, Activo = true },
            new Empleado { Id = 3, Nombre = "Luis", Departamento = "IT", Salario = 5500000, Activo = false },
            new Empleado { Id = 4, Nombre = "Marta", Departamento = "Ventas", Salario = 4200000, Activo = true },
            new Empleado { Id = 5, Nombre = "Juan", Departamento = "IT", Salario = 7000000, Activo = true },
            new Empleado { Id = 6, Nombre = "Elena", Departamento = "Contabilidad", Salario = 4800000, Activo = true },
            new Empleado { Id = 7, Nombre = "Diego", Departamento = "IT", Salario = 5200000, Activo = true },
            new Empleado { Id = 8, Nombre = "Sofía", Departamento = "Ventas", Salario = 3900000, Activo = false },
            new Empleado { Id = 9, Nombre = "Carlos", Departamento = "IT", Salario = 6500000, Activo = true },
            new Empleado { Id = 10, Nombre = "Lucía", Departamento = "RRHH", Salario = 3200000, Activo = true },
            new Empleado { Id = 11, Nombre = "Jorge", Departamento = "Contabilidad", Salario = 5100000, Activo = false },
            new Empleado { Id = 12, Nombre = "Valeria", Departamento = "Ventas", Salario = 4500000, Activo = true },
            new Empleado { Id = 13, Nombre = "Andrés", Departamento = "IT", Salario = 4900000, Activo = true },
            new Empleado { Id = 14, Nombre = "Beatriz", Departamento = "RRHH", Salario = 5800000, Activo = true },
            new Empleado { Id = 15, Nombre = "Ricardo", Departamento = "Ventas", Salario = 3000000, Activo = true }
        };

        int flag = 0;
        int option;

        while(flag == 0)
        {
            Console.Clear();
            Console.WriteLine("\n\t -- Menú --\n");

            Console.WriteLine("1. Mostrar solo empleados activos.");
            Console.WriteLine("2. Mostrar empleados del departamento 'IT'.");
            Console.WriteLine("3. Calcular el salario promedio.");
            Console.WriteLine("4. Mostrar el empleado con mayor salario.");
            Console.WriteLine("5. Contar cuántos ganan más de 5M.");
            Console.WriteLine("6. Agrupar empleados por departamento.");
            Console.WriteLine("7. Salir.");

            Console.Write("\nIngrese su opción: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("\n\tEmpleados Activos\n");

                    var activos = empleados.Where(e => e.Activo).ToList();
                    activos.ForEach(e => Console.WriteLine(e.Nombre));

                    Console.Write("\nPresiona cualquier letra para continuar.");
                    Console.ReadKey();
                }
                else if(option == 2)
                {
                    Console.WriteLine("\n\tEmpleados de IT\n");

                    var equipoIT = empleados.Where(e => e.Departamento == "IT").ToList();
                    equipoIT.ForEach(e => Console.WriteLine(e.Nombre));

                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else if(option == 3)
                {
                    Console.WriteLine("\n\tSalario Promedio\n");

                    double promedio = empleados.Average(e => e.Salario);
                    Console.WriteLine($"\nSalario promedio: {promedio:C}");

                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else if( option == 4)
                {
                    Console.WriteLine("\n\tEmpleado con mayor salario\n");

                    var empleadoTop = empleados.OrderByDescending(e => e.Salario).First();
                    Console.WriteLine($"\nEmpleado con mayor salario: {empleadoTop.Nombre} ({empleadoTop.Salario:C})");
                    
                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();    
                }
                else if(option == 5)
                {
                    Console.WriteLine("\n\t¿Cuántos ganan más de 5M?\n");
                    
                    int rico = empleados.Count(e => e.Salario > 5000000);
                    Console.WriteLine($"\nEmpleados que ganan más de 5M: {rico}");

                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();  
                }
                else if(option == 6)
                {
                    Console.WriteLine("\n\tEmpleados por departamento\n");
                    var grupos = empleados.GroupBy(e => e.Departamento);
                    foreach (var grupo in grupos)
                    {
                        Console.WriteLine($"Departamento: {grupo.Key}");
                        foreach (var emp in grupo)
                        {
                            Console.WriteLine($"- {emp.Nombre}");
                        }
                    }
                    Console.Write("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey(); 
                }
                else if(option == 7 )
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
}
