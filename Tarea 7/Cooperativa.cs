using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7
{
    class Cooperativa : IObservador
    {
        public float AplicarDescuento(int id)
        {
            float descuento = 0.07f;
            float descuentoAplicado;
    
                descuentoAplicado = Empleado.listEmpleados[id].Salario * descuento;                
                Console.WriteLine("Se ha descontado por la Cooperativa: "+ descuentoAplicado + " pesos del salario");
            return descuento;



        }
    }
}
