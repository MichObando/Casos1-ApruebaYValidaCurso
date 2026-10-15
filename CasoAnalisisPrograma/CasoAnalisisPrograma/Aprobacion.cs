class Aprobacion
{
    public static void Main()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("      APROBAR NOTA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Ingrese la nota final del estudiante:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        decimal nota = decimal.Parse(Console.ReadLine());

        if (nota >= 0 && nota <= 100)
        {
            if (nota >= 70)
            {
                Console.WriteLine();
                Console.WriteLine("=====================================");
                Console.WriteLine("El estudiante aprobo");
                Console.WriteLine("=====================================");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("=====================================");
                Console.WriteLine("El estudiante reprobo");
                Console.WriteLine("=====================================");
            }
        }
        else
        {
            Console.WriteLine("La nota ingresada es incorrecta");
        }
    }
}