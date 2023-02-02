namespace HelloWorld{
    class Helper{

        public static void Saludar(){
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hola, {Program.NOMBRE}. Hoy es {currentDate:D} y son las {currentDate:t}");
        }
        public static void GuardarEnArchivo(string nombreArchivo, string texto)
        {
            File.WriteAllText(nombreArchivo, texto);
            Console.WriteLine("\nTexto guardado correctamente en: " + nombreArchivo);
        }
        public static void AñadirEnArchivo(string nombreArchivo, string texto)
        {
            File.AppendAllText(nombreArchivo, texto);
            Console.WriteLine("\nTexto añadido correctamente en: " + nombreArchivo);
        }
        public static string LeerDeArchivo(string nombreArchivo)
        {
            string textoLeido = File.ReadAllText(nombreArchivo);
            return textoLeido;
        }
        public static void QueTeclaEs(ConsoleKeyInfo tecla){
            Console.WriteLine("\nHas pulsado la tecla: " + tecla.Key.ToString() + "\n");
        }
        public static void GuardarSumaEnArchivo(string nombreArchivoEntrada, string nombreArchivoSalida){

        string[] lineas = File.ReadAllLines(nombreArchivoEntrada);
        int[] numeros = new int[lineas.Length];

        int suma = 0;
        for (int i = 0; i < lineas.Length; i++)
        {
            numeros[i] = Int32.Parse(lineas[i]);
            suma += numeros[i];
        }
            GuardarEnArchivo(nombreArchivoSalida,suma.ToString());
        }
    }
}