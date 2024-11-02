/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 7/10/2024
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace proyecto
{
	class Program
	{
		public static void Main(string[] args)
		{
			//ArrayList listaServiciosOfrecidos=ListaLoteoServiciosOfrecidos();
			Salon salon= new Salon("Mariposas");
			ListaLoteoEmpleadosFijos(salon);
			string opcion;
			do{
				Console.Clear();
				MenuPrincipal();
				Console.WriteLine("Ingrese una opcion:");
				opcion= Console.ReadLine();
				switch(opcion){
					case "1":
						AdministrarSalon(salon);
						break;
					case "2":
						break;
					case "3":
						break;
					default:
						Console.WriteLine("Opcion Incorrecta:");
						break;
				}
				
			}while(opcion!="3");
					
			Console.ReadKey(true);
		}
		public static void MenuPrincipal(){
			Console.WriteLine(".: MENU PRINCIPAL :.");
			Console.WriteLine("1. Administrar Salon");
			Console.WriteLine("2. Administrar Evento");
			Console.WriteLine("3. Salir");
		}
		public static void AdministrarSalon(Salon salon){
			string opcion;
			do{
				Console.Clear();
				MenuSalon();
				Console.WriteLine("Ingrese una opcion: ");
				opcion= Console.ReadLine();
				switch(opcion){
					case "1":
						Console.WriteLine("Implementar");
						Console.ReadKey();
						break;
					case "2":
						Console.WriteLine("Implementar");
						Console.ReadKey();
						break;
					case "3":
						Console.WriteLine("Implementar");
						Console.ReadKey();
						break;
					case "4":
						Console.WriteLine("Implementar");
						Console.ReadKey();
						break;
					case "5":
						Console.WriteLine("Implementar");
						Console.ReadKey();
						break;
					case "6":
						Console.WriteLine("Implementar");
						Console.ReadKey();
						break;
					case "7":
						break;
					default:
						Console.WriteLine("Opcion Incorrecta");
						break;
				}
			}while(opcion!="7");
		}
		public static void MenuSalon(){
			Console.WriteLine("**Administrar Salón**");
			Console.WriteLine("1. Agregar Servicio");
			Console.WriteLine("2. Eliminar Servicio");
			Console.WriteLine("3. Mostrar Servicios");
			Console.WriteLine("4. Dar de Alta Empleado");
			Console.WriteLine("5. Dar de Baja Empleado");
			Console.WriteLine("6. Mostrar Empleados");
			Console.WriteLine("7. Volver");
			
		}
		
		public static void ListaLoteoServiciosOfrecidos(Salon salon){
			Servicio servicio_catering= new Servicio("catering", "el servicio ofrece...", 1000.0);
			Servicio servicio_bebidas= new Servicio("bebidas", "el servicio ofrece...", 2000.0);
			Servicio servicio_mozos= new Servicio("mozos", "el servicio ofrece...", 1500.0);
			Servicio servicio_dj= new Servicio("dj", "el servicio ofrece...", 2500.0);
			Servicio servicio_inflables= new Servicio("inflables", "el servicio ofrece...", 3000.0);
			Servicio servicio_cama= new Servicio("cama elastica", "el servicio ofrece...", 4000.0); //acento
			salon.AgregarServicioAListaServicio(servicio_catering);
			salon.AgregarServicioAListaServicio(servicio_bebidas);
			salon.AgregarServicioAListaServicio(servicio_mozos);
			salon.AgregarServicioAListaServicio(servicio_dj);
			salon.AgregarServicioAListaServicio(servicio_inflables);
			salon.AgregarServicioAListaServicio(servicio_cama);
		}
		
		public static void ListaLoteoEmpleadosFijos(Salon nomSalon){
			//string nom, string ape, int docu, int legajo, double sueldo, string tarea
			Empleado empleado1= new Empleado ("Juan", "Perez", 22114566, 120, 25000, "mozo");
			Empleado empleado2= new Empleado("Marcela", "Lopez", 35090971, 121, 25000, "mozo");
			Empleado empleado3= new Empleado("Carlos", "Dominguez", 39882121, 122, 30000, "bachero");
			Empleado empleado4= new Empleado("Sergio", "Sanchez", 40157899, 123, 25000, "mozo");
			Empleado empleado5= new Empleado("Eduardo", "Mendez", 37606033, 125, 40000, "seguridad");
			Empleado empleado6= new Empleado("Ana", "Benitez", 39002840, 126, 45000, "limpieza" );
			Empleado empleado7= new Empleado("Tomas", "Gomez", 30208734, 127, 45000, "limpieza");
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado1);
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado2);
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado3);
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado4);
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado5);
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado6);
			nomSalon.AgregarEmpleadoAlistadeEmpleados(empleado7);
		}
		
		public static void AgregarServicio (Salon nombreSalon){
			Console.WriteLine("***AGREGAR SERVICIO***");
			Console.WriteLine("Bienvenido, para comenzar ingrese el nombre del servicio: ");
			string nomServ = Console.ReadLine();
			Console.WriteLine("Ingrese descripción del servicio: ");
			string descripcionServ =Console.ReadLine();
			Console.WriteLine("Ingrese en numeros valor del costo unitario del servicio: ");
			double costoUnitarioServ = double.Parse(Console.ReadLine());
			Servicio nuevoServ = new Servicio (nomServ, descripcionServ, costoUnitarioServ);
			nombreSalon.AgregarServicioAListaServicio(nuevoServ);
			Console.WriteLine("Servicio agregado con exito");
		}
		
		public static void DarBajaServicio (Salon nombreSalon){
			Console.WriteLine("***DAR DE BAJA SERVICIO***");
			Console.WriteLine("Para dar de baja, ingrese el nombre del servicio: ");
			string nom= Console.ReadLine();
			nom= nom.ToLower();
			foreach (Servicio s in nombreSalon.ListaServiciosOfrecidos){
				if (nom == s.NombreServicio){
					nombreSalon.EliminarServicioDeListaServicio(s);
					break; // sin esto da error
				}//else
			}
			Console.WriteLine("Servicio dado de baja correctamente");
		}
		
		public static void DarAltaEmpleado (Salon salon){
			Console.WriteLine("***DAR DE ALTA EMPLEADO/ENCARGADO***");
			//string nom, string ape, int docu, int legajo, double sueldo, string tarea
			Console.WriteLine("Ingrese el nombre del empleado/a que desea dar de alta: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el apellido: ");
			string apeliido= Console.ReadLine();
			Console.WriteLine("Ingrese el número de documento (sin puntos): ");
			int docu= int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el número de legajo asignado: ");
			int legajo= int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el sueldo del empleado/a: ");
			double sueldo= double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la tarea asignada para el empleado/a: ");
			string tarea= Console.ReadLine();
			Empleado empleado = new Empleado(nombre, apeliido, docu, legajo, sueldo, tarea);
			salon.AgregarEmpleadoAlistadeEmpleados(empleado);
			Console.WriteLine("Empleado/a agregado con exito");
		}
		
		public static void DarBajaEmpleado(Salon salon){
			Console.WriteLine("Para dar de baja a un empleado, ingrese su numero de legajo: ");
			int legajo= int.Parse(Console.ReadLine());
			bool existe= false;
			foreach(Empleado empleado in salon.ListaempleadosFijos){
				if(empleado.Nro_Legajo == legajo){
					existe= true;
					salon.EliminarEmpleadoDeListaEmpleados(empleado);
					Console.WriteLine("Empleado dado de baja correctamente");
					break;
				}
			}if(!existe){
				Console.WriteLine("No se encontró empleado");
			}
		}
		
		public static Encargado AsignarEncargadoaEvento(Salon salon){
			Encargado encargado = new Encargado();
			for(int i=0; i<salon.ListaempleadosFijos.Count; i++){
				Empleado empleado = (Empleado)salon.ListaempleadosFijos[i];
				Console.Write(i + "- ");
				empleado.imprimirDatosEmpleados();
			}
			Console.WriteLine("Ingrese el encargado que desea asignar");
			int indice = int.Parse(Console.ReadLine());
			
			while(true){
				try{
					Empleado empleado1 = (Empleado)salon.ListaempleadosFijos[indice];
					empleado1.TareaDesempenia="encargado";
					string nombre = empleado1.Nombre;
					string apellido = empleado1.Apellido;
					int dni = empleado1.Dni;
					int legajo = empleado1.Nro_Legajo;
					double sueldo = empleado1.Sueldo;
					string tarea = empleado1.TareaDesempenia;
					encargado = new Encargado(nombre, apellido, dni, legajo, sueldo, tarea);
					break;
				}
				catch(ArgumentOutOfRangeException){
					Console.WriteLine("Opcion incorrecta");
				}
				Console.WriteLine("Ingrese el encargado que desea asignar");
				indice = int.Parse(Console.ReadLine());
			}return encargado;
		}
		
	
		public static void ReservarSalon(Salon salon){
			Console.WriteLine("***Reserva de Salón***");
			DateTime fecha = new DateTime();
			bool disponible = true;
			do{
				disponible = true;
				Console.WriteLine("Ingrese la fecha que desea reservar(aaaa/mm/dd): ");
				try{
					fecha = DateTime.Parse(Console.ReadLine());
					foreach (Evento evento1 in salon.ListaeventosContratados){
						if(evento1.Fecha == fecha){
							throw new FechaOcupadaException();
						}
					}
				}catch (FechaOcupadaException){
					disponible= false;
					Console.WriteLine("La fecha no está disponible");
				}
				catch(FormatException){
					disponible = false;
					Console.WriteLine("Fecha mal ingresada, intente nuevamente");
				}
			}while(!disponible);
			if(disponible){
				//string nom_cliente, int docu_cliente, DateTime fecha, string hora, string tipo_evento, Encargado encargado, double costo, double monto
				Console.WriteLine("Ingrese el nombre y apellido del cliente: ");
				string nomyape=Console.ReadLine();
				Console.WriteLine("Ingrese el DNI del cliente");
				
				int docu=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese la hora del evento: ");
				string hora=Console.ReadLine();
				Console.WriteLine("Ingrese el tipo de evento: ");
				string tipo= Console.ReadLine();
				Encargado encargado_asignado= AsignarEncargadoaEvento(salon);
				double costo = 0;
				Evento evento = new Evento (nomyape, docu, fecha, hora, tipo, encargado_asignado, costo);
				salon.AgregarEventoaListadeEventosContratados(evento);
			}
			
		}
		
	
		public static void ContratarServicios(Salon salon){
			//Creo un evento vacio 
			Evento evento1 = new Evento();
			Console.WriteLine("SERVICIOS OFRECIDOS");
			//Muestro los servicios disponibles
			for(int i=0; i<salon.ListaServiciosOfrecidos.Count;i++){
				Servicio servicio = (Servicio)salon.ListaServiciosOfrecidos[i];
				Console.Write(i+"-");
				servicio.imprimirServicio();
			}
			//guardo el tamaño de la lista en una variable
			int tam_listaServ= salon.ListaServiciosOfrecidos.Count;
			string respuesta;
			Console.WriteLine("Para contratar un servicio, ingrese la opción correspondiente");
			int opcion = int.Parse(Console.ReadLine());
			do{
				
				if(opcion<tam_listaServ){
					Servicio servicio_elegido = (Servicio) salon.ListaServiciosOfrecidos[opcion];
					Console.WriteLine("¿Qué cantidad desea? Ingrese la respuesta en números");
					int cant_solic= int.Parse(Console.ReadLine());
					servicio_elegido.CantidadSolicitada = cant_solic;
					string nom = servicio_elegido.NombreServicio;
					string descripcion = servicio_elegido.Descripcion;
					double costo_uni = servicio_elegido.CostoUnitarioServicio;
					double costo_total = cant_solic*costo_uni;
					Servicio servicio_contratado = new Servicio (nom,descripcion,cant_solic,costo_uni, costo_total);
					evento1.AgregarServicioEnListaServicioContratados(servicio_contratado);
					
				}else{
					Console.WriteLine("Opción incorrecta, intente nuevamente");
				}
				Console.WriteLine("Quiere contratar otro servicio? s/n");
				respuesta = Console.ReadLine();
			}while(respuesta=="s");
			evento1.mostrarServiciosContratados();
		}
		public static void CancelarEvento(Salon salon){
			//Mostrar la lista de eventos 
			for(int i = 0; i<salon.ListaeventosContratados.Count;i++){
				Evento evento = (Evento)salon.ListaeventosContratados[i];
				Console.Write((i + 1) + "-");
				evento.imprimirEvento();
			}
			Console.WriteLine("Ingrese el número del evento que desea cancelar:");
			int opcion=int.Parse(Console.ReadLine());
			Evento aux= salon.verEvento(opcion-1);
			salon.EliminarEvento(aux);
			Console.WriteLine("Evento cancelado con exito");
			
		}	
	}
}