using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7
{
    class Empleado
    {
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }
        public string Departamento { get; set; }
        public float ConsumoPlanFar { get; set; }

        public bool planFar = false;
        public bool planFun = false;
        public bool Cooper  = false;
        public static List<Empleado> listEmpleados = new List<Empleado>();
        
        public void crearEmpl()
        {
            int id;
            id = listEmpleados.Count;
            listEmpleados.Add(new Empleado());
            Console.WriteLine("Escriba el nombre del empleado");
            listEmpleados[id].Nombre = Console.ReadLine();
            Console.WriteLine("Escriba el apellido del empleado");
            listEmpleados[id].Apellido = Console.ReadLine();
            Console.WriteLine("Escriba el Departamento del empleado");
            listEmpleados[id].Departamento = Console.ReadLine();
            Console.WriteLine("Escriba el salario del empleado");
            listEmpleados[id].Salario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("=======================================================" +
                "\nEl id del empleado es: "+id+"\n \n presione cualquier tecla para continuar...");
            Console.ReadKey();

        }

        public void QuitarPonerPlan(int eleccion, int idempl)
        {
            //plan farmacia
            //entrar
            if (eleccion == 1 && listEmpleados[idempl].planFar)
            {
                Console.WriteLine("Ya estaba inscrito al plan Farmacia");
            }else if (eleccion == 1)
            {
                listEmpleados[idempl].planFar = true;
                Console.WriteLine("El empleado se a suscrito al plan de Farmacia, ya puede hacer consumos");
            }
            //salir
            else if (eleccion == 2 && listEmpleados[idempl].planFar == false)
            {
                Console.WriteLine("Usted No estaba inscrito al plan Farmacia ");
            }
            else if (eleccion == 2)
            {
                listEmpleados[idempl].planFar = false;               
                Console.WriteLine("El empleado se a Desuscrito al plan de Farmacia");
            }
            //plan funerario
            //entrar
            else if (eleccion == 3 && listEmpleados[idempl].planFun)
            {
                Console.WriteLine("Ya estaba inscrito al plan Funerario");
            }
            else if (eleccion == 3)
            {
                listEmpleados[idempl].planFun = true;
                Console.WriteLine("El empleado se a inscrito al plan de Funerario");
            }
            //salir
            else if (eleccion == 4 && listEmpleados[idempl].planFun == false)
            {
                Console.WriteLine("Ya estaba desuscrito del plan Funerario");
            }
            else if (eleccion == 4)
            {
                listEmpleados[idempl].planFun = false;
                Console.WriteLine("El empleado se a desuscrito del plan de Funerario");
            }
            //cooperativa
            //entrar
            else if (eleccion == 5 && listEmpleados[idempl].Cooper)
            {
                Console.WriteLine("Ya estaba inscrito al la cooperativa");
            }
            else if (eleccion == 5)
            {
                listEmpleados[idempl].Cooper = true;
                Console.WriteLine("El empleado se a inscrito en la cooperativa");
            }
            //salir
            else if (eleccion == 6 && listEmpleados[idempl].Cooper == false)
            {
                Console.WriteLine("Ya estaba desuscrito de la cooperativa");
            }
            else if (eleccion == 6)
            {
                listEmpleados[idempl].Cooper = false;
                Console.WriteLine("El empleado se a desuscrito de la cooperativa");
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor valido");
            }
        }
        public void ConsumoFarmacia(int consumo, int idempl)
        {
            if (listEmpleados[idempl].planFar)
            {
                listEmpleados[idempl].ConsumoPlanFar += consumo;
                Console.WriteLine("Se ha ejecutado el consumo");
            }
            else
            {
                Console.WriteLine("Usted no esta suscrito al plan de Farmacia");
            }
        }
        public bool BuscarLista(int id)
        {
            for (int i = 0; i < listEmpleados.Count; i++)
            {
                if (i == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
