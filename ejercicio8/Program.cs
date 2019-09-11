/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 10:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int precio;
			double des=0, total=0;
			
			
			Console.WriteLine("ingrese el valor de la compra ");
			precio = int.Parse(Console.ReadLine());
			
			if (precio>=200) {
				des = precio*0.15;
				total = precio-des;
			}else if (precio>=100 && precio<200) {
				des = precio*0.12;
				total = precio-des;
			}else if (precio<100) {
				des = precio*0.10;
				total = precio - des;
			}
			
			Console.WriteLine("su descuento es de: "+des);
			Console.WriteLine("el total a pagar es de: "+total);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}