/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 7/10/2024
 * Time: 17:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		protected string nombre;
		protected string apellido;
		protected int dni;
		protected int nro_legajo;
		protected double sueldo;
		protected string tarea_desempenia;
		
		public Empleado()
		{
		}
		
		public Empleado (string nom, string ape, int docu, int legajo, double sueldo, string tarea){
			nombre=nom;
			apellido= ape;
			dni=docu;
			nro_legajo=legajo;
			this.sueldo=sueldo;
			tarea_desempenia=tarea;
		}
		
		public string Nombre{
			set{nombre=value;}
			get{return nombre;}
		}
		
		public string Apellido{
			set{apellido=value;}
			get{return apellido;}
		}
		
		public int Dni{
			set{dni=value;}
			get{return dni;}
		}
		
		public int Nro_Legajo{
			set{nro_legajo=value;}
			get{return nro_legajo;}
		}
		
		public double Sueldo{
			set{sueldo=value;}
			get{return sueldo;}
		}
		
		public string TareaDesempenia{
			set{tarea_desempenia= value;}
			get{return tarea_desempenia;}
		}
		
		public void imprimirDatosEmpleados(){
			Console.WriteLine("Nombre y apellido: " + nombre + " " + apellido + " DNI: " + dni + " N° Legajo: " + nro_legajo + " Sueldo: " + sueldo + " Tarea: "+ tarea_desempenia);
		}
		
		public virtual double consultarSueldo(){
			return sueldo;
		}
	}
}
