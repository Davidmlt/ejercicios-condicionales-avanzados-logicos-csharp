namespace ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
        //  Para ello existe la siguiente escala de precios:

        //              i5 (1)	     i7 (2)	   i9 (3)
        //8 RAM (1)	    USD 800	    USD 900	    USD 1200
        //16 RAM (2)	USD 900	    USD 1000	USD 1400
        //32 RAM (3)	USD 1000	USD 1400	USD 2000

        //Además, el equipo viene con un disco que permite almacenar 500 GB de información y 
        // que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
        // Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM,
        //  y si extiende el disco o no (ingresa 1 para extender y 0 para no extender)
        //  y calcule y emita por pantalla el monto de la máquina seleccionada.

        int procesador, memoria, extiende, monto;

        Console.WriteLine("Elija la opcion del procesador");
        procesador = int.Parse(Console.ReadLine());

        Console.WriteLine("Elija la opción de memoria RAM");
        memoria = int.Parse(Console.ReadLine());

        Console.WriteLine("Elija 1 para extender memoria o 0 para no extenderla");
        extiende = int.Parse(Console.ReadLine());

        switch (procesador)
        {
            case 1:
                Console.WriteLine("Usted eligio el procesador i5");
                if (memoria == 1)
                {
                    Console.WriteLine("Usted agrego 8 GB RAM ");
                    monto = 800;
                }
                else if (memoria == 2)
                {
                    Console.WriteLine("Usted agrego 16 GB RAM ");
                    monto = 900;
                }
                else
                {
                    Console.WriteLine("Usted agrego 32 GB RAM ");
                    monto = 1000;
                }
                if (extiende == 1)
                {
                    monto += 300;
                    Console.WriteLine("Usted extiendo el disco a 1 TB");
                }
                Console.WriteLine("El monto a cobrar por su pc es de: " + monto);

                break;

            case 2:
                Console.WriteLine("Usted eligio el procesador i7");
                if (memoria == 1)
                {
                    Console.WriteLine("Usted eligio 8 GB RAM");
                    monto = 900;
                }
                else if (memoria == 2)
                {
                    Console.WriteLine("Usted eligio 16 GB RAM");
                    monto = 1000;
                }
                else
                {
                    Console.WriteLine("Usted eligio 32 GB RAM");
                    monto = 1400;
                }
                if (extiende == 1)
                {
                    monto += 300;
                    Console.WriteLine("Usted extiendo el disco a 1 TB");
                }
                Console.WriteLine("El monto a cobrar por su pc es de: " + monto);

                break;

            case 3:
                Console.WriteLine("Usted eligio el procesador i9");
                if (memoria == 1)
                {
                    Console.WriteLine("Ustede eligio 8 GB RAM");
                    monto = 1200;
                }
                else if (memoria == 2)
                {
                    Console.WriteLine("Usted eligio 16 GB RAM");
                    monto = 1400;
                }
                else
                {
                    Console.WriteLine("Usted eligio 32 GB RAM");
                    monto = 2000;
                }
                if (extiende == 1)
                {
                    monto += 300;
                    Console.WriteLine("Usted extiendo el disco a 1 TB");
                }

                Console.WriteLine("El monto a cobrar por su pc es de: " + monto);

                break;

            default:
                Console.WriteLine("No ingreso una opción correcta");

                break;
        }
    }
}
