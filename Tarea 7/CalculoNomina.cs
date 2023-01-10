using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7
{
    class CalculoNomina
    {

        public void calculoNomina()
        {
            PlanFarmacia planFarma = new PlanFarmacia();
            PlanFunerario planFuner = new PlanFunerario();
            Cooperativa cooperativa = new Cooperativa();
            PlanesOpcionales planes = new PlanesOpcionales();

            float descuentoTotal = 0;
            float SalarioNeto = 0;
            float AFP, SFS;
            for (int i = 0; i < Empleado.listEmpleados.Count; i++)
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine("Nombre del empleado: " + Empleado.listEmpleados[i].Nombre + " " + Empleado.listEmpleados[i].Apellido);
                Console.WriteLine("Salario bruto: " + Empleado.listEmpleados[i].Salario);
                AFP = Empleado.listEmpleados[i].Salario * 0.0287f;
                SFS = Empleado.listEmpleados[i].Salario * 0.0304f;
                Console.WriteLine("Descuento AFP: "+AFP);
                Console.WriteLine("Descuento SFS: " + AFP);
                //si se tiene que cacular, se añade
                if (Empleado.listEmpleados[i].planFar)
                {
                    planes.AgregarSub(planFarma);
                }
                if (Empleado.listEmpleados[i].planFun)
                {
                    planes.AgregarSub(planFuner);
                }
                if (Empleado.listEmpleados[i].planFun)
                {
                    planes.AgregarSub(cooperativa);
                }
                // se notifica
                descuentoTotal += planes.Notificar(i);
                descuentoTotal += AFP + SFS;
                SalarioNeto = Empleado.listEmpleados[i].Salario - descuentoTotal;
                Console.WriteLine("Salario Neto: " + SalarioNeto);
                //como ya se notifico, limpio la lista, para empezar otra vez con otro empleado
                planes.observadors.Clear();
                Console.WriteLine("=============================================================");
            }
            Console.WriteLine("=============================================================" +
                "\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
