/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 7/10/2024
 * Time: 17:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace proyecto
{
	/// <summary>
	/// Description of Evento.
	/// </summary>
	public class Evento
	{
		private string nombreCliente;
		private int dniCliente;
		private DateTime fecha;
		private string hora;
		private string tipoEvento;
		private Encargado encargado;
		private ArrayList listaServicios_contratados;
		private double costoTotal; //precio servicio contratado + la cantidad
		private double montoSenia;
		
		public Evento()
		{
			listaServicios_contratados= new ArrayList();
		}
		
		public Evento (string nom_cliente, int docu_cliente, DateTime fecha, string hora, string tipo_evento, Encargado encargado, double costo){
			nombreCliente= nom_cliente;
			dniCliente= docu_cliente;
			this.fecha=fecha;
			this.hora=hora;
			tipoEvento=tipo_evento;
			this.encargado=encargado;
			listaServicios_contratados= new ArrayList();
			costoTotal=costo;
			
		}
		
		public Evento (string nom_cliente, int docu_cliente, DateTime fecha, string hora, string tipo_evento, Encargado encargado, double costo, double monto){
			nombreCliente= nom_cliente;
			dniCliente= docu_cliente;
			this.fecha=fecha;
			this.hora=hora;
			tipoEvento=tipo_evento;
			this.encargado=encargado;
			listaServicios_contratados= new ArrayList();
			costoTotal=costo;
			montoSenia=monto;
		}
		
		public string NombreCliente{
			set{nombreCliente = value;}
			get{return nombreCliente;}
		}
		
		public int DniCliente{
			set{dniCliente= value;}
			get{return dniCliente;}
		}
		
		public DateTime Fecha{
			set{fecha=value;}
			get{return fecha;}
		}
		
		public string Hora{
			set{hora= value;}
			get{return hora;}
		}
		
		
		public string TipoEvento{
			set{tipoEvento= value;}
			get{return tipoEvento;}
		}
		
		public Encargado Encargado{
			set{encargado=value;}
			get{return encargado;}
		}
		
		public ArrayList ListaServicios_contratados{
			get{return listaServicios_contratados;}
		}
		
		public double CostoTotal{
			set{costoTotal= value;}
			get{return costoTotal;}
		}
		
		public double MontoSenia{
			set{montoSenia=value;}
			get{return montoSenia;}
		}
		
		public void AgregarServicioEnListaServicioContratados (Servicio servicio){
			listaServicios_contratados.Add(servicio);
		}
		
		public void EliminarServicioEnListaServicio (Servicio servicio){
			listaServicios_contratados.Remove(servicio);
		}
		
		public void imprimirEvento(){
			Console.WriteLine("Cliente: " +nombreCliente + "DNI: " + dniCliente + "Fecha: "+ fecha.Date.ToString("d") + "Hora: "+ hora + " Tipo de Evento: "+ tipoEvento + "Encargado: " + encargado + "Senia: "+ montoSenia);
		}
		
		public void mostrarServiciosContratados(){
			foreach(Servicio ser in listaServicios_contratados){
				ser.imprimirServicio();
			}
		}
		public void MostrarCliente(){
			Console.WriteLine("Nombre del cliente:"+ nombreCliente+ " DNI:"+dniCliente+" Evento:"+ tipoEvento);
		}
		
	}
}
