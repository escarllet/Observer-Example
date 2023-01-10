using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7
{
    class PlanesOpcionales
    {
        public List<IObservador> observadors = new List<IObservador>();
        public void AgregarSub(IObservador observador)
        {
            observadors.Add(observador);
        }
        public void QuitarSub(IObservador observador)
        {
            observadors.Remove(observador);
        }
        public float Notificar(int id)
        {
            foreach (var item in observadors)
            {
                return item.AplicarDescuento(id);
                
            }
            return 0;
        }
    }
}
