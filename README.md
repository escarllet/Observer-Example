# Observer - Example
Ejemplo de patrón de diseño Observer C# .net 

Aplica descuentos al salario dependiendo de si el empleado está inscrito a 1,2 y/o 3 de los planes opcionales.

## ¿Qué hace?

<ul>
<li> Crea/Guarda Empleados </li>
<li> Inscribe/Cancela Planes Opcionales (cooperativa, farmacia y plan funerario) </li>
<li> Registra consumo del balance de farmacia (solo si el empleado está inscrito en ese plan) </li>
<li> Realiza cálculo de nómina </li>
</ul>

## ¿Cómo lo hace?

Utilizando el patrón de diseño Observer u Observador puedo controlar a cuál empleado se le aplica que descuento dependiendo de si este se inscribió anteriormente a ese plan en particular.

He aquí el diseño UML.

[![UML.png](https://i.postimg.cc/JhC911WD/UML.png)](https://postimg.cc/dhnW6c3w)
