using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7
{
    class PlanFarmacia : IObservador
    {
        public float AplicarDescuento(int id)
        {
            float descuento;
            if (Empleado.listEmpleados[id].ConsumoPlanFar !=0)
            {
                descuento = Empleado.listEmpleados[id].ConsumoPlanFar / 2;
                Empleado.listEmpleados[id].ConsumoPlanFar -= descuento;
                Console.WriteLine("Se ha descontado por el Plan de Farmacia: " + descuento + " pesos del salario");
                return descuento;
            }
            else
            {
                Console.WriteLine("Se ha descontado por el Plan de Farmacia: 0 pesos del salario");
                return 0;
            }

        }
    }
}
