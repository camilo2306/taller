/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 8:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			double  carga=0, unidad, total;
			Console.WriteLine("ingrese los siguientes datos.\nNombre.");
			nombre = Console.ReadLine();
			Console.WriteLine("unidades consumidas.");
			unidad = double.Parse(Console.ReadLine());
			
			if (unidad<=199) {
				carga=1.20;
			}else if (unidad>=200 && unidad<400) {
				carga=1.50;
			}else if (unidad>=400 && unidad<600) {
				carga=1.80;
			}else if (unidad>600) {
				carga=2.00;
			}
			total = carga * unidad; 
			Console.WriteLine("señor "+nombre+" el total a pagar es de: $ "+total);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}