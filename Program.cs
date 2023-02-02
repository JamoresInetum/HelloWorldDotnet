namespace HelloWorld
{
    class Program
    {
        public const string NOMBRE = "Joel";
        public const string FICHERO = "Fichero.txt";
        public const string RESULTADO_SUMA = "Resultado_suma.txt";
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Helper.Saludar();

            do
            {
                Console.WriteLine("###### MENÚ ######");

                // Muestra las opciones de menú
                Console.WriteLine("E: Escribir");
                Console.WriteLine("A: Añadir texto");
                Console.WriteLine("L: Leer");
                Console.WriteLine("O: Operar");
                Console.WriteLine("T: Valor tecla");
                Console.WriteLine("S: Salir");
                Console.WriteLine("#################");

                // Leo la tecla
                tecla = Console.ReadKey();

                // Compruebo su valor
                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Console.WriteLine("\n¿Qué texto quieres guardar?");
                        string textoParaGuardar = Console.ReadLine();
                        Helper.GuardarEnArchivo(FICHERO, textoParaGuardar);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.A:
                        Console.WriteLine("\n¿Qué texto quieres añadir?");
                        string textoParaAñadir = Console.ReadLine();
                        Helper.AñadirEnArchivo(FICHERO, "\n" + textoParaAñadir);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.L:
                        Console.WriteLine("\nEl texto leído es: \n\n" + Helper.LeerDeArchivo(FICHERO));
                        Console.ReadKey();
                        break;

                    case ConsoleKey.O:
                        // Console.WriteLine("En proceso...");
                        Helper.GuardarSumaEnArchivo(FICHERO, RESULTADO_SUMA);
                        Console.ReadKey();
                        break;

                    case ConsoleKey.T:
                        Console.WriteLine("\nPulsa una tecla...");
                        tecla = Console.ReadKey();
                        Helper.QueTeclaEs(tecla);
                        Console.ReadKey();
                        break;

                    default:
                        if (tecla.Key == ConsoleKey.S)
                        {
                            Console.WriteLine($"\nHasta luego, {NOMBRE}");
                        }
                        else
                        {
                            Console.WriteLine("\nNo es una tecla válida");
                        }
                        break;
                }

            } while (tecla.Key != ConsoleKey.S);
        }
    }
}
