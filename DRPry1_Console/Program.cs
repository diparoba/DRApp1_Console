using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPry1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<vehiculo> vehiculos = new List<vehiculo>();
            vehiculo vehiculo1 = new vehiculo();
            vehiculo1.codigo = 1;
            vehiculo1.placa = "tbc1244";
            vehiculo1.marca = "toyota";
            vehiculo1.motor = "5.2";
            vehiculo1.estado = "A";
            vehiculo vehiculo2 = new vehiculo();
            vehiculo2.codigo = 2;
            vehiculo2.placa = "tbc1314";
            vehiculo2.marca = "mercedes";
            vehiculo2.motor = "5.3";
            vehiculo2.estado = "A";
            
                vehiculos.Add(vehiculo1);
            vehiculos.Add(vehiculo2);

            var listadoFiltro = vehiculos.Where(data => data.estado.Equals("A") && data.codigo.Equals("A"));
            foreach(vehiculo itemVehiculo in listadoFiltro)
            {
                Console.WriteLine("Codigo: " + itemVehiculo.codigo);
                Console.WriteLine(itemVehiculo.placa);
                Console.WriteLine(itemVehiculo.marca);  
                Console.WriteLine(itemVehiculo.motor);
                Console.WriteLine(itemVehiculo.estado);
            }
            Console.ReadLine();
                }
        
    }
}
