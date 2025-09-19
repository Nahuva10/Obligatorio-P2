
namespace Dominio
{
    public class Sistema
    {

        private static Sistema instancia;
        private List<Avion> aviones = new List<Avion>();
        private List<Vuelo> vuelos = new List<Vuelo>();
        private List<Ruta> rutas = new List<Ruta>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Aeropuerto> aeropuertos = new List<Aeropuerto>();
        private List<Pasaje> pasajes = new List<Pasaje>();


        public static Sistema Instancia
        {
            get
            {
                if (instancia == null) instancia = new Sistema();
                return instancia;
            }
        }

        private Sistema()
        {
            PrecargarAviones();
            PrecargaAeropuerto();
            PrecargaUsuarios();
            PrecargaRutas();
            PrecargaVuelos();
            PrecargarPasajes();
        }

        public void CrearAvion(Avion av)
        {

            if (av == null) throw new Exception("El avion no puede ser nulo");
            av.Validar();
            if (aviones.Contains(av)) throw new Exception("ya existe el avion en el sistema");
            aviones.Add(av);

        }

        public void CrearAeropuerto(Aeropuerto aero)
        {

            if (aero == null) throw new Exception("El aeropuerto no puede ser nulo");
            aero.Validar();
            if (aeropuertos.Contains(aero)) throw new Exception("ya existe el aeropuerto en el sistema");
            aeropuertos.Add(aero);

        }
        public void CrearRuta(Ruta ru)
        {

            if (ru == null) throw new Exception("La ruta no puede ser nula");
            ru.Validar();
            if (rutas.Contains(ru)) throw new Exception("ya existe la ruta en el sistema");
            rutas.Add(ru);


        }
        public void CrearVuelo(Vuelo vue)
        {

            if (vue == null) throw new Exception("El vuelo no puede ser nulo");
            vue.Validar();
            if (vuelos.Contains(vue)) throw new Exception("ya existe el vuelo en el sistema");
            vuelos.Add(vue);


        }

        public void CrearUsuario(Usuario usu)
        {

            if (usu == null) throw new Exception("El cliente no puede ser nulo");
            usu.Validar();
            if (usuarios.Contains(usu)) throw new Exception("Ya existe el cliente");
            usuarios.Add(usu);



        }


        public void CrearPasaje(Pasaje pas)
        {

            if (pas == null) throw new Exception("El pasaje no puede ser nulo");
            pas.Validar();
            if (pasajes.Contains(pas)) throw new Exception("ya existe el pasaje en el sistema");
            pasajes.Add(pas);


        }

        private void PrecargarAviones()
        {
            CrearAvion(new Avion("Boeing", "c737", 162, 29500, 45));
            CrearAvion(new Avion("Airbus", "A320", 180, 21005, 40));
            CrearAvion(new Avion("Embrae", "E195", 132, 29050, 60));
            CrearAvion(new Avion("Bombardier", "CRJ900", 90, 25004, 50));
        }

        private void PrecargaAeropuerto()
        {
            CrearAeropuerto(new Aeropuerto("MVD", "Montevideo", 200, 8));
            CrearAeropuerto(new Aeropuerto("EZE", "Buenos Aires", 250, 10));
            CrearAeropuerto(new Aeropuerto("GRU", "São Paulo", 300, 12));
            CrearAeropuerto(new Aeropuerto("JFK", "Nueva York", 500, 18));
            CrearAeropuerto(new Aeropuerto("LAX", "Los Ángeles", 480, 17));
            CrearAeropuerto(new Aeropuerto("MAD", "Madrid", 350, 11));
            CrearAeropuerto(new Aeropuerto("CDG", "París", 370, 11));
            CrearAeropuerto(new Aeropuerto("LHR", "Londres", 400, 13));
            CrearAeropuerto(new Aeropuerto("FRA", "Frankfurt", 360, 12));
            CrearAeropuerto(new Aeropuerto("BCN", "Barcelona", 340, 10));
            CrearAeropuerto(new Aeropuerto("MEX", "Ciudad de México", 310, 9));
            CrearAeropuerto(new Aeropuerto("BOG", "Bogotá", 290, 9));
            CrearAeropuerto(new Aeropuerto("SCL", "Santiago de Chile", 270, 8));
            CrearAeropuerto(new Aeropuerto("LIM", "Lima", 265, 8));
            CrearAeropuerto(new Aeropuerto("PTY", "Ciudad de Panamá", 260, 8));
            CrearAeropuerto(new Aeropuerto("ATL", "Atlanta", 490, 16));
            CrearAeropuerto(new Aeropuerto("SYD", "Sídney", 430, 15));
            CrearAeropuerto(new Aeropuerto("NRT", "Tokio", 520, 19));
            CrearAeropuerto(new Aeropuerto("AMS", "Ámsterdam", 390, 13));
            CrearAeropuerto(new Aeropuerto("YYZ", "Toronto", 350, 11));
        }


