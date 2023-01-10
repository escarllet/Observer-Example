using System;

namespace Tarea_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoNomina Calculo = new CalculoNomina();
            Empleado empleados = new Empleado();
            int eleccion=0;
            do
            {
                
                Console.WriteLine("Bienvenido/a\nQue desea Hacer?(ingrese el numero)" +
                 "\n1.Crear empleado" +
                 "\n2.Inscripcion / cancelacion de los planes (cooperativa , farmacia y plan funerario)" +
                 "\n3.El registro del consumo de farmacia"+
                 "\n4.El calculo de la nomina" +
                 "\n\n=========================================================================" +
                 "\n0.Salir del programa");
                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (eleccion)
                {
                    case 0:
                        break;
                    case 1:                       
                        empleados.crearEmpl();
                        break;
                    case 2:
                        int eleccion2 =0;
                     
                        do
                        {
                            Console.WriteLine("Ingrese el id del empleado");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (empleados.BuscarLista(id))
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("El nombre del empleado es: " + Empleado.listEmpleados[id].Nombre + " "+ Empleado.listEmpleados[id].Apellido
                                    + "\nQue desea Hacer?(Ingrese el numero de la eleccion)" +
                                    "\n1.Inscribirse en el Plan Farmacia" +
                                    "\n2.Cancelar incripcion del Plan Farmacia" +
                                    "\n3.Inscribirse en el Plan Funerario" +
                                    "\n4.Cancelar incripcion del Plan Funerario" +
                                    "\n5.Inscribirse en la Cooperativa" +
                                    "\n6.Cancelar incripcion de la Cooperativa");

                                    eleccion2 = Convert.ToInt32(Console.ReadLine());
                                    empleados.QuitarPonerPlan(eleccion2, id);
                                    Console.WriteLine("\n======================================================" +
                                        "\nDesea repetir el proceso?" +
                                        "\n1.Si, quiero seleccionar otro empleado" +
                                        "\n2.Si, pero quiero el mismo empleado" +
                                        "\n0.No quiero, volver al menu anterior");
                                    eleccion2 = Convert.ToInt32(Console.ReadLine());
                                } while (eleccion2 ==2);

                            }
                            else
                            {
                                Console.WriteLine("Error: El empleado no existe");
                            }
                        } while (eleccion2 !=0);
                       
                        break;
                    case 3:
                        int eleccion3 = 0;
                        do
                        {
                            Console.WriteLine("Ingrese el id del empleado");
                            int idem = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (empleados.BuscarLista(idem))
                            {
                                Console.WriteLine("Cuanto va a consumir?");
                                int consumo = Convert.ToInt32( Console.ReadLine());
                                empleados.ConsumoFarmacia(consumo,idem);
                            }
                            else
                            {
                                Console.WriteLine("Error: El empleado no existe");
                            }
                            Console.WriteLine("Que desea hacer?(ingrese el numero)" +
                                "\n0 = Ir al menu anterior" +
                                "\ncualquier otro numero = Repetir seccion (volver a escoger empleado)");
                            eleccion3 = Convert.ToInt32(Console.ReadLine());
                        } while (eleccion3 !=0);
 
                        break;
                    case 4:
                        Calculo.calculoNomina();
                        break;
                    default:
                        Console.WriteLine("Error: Ingrese un valor valido");
                        break;
                }
                Console.Clear();
            } while (eleccion !=0);
            Console.WriteLine("=========================================================================" +
                 "\nPresione cualquier tecla para salir del programa...");
        }


    }
}
