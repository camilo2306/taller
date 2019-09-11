/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 10:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, num3;
			
			Console.WriteLine("ingrese el primer numero");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el segundo numero");
			num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el tercer numero");
			num3 = int.Parse(Console.ReadLine());
			
			if (num1>=num2 && num1>=num3) {
				Console.WriteLine("el numero "+num1+" es el mayor");
			}else if (num2>=num1 && num2>=num3) {
				Console.WriteLine("el numero "+num2+" es el mayor");
			}else {
				Console.WriteLine("el numero "+num3+" es el mayor");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}