/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 7:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double  radio, area, b, h, op;
			
			Console.WriteLine("programa para calcular el area de diferentes figuras geometricas\n ------------------------------------------------------------ ");
			Console.WriteLine("digite 1 para hallar el area del circulo\ndigite 2 para hallar el area del rectangulo\ndigite 3 para hallar el area del triangulo ");
			Console.WriteLine("digite su opcion");
			op = float.Parse(Console.ReadLine());
			
			if (op==1){
				Console.WriteLine("ingrese valor del radio ");
				radio = double.Parse(Console.ReadLine());
				area = Math.PI*Math.Pow(radio,2);
				Console.WriteLine("el area del circulo es: "+area);
			}else if (op==2){
				Console.WriteLine("digite el valor de la base del rectangulo ");
				b = double.Parse(Console.ReadLine());
				Console.WriteLine("digite el valor de la altura del rectangulo ");
				h = double.Parse(Console.ReadLine());
				area = b * h;
				Console.WriteLine("el area del rectangulo es: "+area);
			}else if (op==3){
				Console.WriteLine("digite el valor de la base del triangulo ");
				b = double.Parse(Console.ReadLine());
				Console.WriteLine("digite el valor de la altura del triangulo ");
				h = double.Parse(Console.ReadLine());
				area = (b * h)/2;
				Console.WriteLine("el area del triangulo es: "+area);
			}else {
				Console.WriteLine("opcion invalida");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}