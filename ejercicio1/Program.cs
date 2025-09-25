namespace ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite el ingreso de dos números y luego calcular:

        //La resta si el primero es mayor que el segundo.
        //La suma si son iguales.
        //El producto si el primero es menor.

        int n, n2;
        float resta, suma, producto;

        Console.WriteLine("Ingrese el primer numero");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        n2 = int.Parse(Console.ReadLine());

        if (n > n2)
        {
            resta = n - n2;
            Console.WriteLine("La resta de: " + n + " - " + n2 + " es: " + resta);
        }
        else if (n == n2)
        {
            suma = n + n2;
            Console.WriteLine("La suma de: " + n + " + " + n2 + " es: " + suma);
        }
        else
        {
            producto = n * n2;
            Console.WriteLine("El producto de " + n + " X " + n2 + " es: " + producto);
        }
    }
}
