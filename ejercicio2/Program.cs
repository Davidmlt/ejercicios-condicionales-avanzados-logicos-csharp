namespace ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad
        //  de litros vendidos según la siguiente escala:

        //Si vende menos de 100 litros, no hay descuento.
        //Si vende entre 101 y 300 litros, el descuento es del 10%.
        //Si vende entre 301 y 500 litros, el descuento es del 15%.
        //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        //Hacer un programa que solicite el ingreso del importe total de la venta y 
        // la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

        int litros;
        float importeTotal;

        Console.WriteLine("Ingrese el importe de la venta");
        importeTotal = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingree la cantidad de litros vendidos");
        litros = int.Parse(Console.ReadLine());

        if (litros > 500)
        {
            importeTotal = importeTotal * 0.75F;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " con el descuento del 25 %");
        }
        else if (litros >= 301)
        {
            importeTotal = importeTotal * 0.85F;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " con el descuento del 15 %");
        }
        else if (litros >= 101)
        {
            importeTotal = importeTotal * 0.90F;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " con el descuento del 10 %");
        }
        else if (litros < 100)
        {
            importeTotal = importeTotal;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " no tiene descuento");
        }

        // SEGUNDA MANERA
        if (litros < 100)
        {
            importeTotal = importeTotal;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " no tiene descuento");
        }
        else if (litros >= 101 && litros <= 300)
        {
            importeTotal = importeTotal * 0.90F;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " con el descuento del 10 %");
        }
        else if (litros >= 301 && litros <= 500)
        {
            importeTotal = importeTotal * 0.85F;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " con el descuento del 15 %");
        }
        else
        {
            importeTotal = importeTotal * 0.75F;
            Console.WriteLine("El importe a cobrar es: " + importeTotal + " con el descuento del 25 %");
        }

        
    }
}
