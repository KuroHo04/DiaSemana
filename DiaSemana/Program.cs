using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("programa de días de la semana!");
                Console.Write("Por favor, introduce un número del 1 al 7: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                string dia = ObtenerDiaSemana(numero);
                if (dia != null)
                {
                    Console.WriteLine($"El día correspondiente al número {numero} es: {dia}");
                }
                else
                {
                    Console.WriteLine("Número de día inválido. Debe estar entre 1 y 7.");
                }

                Console.WriteLine("¿Deseas introducir otro número? (yes/no): ");
            } while (Console.ReadLine().ToLower() == "yes");
        }

        static string ObtenerDiaSemana(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return null;
            }
        }
    }

}