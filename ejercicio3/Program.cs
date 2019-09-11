/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 7:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mes;
			
			Console.WriteLine("digite el numero del mes");
			mes = int.Parse(Console.ReadLine());
			
			if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) {
				Console.WriteLine("el mes "+mes+" tiene 31 dias");
			}else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
				Console.WriteLine("el mes "+mes+" tiene 30 dias");
			}else if (mes == 2) {
				Console.WriteLine("el mes "+mes+" tiene 28 dias");
			}else {
				Console.WriteLine("digite un numero de mes valido");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}