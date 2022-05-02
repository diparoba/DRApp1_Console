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

            int numeroVehiculos = 0;
            Console.WriteLine("Ingrese los coches que va a registrar");
            numeroVehiculos = int.Parse(Console.ReadLine());
            Console.WriteLine(numeroVehiculos);
            vehiculo[] itemVehiculo = new vehiculo[numeroVehiculos];
            int codigo = 0;
            String placa;
            String modelo;
            String color;
            String motor;
            String estado = "A";

                for (int i = 0; i < numeroVehiculos; i++)
            {
                codigo = i;
                Console.WriteLine("Ingrese la placa del vehículo " + (i+1));
                placa = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo del vehículo " + i);
                modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el color del vehículo " + i);
                color = Console.ReadLine();
                Console.WriteLine("Ingrese el motor del vehículo " + i);
                motor = Console.ReadLine();

                itemVehiculo[i] = new vehiculo(codigo, placa, modelo, color, motor, estado);

            }

            for(int i = 0; i < itemVehiculo.Length; i++)
            {
                Console.WriteLine("El código del vehiculo " + i + " es: " + itemVehiculo[i].codigo);
                Console.WriteLine("Su placa es: " + itemVehiculo[i].placa);
                Console.WriteLine("Su modelo es: " + itemVehiculo[i].modelo);
                Console.WriteLine("Su color es: " + itemVehiculo[i].color);
                Console.WriteLine("Su placa es: " + itemVehiculo[i].motor);
            }






            




            /*vehiculo[] listaCoches =
            {
                new vehiculo(),
            };

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
            
            
          
            

            var listadoFiltro = vehiculos.Where(data => data.estado.Equals("A"));
            //la funcion .Where es de linQ y lo que hace es hacer una consulta y devolver una consulta parecida al where de sql
            foreach(vehiculo itemVehiculo in listadoFiltro)
            {
                Console.WriteLine("Codigo: " + itemVehiculo.codigo);
                Console.WriteLine(itemVehiculo.placa);
                Console.WriteLine(itemVehiculo.marca);  
                Console.WriteLine(itemVehiculo.motor);
                Console.WriteLine(itemVehiculo.estado);
            } */
            Console.ReadLine();
        }
        
    }
}
