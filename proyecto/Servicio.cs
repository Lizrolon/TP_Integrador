/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 7/10/2024
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto
{
	/// <summary>
	/// Description of Servicio.
	/// </summary>
	public class Servicio
	{
		private string nombreServicio;
		private string descripcion;
		private int cantidadSolicitada;
		private double costoUnitarioServicio;
		private double costo_total;
		
		public Servicio()
		{
		}
		
		public Servicio(string nomServ, string descrip, int cant_solic, double costo_unitarioServ, double costo_total){
			nombreServicio=nomServ;
			descripcion=descrip;
			cantidadSolicitada=cant_solic;
			costoUnitarioServicio=costo_unitarioServ;
			this.costo_total=costo_total;
		}
		
		
		
		public Servicio(string nomServ, string descrip, double costo_unitarioServ){
			nombreServicio=nomServ;
			descripcion=descrip;
			costoUnitarioServicio=costo_unitarioServ;
			
		}
		
		public string NombreServicio{
			set{nombreServicio = value;}
			get{return nombreServicio;}
		}
		
		public string Descripcion{
			set{descripcion = value;}
			get{return descripcion;}
		}
		
		public int CantidadSolicitada{
			set{cantidadSolicitada = value;}
			get{return cantidadSolicitada;}
		}
		
		public double CostoUnitarioServicio{
			set{costoUnitarioServicio = value;}
			get{return costoUnitarioServicio;}
		}
		
		public double Costo_total{
			set{costo_total = value;}
			get{return costo_total;}
		}
		
		public void imprimirServicio (){
			Console.WriteLine("Servicio: " + nombreServicio + " - Descripción: " + descripcion + " - Costo unitario: $" + costoUnitarioServicio);
		}
	}
}
