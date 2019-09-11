/*
 * Creado por SharpDevelop.
 * Usuario: MI FAMILIA
 * Fecha: 10/09/2019
 * Hora: 6:35 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opci, num1, num2, resul;
			
			Console.WriteLine("digite el primer numero ");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("digite el segundo numero ");
			num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("las opciones son: ");
			Console.WriteLine("1.Adicion\n2.Sustraccion\n3.Multiplicacion\n4.Divison");
			opci = int.Parse(Console.ReadLine());
			
			if (opci==1){	
				resul = num1 + num2;
				Console.WriteLine("la suma entre el "+num1+" y el "+num2+" es: "+resul);
				
			}else if (opci==2){	
				resul = num1 - num2;
				Console.WriteLine("la resta entre el "+num1+" y el "+num2+" es: "+resul);
				
			}else if (opci==3){	
				resul = num1 * num2;
				Console.WriteLine("la multiplicacion entre el "+num1+" y el "+num2+" es: "+resul);
				
			}else if (opci==4){	
				resul = num1 / num2;
				Console.WriteLine("la divison entre el "+num1+" y el "+num2+" es: "+resul);
				
			}else {
				Console.WriteLine("error... Introduzca una opcion valida");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}