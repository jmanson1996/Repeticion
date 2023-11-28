using System;
namespace Repeticion
{
    class Program
    {
        static void Main()
        {
            // REALIZAR UN PROGRAMA DONDE  VEA LOS DATOS DUPLICADOS DE UN ARRAY
            int cantidad;
            Console.WriteLine("INGRESE LA LONGITUD DEL ARRAY");
            cantidad = int.Parse(Console.ReadLine());
            int[] array = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el numero \t #" + i + 1);
                array[i] = int.Parse(Console.ReadLine());

            }

            int[] total = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (numero(array[i]))
                        {
                            total[i] = array[i];
                        }

                    }
                }
                if (total[i] != 0)
                {
                    Console.WriteLine(total[i] + "\t Se repite \t " + count + "veces");
                }
            }
            bool numero(int num)
            {
                for (int i = 0; i < total.Length; i++)
                {
                    if (total[i] == num)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}