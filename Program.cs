namespace HelloWorld
{
    class Program
    {
        public const int OPCIONES = 4;
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.WriteLine("¿Cómo te llamas?");
            var nombre = Console.ReadLine();
            var currentDate = DateTime.Now;

            // Muestra el nombre y la fecha actuales
            Console.WriteLine($"{Environment.NewLine}Hola, {nombre}. Hoy es {currentDate:D} y son las {currentDate:t}");

            // Mantiene el ciclo mientras no se pulse la tecla A
            do
            {
                Console.WriteLine("###### MENÚ ######");
                
                // Muestra las opciones de menú
                for (int i = 0; i < OPCIONES; i++)
                {
                    Console.WriteLine($"Opcion {i}: Pinta {i}");
                }

                Console.WriteLine("###### #### ######");

                // Leo la tecla
                tecla = Console.ReadKey();
                
                // Compruebo su valor
                switch (tecla.Key)
                {
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        new Metodos().Numero(0);
                        break;

                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        new Metodos().Numero(1);
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        new Metodos().Numero(2);
                        break;

                    default:
                        break;
                }

                Console.WriteLine("\nTecla: " + tecla.Key.ToString() + "\n");

                // Pulsar tecla para volver al menú siempre que no se haya puesto la A
                if (tecla.Key != ConsoleKey.A)
                {
                    Console.WriteLine("Pulsa una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (tecla.Key != ConsoleKey.A);
        }

        public class Metodos
        {
            public void Numero(int numero)
            {
                Console.WriteLine($"\nEl numero enviado es :{numero}");
            }
        }
    }
}
