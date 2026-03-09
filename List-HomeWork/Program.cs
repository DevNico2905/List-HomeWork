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
        
    }

    static void HR_Sistem()
    {
        
    }
}