        private void PrecargaUsuarios()
        {
            CrearUsuario(new ClientePremium(6000, "41223344", "Federico", "Uruguayo", "fede@gmail.com", "fedePass1"));
            CrearUsuario(new ClientePremium(7500, "47889900", "Antonella", "Argentina", "antone@hotmail.com", "antone123"));
            CrearUsuario(new ClientePremium(6900, "39997788", "Carlos", "Chileno", "carlos@gmail.com", "carlos456"));
            CrearUsuario(new ClientePremium(8100, "46775522", "Florencia", "Uruguaya", "flor@hotmail.com", "flor2025"));
            CrearUsuario(new ClientePremium(7200, "45556677", "Valentina", "Paraguaya", "valen@gmail.com", "valenSecure"));
            CrearUsuario(new ClienteOcasional("54433211", "Mariana", "Peruana", "mariana@hotmail.com", "mariClave9"));
            CrearUsuario(new ClienteOcasional("52334455", "Gustavo", "Uruguayo", "gustavo@gmail.com", "gusPass77"));
            CrearUsuario(new ClienteOcasional("49998822", "Paula", "Argentina", "paula@gmail.com", "paulaClave"));
            CrearUsuario(new ClienteOcasional("43337755", "Emiliano", "Chileno", "emi@hotmail.com", "emiPass123"));
            CrearUsuario(new ClienteOcasional("41112233", "Lucas", "Boliviano", "lucas@gmail.com", "lucasPass10"));
            CrearUsuario(new Administrador("elAdmin", "admin@gmail.com", "admin11234"));
            CrearUsuario(new Administrador("elAdmin2", "admin2@gmail.com", "admin21234"));
        }


