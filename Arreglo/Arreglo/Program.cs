using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [13] {85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93};
            bool esprimo = false;
            for(int i = 2; i < numeros.Length; i++) 
            {
                esprimo = true;
                for(int j = 2; j<i; j++)
                {
                    if (numeros[i] %j == 0) 
                    {
                        esprimo = false;
                        break;
                    }
                }
                if(esprimo)
                {
                    Console.WriteLine(numeros[i] + " ");
                }
            }


            Console.Write("Ingrese el tamaño del vector: ");
            int n = int.Parse(Console.ReadLine());

            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese un valor entre 0 y 20: ");
                vec[i] = int.Parse(Console.ReadLine());
            }

            int rango1 = 0;
            int rango2 = 0;
            int rango3 = 0;
            int rango4 = 0;

            foreach (int valor in vec)
            {
                if (valor >= 0 && valor <= 5)
                {
                    rango1++;
                }
                else if (valor >= 6 && valor <= 10)
                {
                    rango2++;
                }
                else if (valor >= 11 && valor <= 15)
                {
                    rango3++;
                }
                else if (valor >= 16 && valor <= 20)
                {
                    rango4++;
                }
            }

            Console.WriteLine("Cantidad de valores en el rango 0-5: " + rango1);
            Console.WriteLine("Cantidad de valores en el rango 6-10: " + rango2);
            Console.WriteLine("Cantidad de valores en el rango 11-15: " + rango3);
            Console.WriteLine("Cantidad de valores en el rango 16-20: " + rango4);
        
        }
    }
}
