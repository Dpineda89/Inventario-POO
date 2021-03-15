using System;

namespace inventario
{
    class Program
    {

        static void Main(string[] args)  {
            string opcion = "";
            Inventario inventario = new Inventario();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Ajuste positivo de Inventario");
                Console.WriteLine("5 - Ajuste negavito de Inventario");
                Console.WriteLine("");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        inventario.listarProductos();
                        break;
                    case "2":
                        inventario.ingresoDeInventario();
                        break;
                    case "3":
                        inventario.salidaDeInventario();
                        break;
                    case "4":
                        inventario.positivoDeInventario();
                        break;
                    case "5":
                        inventario.negativoDeInventario();
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