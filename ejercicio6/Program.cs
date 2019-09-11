/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 10:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n=0;
			float f;
			Console.WriteLine("ingrese el valor de N");
			n = int.Parse(Console.ReadLine());
			
			f= n*((1/Math.sqrt(5))*(Math.pow(((1+Math.sqrt(5))/2),n)-Math.pow((1-Math.sqrt(5))/2),n);
			
			Console.WriteLine("F(n) = "+f);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}