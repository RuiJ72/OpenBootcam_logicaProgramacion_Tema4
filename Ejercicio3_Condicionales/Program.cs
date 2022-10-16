// Se un número es positivo, negativo o 0 con IF

int numeroIf;

Console.WriteLine("Introduce un número: ");

numeroIf = Convert.ToInt32(Console.ReadLine());

if (numeroIf > 0)
{
    Console.WriteLine("La cifra introducida es positiva!");
}

if (numeroIf < 0)
{
    Console.WriteLine("La cifra introducida es negtiva");
}

else if (numeroIf == 0)
{
    Console.WriteLine("La cifra introducida es el numero 0");
}