        private void PrecargaRutas()
        {
            CrearRuta(new Ruta(BuscarAeropuertoPorId("MVD"), BuscarAeropuertoPorId("EZE"), 200));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("GRU"), BuscarAeropuertoPorId("JFK"), 7680));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("LAX"), BuscarAeropuertoPorId("MAD"), 9400));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("CDG"), BuscarAeropuertoPorId("LHR"), 340));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("FRA"), BuscarAeropuertoPorId("BCN"), 1140));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("MEX"), BuscarAeropuertoPorId("BOG"), 3160));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("SCL"), BuscarAeropuertoPorId("LIM"), 2450));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("PTY"), BuscarAeropuertoPorId("ATL"), 2700));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("SYD"), BuscarAeropuertoPorId("NRT"), 7830));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("AMS"), BuscarAeropuertoPorId("YYZ"), 5980));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("JFK"), BuscarAeropuertoPorId("LAX"), 3980));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("EZE"), BuscarAeropuertoPorId("MEX"), 7400));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("BCN"), BuscarAeropuertoPorId("MAD"), 500));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("MVD"), BuscarAeropuertoPorId("GRU"), 1560));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("CDG"), BuscarAeropuertoPorId("AMS"), 430));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("ATL"), BuscarAeropuertoPorId("YYZ"), 1190));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("SCL"), BuscarAeropuertoPorId("PTY"), 4530));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("FRA"), BuscarAeropuertoPorId("LHR"), 660));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("NRT"), BuscarAeropuertoPorId("MAD"), 10780));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("SYD"), BuscarAeropuertoPorId("EZE"), 11850));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("AMS"), BuscarAeropuertoPorId("CDG"), 430));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("JFK"), BuscarAeropuertoPorId("ATL"), 1220));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("MEX"), BuscarAeropuertoPorId("LAX"), 2500));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("MVD"), BuscarAeropuertoPorId("BOG"), 4900));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("YYZ"), BuscarAeropuertoPorId("LHR"), 5700));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("LIM"), BuscarAeropuertoPorId("SCL"), 2450));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("GRU"), BuscarAeropuertoPorId("PTY"), 5300));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("AMS"), BuscarAeropuertoPorId("FRA"), 360));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("MAD"), BuscarAeropuertoPorId("EZE"), 10100));
            CrearRuta(new Ruta(BuscarAeropuertoPorId("BOG"), BuscarAeropuertoPorId("ATL"), 3170));
        }

        private void PrecargaVuelos()
        {
            CrearVuelo(new Vuelo("DL9206", BuscarRuta(0), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday }));
            CrearVuelo(new Vuelo("GC6460", BuscarRuta(9), BuscarAvion(3), new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("LJ2307", BuscarRuta(22), BuscarAvion(3), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("KD819", BuscarRuta(27), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Thursday }));
            CrearVuelo(new Vuelo("DH346", BuscarRuta(17), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("WK9241", BuscarRuta(29), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("ZM7686", BuscarRuta(1), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Friday }));
            CrearVuelo(new Vuelo("EO5374", BuscarRuta(11), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("RI8209", BuscarRuta(21), BuscarAvion(3), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Thursday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("QF3232", BuscarRuta(26), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }));
            CrearVuelo(new Vuelo("DX2450", BuscarRuta(2), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("SG587", BuscarRuta(24), BuscarAvion(3), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Friday }));
            CrearVuelo(new Vuelo("CW1148", BuscarRuta(1), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("HY5571", BuscarRuta(26), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("GV5618", BuscarRuta(15), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday }));
            CrearVuelo(new Vuelo("KO1396", BuscarRuta(10), BuscarAvion(3), new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("SZ2234", BuscarRuta(23), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday }));
            CrearVuelo(new Vuelo("SM1154", BuscarRuta(29), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("EV5474", BuscarRuta(5), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Thursday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("EH8134", BuscarRuta(2), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday }));
            CrearVuelo(new Vuelo("OY3651", BuscarRuta(2), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("SY688", BuscarRuta(26), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Sunday, DayOfWeek.Monday, DayOfWeek.Thursday }));
            CrearVuelo(new Vuelo("IK9538", BuscarRuta(17), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("OY1561", BuscarRuta(2), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("CX6683", BuscarRuta(13), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Friday }));
            CrearVuelo(new Vuelo("PJ9321", BuscarRuta(28), BuscarAvion(2), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Saturday }));
            CrearVuelo(new Vuelo("TA3376", BuscarRuta(6), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Thursday }));
            CrearVuelo(new Vuelo("MT7309", BuscarRuta(12), BuscarAvion(3), new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday }));
            CrearVuelo(new Vuelo("CH3100", BuscarRuta(18), BuscarAvion(0), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday }));
            CrearVuelo(new Vuelo("UH3033", BuscarRuta(10), BuscarAvion(1), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Thursday }));
        }

        private void PrecargarPasajes()
        {
            CrearPasaje(new Pasaje(BuscarVuelo("CW1148"), new DateTime(2025, 4, 17), BuscarClientePorCI("46775522"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("TA3376"), new DateTime(2025, 6, 11), BuscarClientePorCI("52334455"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("WK9241"), new DateTime(2025, 6, 29), BuscarClientePorCI("41112233"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("LJ2307"), new DateTime(2025, 11, 3), BuscarClientePorCI("46775522"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("OY1561"), new DateTime(2025, 12, 1), BuscarClientePorCI("54433211"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("ZM7686"), new DateTime(2025, 3, 7), BuscarClientePorCI("45556677"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("UH3033"), new DateTime(2025, 7, 10), BuscarClientePorCI("41112233"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("HY5571"), new DateTime(2025, 10, 8), BuscarClientePorCI("52334455"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("EV5474"), new DateTime(2025, 12, 16), BuscarClientePorCI("49998822"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("KO1396"), new DateTime(2025, 1, 24), BuscarClientePorCI("46775522"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("OY1561"), new DateTime(2025, 6, 22), BuscarClientePorCI("54433211"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("OY3651"), new DateTime(2025, 7, 30), BuscarClientePorCI("52334455"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("KO1396"), new DateTime(2025, 8, 15), BuscarClientePorCI("47889900"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("KD819"), new DateTime(2025, 11, 20), BuscarClientePorCI("45556677"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("KD819"), new DateTime(2025, 12, 23), BuscarClientePorCI("39997788"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("SM1154"), new DateTime(2025, 1, 26), BuscarClientePorCI("41112233"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("GC6460"), new DateTime(2025, 9, 12), BuscarClientePorCI("47889900"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("ZM7686"), new DateTime(2025, 3, 14), BuscarClientePorCI("41223344"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("SM1154"), new DateTime(2025, 4, 27), BuscarClientePorCI("41112233"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("CH3100"), new DateTime(2025, 9, 17), BuscarClientePorCI("39997788"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("EH8134"), new DateTime(2025, 5, 19), BuscarClientePorCI("41112233"), Pasaje.Equipaje.CABINA));
            CrearPasaje(new Pasaje(BuscarVuelo("EH8134"), new DateTime(2025, 5, 26), BuscarClientePorCI("47889900"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("ZM7686"), new DateTime(2025, 4, 18), BuscarClientePorCI("41223344"), Pasaje.Equipaje.LIGHT));
            CrearPasaje(new Pasaje(BuscarVuelo("SZ2234"), new DateTime(2025, 10, 13), BuscarClientePorCI("49998822"), Pasaje.Equipaje.BODEGA));
            CrearPasaje(new Pasaje(BuscarVuelo("IK9538"), new DateTime(2025, 12, 12), BuscarClientePorCI("39997788"), Pasaje.Equipaje.BODEGA));
        }
        public Aeropuerto? BuscarAeropuertoPorId(string codigo)
        {
            foreach (Aeropuerto aero in aeropuertos)
            {
                if (aero.CodigoIATA == codigo)
                {
                    return aero;
                }
            }
            return null;
        }

        public Avion? BuscarAvion(int id)
        {
            foreach (Avion av in aviones)
            {
                if (av.Id == id)
                {
                    return av;
                }
            }
            return null;
        }

        public Ruta? BuscarRuta(int id)
        {
            foreach (Ruta ru in rutas)
            {
                if (ru.Id == id)
                {
                    return ru;
                }
            }
            return null;
        }

        public Vuelo? BuscarVuelo(string numero)
        {
            foreach (Vuelo vue in vuelos)
            {
                if (vue.NumeroDeVuelo == numero)
                {
                    return vue;
                }
            }
            return null;
        }

        public Cliente? BuscarClientePorCI(string cedula)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu is Cliente cli)
                {
                    if (cli.Cedula == cedula)
                    {
                        return cli;
                    }
                }
            }
            return null;
        }

        //metodo que devuelve los vuelos que contienen el aeropuerto que tenga un codigo IATA especificado
        public List<Vuelo> BuscarVuelosPorIATA(string codigoIATA)
        {
            List<Vuelo> vuelosPorCodigo = new List<Vuelo>();
            foreach (Vuelo vue in vuelos)
            {
                if (vue.RutaQueCubre.AeropuertoDeLlegada.CodigoIATA == codigoIATA || vue.RutaQueCubre.AeropuertoDeSalida.CodigoIATA == codigoIATA)
                {
                    vuelosPorCodigo.Add(vue);
                }
            }

            return vuelosPorCodigo;
        }

        //metodo que devuelve los pasajes entre 2 fechas.
        public List<Pasaje> BuscarPasajesEntreFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Pasaje> pasajesEntreFechas = new List<Pasaje>();
            foreach (Pasaje pas in pasajes)
            {
                if (pas.Fecha >= fechaInicio && pas.Fecha <= fechaFinal)
                {
                    pasajesEntreFechas.Add(pas);
                }
            }
            return pasajesEntreFechas;
        }

        public List<Vuelo> BuscarVueloPorRutas(string aeropuerto1, string aeropuerto2)
        {
            List<Vuelo> vuelosPorRuta = new List<Vuelo>();
            foreach (Vuelo vue in vuelos)
            {
                if (vue.RutaQueCubre.AeropuertoDeSalida.CodigoIATA == aeropuerto1 && vue.RutaQueCubre.AeropuertoDeLlegada.CodigoIATA == aeropuerto2)
                {
                    vuelosPorRuta.Add(vue);
                }
            }
            return vuelosPorRuta;
        }

        //metodo que devuelve los usuarios que son clientes.
        public List<Usuario> FiltrarClientes()
        {
            List<Usuario> clientesFiltrados = new List<Usuario>();
            foreach (Usuario cli in usuarios)
            {
                if (cli is Cliente)
                {
                    clientesFiltrados.Add(cli);
                }
            }
            return clientesFiltrados;

        }
        public Usuario? BuscarUsuarioPorPwYMail(string mail, string password)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.Mail == mail && usu.Password == password)
                {
                    return usu;
                }
            }
            return null;
        }
        public List<Vuelo> TodosLosVuelos()
        {
            return vuelos;
        }
        public List<Aeropuerto> TodosLosAeropuertos()
        {
            return aeropuertos;
        }
        public Cliente BuscarClientePorMail(string mail)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.Mail == mail && usu is Cliente cli)
                {

                    return cli;
                }
            }
            return null;
        }

        public List<Pasaje> TodosLosPasajes()
        {
            return pasajes;
        }

        public List<Pasaje> TodosLosPasajesAdmin()
        {
            pasajes.Sort();
            return pasajes;
        }

        public List<Cliente> TodosLosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (Usuario usu in usuarios)
            {
                if (usu is Cliente cliente)
                {
                    clientes.Add(cliente);
                }
            }
            clientes.Sort();
            return clientes;
        }

        public Cliente? ModificarCliente(string cedula, string premio, string puntos)
        {
            Cliente? clienteEncontrado = BuscarClientePorCI(cedula);
            if (clienteEncontrado != null)
            {
                if (clienteEncontrado is ClienteOcasional clienteOcasional)
                {
                    if(bool.TryParse(premio, out bool premiobool))
                    {
                        clienteOcasional.Premio = premiobool;
                    }
                }
                if (clienteEncontrado is ClientePremium clientePremium )
                {
                    if (int.TryParse(puntos, out int puntosInt))
                    {
                        clientePremium.Puntos = puntosInt;
                    }
                }
            }
            clienteEncontrado.Validar();
            return clienteEncontrado;
        }
    }
}
