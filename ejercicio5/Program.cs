namespace ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para ingresar 4 números.
        //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

        int n, n2, n3, n4;

        Console.WriteLine("Ingrese el primer numero");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto numero");
        n4 = int.Parse(Console.ReadLine());

        if (n > n2 && n2 > n3 && n3 > n4)
        {
            Console.WriteLine("Los numeros estan ordenados de forma decreciente");
        }
        else
        {
            Console.WriteLine("Los numero no estan ordenados");
        }
    }
}
