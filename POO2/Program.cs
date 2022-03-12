using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2.ENTIDAD;


namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno();
            Console.WriteLine("ingrese Nombre");
            a1.Nombre = Console.ReadLine();
            Console.WriteLine ("ingrese nota 1");
            a1.Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota 2 ");
            a1.Nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota 3");
            a1.Nota3 = int.Parse(Console.ReadLine());
            
        
            Console.Clear();
        
            Console.WriteLine(" nombre "+ a1.Nombre);
            Console.WriteLine("notas " + a1.Nota1 + " - "+ a1.Nota2 + " - "+a1.Nota3);
            int Promedio = (a1.Nota1 + a1.Nota2 + a1.Nota3);
            Console.WriteLine("promedio" + Promedio);
            if (Promedio > 11)
            {
                Console.WriteLine("aprovado ");
            }
            else
            {
                Console.WriteLine("desaprovado");

            }
            
        }
    }
}
