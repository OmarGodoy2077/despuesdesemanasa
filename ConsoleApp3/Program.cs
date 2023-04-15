void matrix()
{
    Console.Write("Ingrese la cantidad de alumnos: ");
    int cantidadAlumnos = int.Parse(Console.ReadLine());

    string[] nombres = new string[cantidadAlumnos];
    int[] notas = new int[cantidadAlumnos];

    for (int i = 0; i < cantidadAlumnos; i++)
    {
        Console.Write("Ingrese el nombre del alumno " + (i + 1) + ": ");
        nombres[i] = Console.ReadLine();

        Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
        notas[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Estudiantes y sus notas:");
    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine(nombres[i] + ": " + notas[i]);
    }

    int notaMasAlta = 0;
    int notaMasBaja = 100;
    string estudianteConNotaMasAlta = "";
    string estudianteConNotaMasBaja = "";

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notaMasAlta)
        {
            notaMasAlta = notas[i];
            estudianteConNotaMasAlta = nombres[i];
        }

        if (notas[i] < notaMasBaja)
        {
            notaMasBaja = notas[i];
            estudianteConNotaMasBaja = nombres[i];
        }
    }

    Console.WriteLine("El estudiante con la nota más alta es: " + estudianteConNotaMasAlta);
    Console.WriteLine("La nota más alta es: " + notaMasAlta);
    Console.WriteLine("El estudiante con la nota más baja es: " + estudianteConNotaMasBaja);
    Console.WriteLine("La nota más baja es: " + notaMasBaja);
}



matrix();