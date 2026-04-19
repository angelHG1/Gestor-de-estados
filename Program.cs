using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestor_Enumeradores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion_est, opcion;
            List<Solicitud> solicitudes = new List<Solicitud>();

            while (true)
            {
                Console.WriteLine("Bienvenido al gestor de solicitudes XYZ\n\nQué desea realizar? ");
                menu();
                Console.Write("---> ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Nueva solicitud\n");
                        Console.Write("Ingrese ID del producto: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese la descripción del producto: ");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("Seleccione el estado del producto ");
                        menu_est();
                        Console.Write("---> ");
                        opcion_est = int.Parse(Console.ReadLine());

                        if (opcion_est >= 1 && opcion_est <= 4)
                        {
                            EstadoSolicitud estado = (EstadoSolicitud)(opcion_est - 1);
                            Solicitud nueva = new Solicitud(id, nombre, descripcion, estado);
                            solicitudes.Add(nueva);

                            Console.WriteLine("Registro Guardado exitosamente!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida para el estado.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        if (solicitudes.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No hay solicitudes registradas\n");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            foreach (var s in solicitudes)
                            {
                                s.Mostrar();
                            }
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case 3:
                            Console.Clear();
                            Console.Write("Ingrese el ID del producto que desea buscar: ");
                            int idBuscar = int.Parse(Console.ReadLine());

                            bool encontrada = false;

                        foreach (var s in solicitudes)
                        {
                            if (s.Id == idBuscar)
                            {
                                Console.WriteLine("Solicitud encontrada:");
                                s.Mostrar();
                                encontrada = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }

                        if (encontrada==false)
                        {
                            Console.WriteLine("Solicitud no encontrada.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                        case 4:
                            Console.Clear();
                        Console.Write("Ingrese el ID de la solicitud a modificar: ");
                        idBuscar = int.Parse(Console.ReadLine());

                        encontrada = false;

                        foreach (var s in solicitudes)
                        {
                            if (s.Id == idBuscar)
                            {
                                Console.WriteLine("Solicitud encontrada:");
                                s.Mostrar();

                                Console.WriteLine("\nSeleccione el nuevo estado:");
                                menu_est();
                                opcion_est = int.Parse(Console.ReadLine());

                                s.Estado = (EstadoSolicitud)(opcion_est - 1);

                                Console.WriteLine("Estado actualizado correctamente.");
                                encontrada = true;
                                break;
                            }
                        }

                        if (!encontrada)
                        {
                            Console.WriteLine("Solicitud no encontrada.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void menu()
        {
            Console.WriteLine("1. Nueva solicitud");
            Console.WriteLine("2. Mostrar todas las solicitudes");
            Console.WriteLine("3. Buscar solicitud");
            Console.WriteLine("4. Modificicar estado de solicitud");
        }
        static void menu_est()
        {
            Console.WriteLine("1. Pendiente");
            Console.WriteLine("2. En proceso");
            Console.WriteLine("3. Aprobada");
            Console.WriteLine("4. Cancelada");
        }
    }

    public class Solicitud
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EstadoSolicitud Estado { get; set; }

        public Solicitud(int id, string nombre, string descripcion, EstadoSolicitud estado)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }

        public void Mostrar()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Cliente: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine("---------------------------------");
        }
    }
    public enum EstadoSolicitud
    {
        Pendiente,
        EnProceso,
        Aprobada,
        Cancelada
    }
}
