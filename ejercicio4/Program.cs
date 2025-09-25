namespace ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma
        //  de los dos primeros es mayor al producto del segundo con el tercero.

        int n, n2, n3, suma, producto;

        Console.WriteLine("Ingrese el primer numero");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero:");
        n3 = int.Parse(Console.ReadLine8());

        suma = n + n2;
        producto = n2 * n3;

        if (suma > producto)
        {
            Console.WriteLine("La suma de los dos primeros numeros es mayor al producto del segundo y tercero");
        }

        //MANERA DOS

        if ((n + n2) > (n2 * n3))
        {
             Console.WriteLine("La suma de los dos primeros numeros es mayor al producto del segundo y tercero");
        }
    }
}
