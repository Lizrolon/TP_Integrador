/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 11/10/2024
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto
{
	/// <summary>
	/// Description of Encargado.
	/// </summary>
	public class Encargado : Empleado
	{
		private double cobro_plus;
		private double sueldoActualizado;
		public Encargado()
		{
		}
		
		//Empleado: string nom, string ape, int docu, int legajo, double sueldo, string tarea
		public Encargado (string nom, string ape, int docu, int legajo, double sueldo, string tarea) : base(nom, ape, docu, legajo, sueldo, tarea){
			
			cobro_plus= ((115 *sueldo)/ 100) - sueldo;
			sueldoActualizado = sueldo + cobro_plus;
		}
		

		public double Cobro_plus{
			set{cobro_plus=value;}
			get{return cobro_plus;}
		}
		
		
		public override double consultarSueldo(){
			return cobro_plus;
		}
		
		public void mostrarEncargado (){
			Console.WriteLine("Nombre y apellido: "+ nombre + " "+ apellido + " DNI: " + dni + " Legajo: " + nro_legajo+ " Sueldo: " + sueldo + " Tarea: " + tarea_desempenia + " Cobro plus: " + cobro_plus + " Sueldo actualizado: " + sueldoActualizado  );
		}
		
	}
}
