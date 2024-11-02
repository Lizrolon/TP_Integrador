/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 11/10/2024
 * Time: 11:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace proyecto
{
	/// <summary>
	/// Description of Salon.
	/// </summary>
	public class Salon 
	{
		//salon tiene eventos contratados y conjunto de empleados fijos
		private string nombreSalon;
		private ArrayList listaeventosContratados;
		private ArrayList listaempleadosFijos;
		private ArrayList listaencargadosFijos;
		private ArrayList listaServiciosOfrecidos;
		
		
		public Salon()
		{
		}
		
		public Salon (string nom){
			nombreSalon=nom;
			listaeventosContratados= new ArrayList();
			listaempleadosFijos = new ArrayList();
			listaencargadosFijos= new ArrayList ();
			listaServiciosOfrecidos = new ArrayList ();
		}
		
		public string NombreSalon{
			set{nombreSalon=value;}
			get{return nombreSalon;}
		}
		
		public ArrayList ListaempleadosFijos{
			get{return listaempleadosFijos;}
		}
		
		public ArrayList ListaeventosContratados{
			get{return listaeventosContratados;}
		}
		
		public ArrayList ListaServiciosOfrecidos{
			get{return listaServiciosOfrecidos;}
		}
		
		public void AgregarServicioAListaServicio(Servicio serv){
			listaServiciosOfrecidos.Add(serv);
		}
		
		public void EliminarServicioDeListaServicio(Servicio serv){
			listaServiciosOfrecidos.Remove(serv);
		}
		
		public void AgregarEmpleadoAlistadeEmpleados(Empleado empleado){
			listaempleadosFijos.Add(empleado);
		}
		
		public void EliminarEmpleadoDeListaEmpleados(Empleado empleado){
			listaempleadosFijos.Remove(empleado);
		}
		
		public void AgregarEventoaListadeEventosContratados (Evento evento){
			listaeventosContratados.Add(evento);
		}
		public void EliminarEvento(Evento evento){
			listaeventosContratados.Remove(evento);	
		}
		
		public void MostrarEmpleados(){
			foreach(Empleado em in listaempleadosFijos){
				em.imprimirDatosEmpleados();
			}
		}
		public void MostrarEventos(){
			foreach(Evento evento in listaeventosContratados){
				evento.imprimirEvento();
			}
		}
		
		public Evento verEvento(int i) {
			return (Evento)ListaeventosContratados[i];
		}
		public void ListaClientes(){
			foreach(Evento evento in ListaeventosContratados){
				evento.MostrarCliente();
			}
		}
		public void MostrarEmpleado(){
			foreach(Empleado empleado in listaempleadosFijos){
				empleado.imprimirDatosEmpleados();
			}
		}
		public void MostrarEventoporMes(int mes){
			foreach(Evento evento in ListaeventosContratados){
				if(evento.Fecha.Month==mes){
					evento.imprimirEvento();
				}
			}
		}
	}
}
