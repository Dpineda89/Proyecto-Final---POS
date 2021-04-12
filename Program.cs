using System;

namespace POS_proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePOS datos = new DatosdePOS();
            
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
                Console.WriteLine("||            Sistema de VENTAS              ||");
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
                Console.WriteLine("||                                           ||");
                Console.WriteLine("||              1 - Lista de Inventario      ||");
                Console.WriteLine("||              2 - Crear Factura            ||");
                Console.WriteLine("||              3 - Lista de Clientes        ||");
                Console.WriteLine("||              4 - Lista de Vendedores      ||");
                Console.WriteLine("||              5 - Reporte de Ventas        ||");
                Console.WriteLine("||              0 - Salir                    ||");
                Console.WriteLine("||                                           ||");
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarInventaio();
                        break;
                    case "2":
                        datos.Venta();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarVendedores();
                        break;      
                    case "5":
                        datos.ListarFacturas();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}