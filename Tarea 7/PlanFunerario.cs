using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7
{
    class PlanFunerario : IObservador
    {
        public float AplicarDescuento(int id)
        {
            int montoMin = 20000;
            int descuentoFijo = 1500;
            float descuento;
            if (Empleado.listEmpleados[id].Salario >= montoMin)
            {
                descuento = Empleado.listEmpleados[id].Salario - descuentoFijo;
                Console.WriteLine("Se ha descontado por el Plan de Funerario: " + descuentoFijo + " pesos del salario");
                return descuento;
            }
            else
            {
                Console.WriteLine("Se ha descontado por el Plan de Funerario: 0 pesos del salario");
                return 0;
            }
            
        }
    }
}
