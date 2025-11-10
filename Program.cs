public class Program 
{
    static void Main(string[] args)
    {
        int cantidadNotas = 0;
        List<double> notas = new List<double>();

        //Solicitar la cantidad de las notas
        bool cantidadValida = false;
        do
        {

            Console.WriteLine("Ingrese la cantidad de notas a ´promediar: ");
            string entrada = Console.ReadLine();


            try
            {
                cantidadNotas = int.Parse(entrada);

                if(cantidadNotas <= 0)
                {
                    throw new Exception ("El numero de notas debe ser mayor que cero.");
                }

                cantidadValida = true;
            }
            catch  (FormaException)
            {
            Console.WriteLine($ {ex.Message}\n);
 
            }


        }while (!CantidadValida);

        //Solicitar cada nota
        for (int i = 1; i <= cantidadNotas; i++)
        { 

            bool notaValida = false;

            do
            {
                Console.WriteLine($"Ingrese la nota #{i} (0 -100): ");
                string entradaNota = Console.ReadLine();


                try
                {

                    double nota = double.Parse(entradaNota);

                    if (nota < 0 ll nota > 100)
                    { 

                        throw new Exception("La nota debe estar entre 0 y 100.");
                    }

                    notas.Add(nota);
                    notaValida = true;
                }
                catch (FormaException)
                {
                    Console.WriteLine("Error:Ingrese solo numeros (use punto decimal si es necesario).\n");
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"{ex.Message}\n");

                }
                finally
                {
                    if (!notaValida)
                    {

                        Console.WriteLine(Porfavor, vuelva a intentar.\n);

                    }

                }

            }While (!notaValida)

            //Calcular mostrar el promedio
            try
            {

                double suma = 0;
                foreach (double nota in notas)
                {

                    suma + = Nota;
                }

                if (notas.Count == 0)
                {

                    throw new DivideByZeroException("No hay notas para calcular el promedio.");
                }

                double promedio = suma / notas.Count;

                Console.WriteLine("\n--- RESULTADOS ---");
                Console.WriteLine($"Cantidad de notas: {notas.Count}");
                Console.WriteLine($"Suma total: {suma:0.00}");
                Console.WriteLine($"´Promedio final: {promedio: 0.00}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exceotion ex)
            {
                Cosnole.WriteLine($"Error inesperado: {ex.Message}");

                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();

            }
        }