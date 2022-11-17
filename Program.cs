Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Números pares entre 0 e ? ");
int  i = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

if (i >=1)
{
   int numeroPar = 0;

    while (numeroPar <= i) 
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            
            Console.Write($"{numeroPar} ");
            numeroPar = numeroPar + 2;

            Console.ResetColor();
        }

        Console.WriteLine();
}

else
{
    Console.ForegroundColor=ConsoleColor.DarkRed;
    Console.WriteLine($"O número {i} não é positivo");
    Console.ResetColor();
}
