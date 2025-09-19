using Dominio;

namespace obligatorioP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema1 = Sistema.Instancia;

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("MENÚ");
                Console.WriteLine("1. Listado de todos los clientes");
                Console.WriteLine("2. Dado un código de aeropuerto listar todos los vuelos que lo incluyen");
                Console.WriteLine("3. Alta de cliente ocasional");
                Console.WriteLine("4. Dadas dos fechas, listar los pasajes entre esas fechas");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listarUsuarios(sistema1.FiltrarClientes());
                        break;
                    case "2":
                        DevolverAeropuertoPorCodigo(sistema1.BuscarVuelosPorIATA(IataIngresado()));
                        break;
                    case "3":
                        sistema1.CrearUsuario(CrearCliente());
                        break;
                    case "4":
                        List<DateTime> fechas = EnviarFechas();
                        DevolverPasajes(sistema1.BuscarPasajesEntreFechas(fechas[0], fechas[1]));
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("seleccionó una opcion que no es valida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione una tecla para continuar");
                    Console.ReadKey();
                }
            }
        }

        static string IataIngresado()
        {

            Console.Write("Ingrese el codigo IATA del aeropuerto: ");
            string IATA = Console.ReadLine();

            return IATA.ToUpper();



        }
        static ClienteOcasional CrearCliente()
        {
            Console.WriteLine("3. Alta de cliente ocasional");

            Console.Write("Ingrese la cédula del cliente: ");
            string cedula = Console.ReadLine();

            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();


            Console.Write("Ingrese la nacionalidad del cliente: ");
            string nacionalidad = Console.ReadLine();

            Console.Write("Ingrese el mail del cliente: ");
            string mail = Console.ReadLine();

            Console.Write("Ingrese la contraseña del cliente: ");
            string password = Console.ReadLine();

            return AdjuntarDatos(cedula, nombre, nacionalidad, mail, password);
            




        }
        static List<DateTime> EnviarFechas()
        {
            Console.WriteLine("Ingrese las 2 fechas entre las que quiere buscar los pasajes");


            Console.Write("Ingrese la fecha de inicio(DD/MM/YYYY): ");

            string fecha1 = Console.ReadLine();
            DateTime fecha1Nueva = DateTime.Parse(fecha1);

            Console.Write("Ingrese la fecha final(DD/MM/YYYY): ");
            string fecha2 = Console.ReadLine();
            DateTime fecha2Nueva = DateTime.Parse(fecha2);

            return AdjuntarFechas(fecha1Nueva, fecha2Nueva);

        }
        static void listarUsuarios(List<Usuario> usuarios)
        {
            foreach (Usuario unU in usuarios)
            {
                    Console.WriteLine(unU);
            }
        }
        //metodo que recibe las 2 fechas ingresadas en la consola y las adjunta en una lista (fechas) para luegos enviarlas como date time al metodo de sistema
        static List<DateTime> AdjuntarFechas(DateTime fecha1, DateTime fecha2)
        {
            List<DateTime> fechas = new List<DateTime>();
            fechas.Add(fecha1);
            fechas.Add(fecha2);
            return fechas;
        }

        //metodo que recibe todos los datos ingresados en consola, y los adjunta para luegos enviarlo como un objeto (Cliente ocasional) al metodo de sistema. 
        static ClienteOcasional AdjuntarDatos(string cedula, string nombre, string nacionalidad, string mail, string password)
        {
            ClienteOcasional clio = new ClienteOcasional(cedula, nombre, nacionalidad, mail, password);
            return clio;
        }
        static void DevolverPasajes(List<Pasaje> pasajes)
        {
            foreach (Pasaje pas in pasajes)
            {

                Console.WriteLine(pas);
            }
        }

        static void DevolverAeropuertoPorCodigo(List<Vuelo> vuelos)
        {
            foreach (Vuelo unv in vuelos)
            {

                Console.WriteLine(unv);
            }
        }


    }
}

