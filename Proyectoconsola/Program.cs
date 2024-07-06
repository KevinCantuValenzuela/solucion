namespace Proyectoconsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola C# y GitHub");


            string nombre = "Kevin";
            Console.WriteLine(nombre);

            string[] nombres = new string[4];
            nombres[0] = "Kevin";
            nombres[1] = "Gale";
            nombres[2] = "Cristo";
            nombres[3] = "Francisco";

            Console.WriteLine(nombres[2]);

            Console.WriteLine();
            Console.WriteLine("mostrando todos los elementos del arreglo");
            Console.WriteLine();

            foreach (string nombreAlumno in nombres) 
            {
                Console.WriteLine(nombreAlumno);

            }






        }
    }
}
