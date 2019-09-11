/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 9:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			char caracter;
			Console.WriteLine("ingrese el caracter");
			caracter = char.Parse(Console.ReadLine());
			
			if (caracter=='A' || caracter=='E' || caracter=='I' || caracter=='O' || caracter=='U') {
				Console.WriteLine("el caracter "+caracter+" es una vocal");
			}else if (caracter=='B' || caracter=='C' || caracter=='D' || caracter=='F' || caracter=='G' || caracter=='H' || caracter=='J' || caracter=='K' || caracter=='L' || caracter=='M' || caracter=='N' || caracter=='Ñ' || caracter=='P' || caracter=='Q' || caracter=='R' || caracter=='S' || caracter=='T' || caracter=='V' || caracter=='W' || caracter=='X' || caracter=='Y' || caracter=='Z') {
				Console.WriteLine("el caracter "+caracter+" es una consonante");
			}else {
				Console.WriteLine("Errros... Esto no es un carcater ");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}