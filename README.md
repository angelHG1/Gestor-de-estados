# Gestor de solicitudes

## Explicacíon del problema
Se solicitó un programa que permita gestionar solicitudes con el uso de enumeradores y listas principalmente, el programa debe permitir registrar una nueva solicitud, mostrar todas las solicitudes registradas, cambiar el estado de una solicitud existente y buscar una solicitud por ID. Así como tambien debe tener la capacidad de validar que los estados solo puedan ser seleccionados a partir del enumerador.

## Uso del enum en el pragrama
Se creó un enumerador llamado EstadoSolicitud el cual incluye como constante 4 valores posibles para las solicitudes: Pendiente, EnProceso, Aprobada y Cancelada.
Se usó este enumerador para evitar errores de escritura limitando las opciones disponibles, así mejorando la claridad del codigo.

## Uso de lista
Como se solicitó que se puedan manejar mas de una solicitud dentro del programa (digase guardarlas o modificarlas), se hizo uso de una lista del tipo "Solicitud"
para que pueda guardar en un solo espacio de la lista todos los datos de una solucitud, como es Id, nombre, etc.

## Flujo del programa y casos de uso (Screenshots)
El programa inicia con un menu en cual mediante el uso de switch permite seleccionar la acción a realizar, donde la opción principal es la de agregar una nueva solicitud<img width="381" height="138" alt="image" src="https://github.com/user-attachments/assets/e3e15d13-61b1-4bab-9632-0a14b25e9aaa" />

Se pasa a rellenar los datos de la solicitud y a seleccionar el estado de la misma. Luego de los datos guardados, el programa limpia la interfaz y regresa al menú de incio <img width="332" height="171" alt="image" src="https://github.com/user-attachments/assets/ab2e794a-5919-4923-9e17-f9c7204b193c" />

Se pueden ver las solicitudes registradas: <img width="283" height="135" alt="image" src="https://github.com/user-attachments/assets/c132ad26-ed22-46dc-b596-24e7336b5024" />

Así como buscar o modificar una solicitud: <img width="351" height="217" alt="image" src="https://github.com/user-attachments/assets/daa112b8-fbd4-4523-ba86-2b9b612392ed" /> <img width="386" height="156" alt="image" src="https://github.com/user-attachments/assets/1b80e681-82ab-4c8e-bc8b-90369799b240" />

## Casos de uso 
### Seleccionar opcion invalida para el estado 
<img width="286" height="170" alt="image" src="https://github.com/user-attachments/assets/25cb4129-c2ab-4543-9a5a-844e37070774" />
### Buscar solicitud inexistente
<img width="624" height="148" alt="image" src="https://github.com/user-attachments/assets/5907fc39-50e9-4781-852e-be37df48b4f3" />
### Intentar mostrar las solicitudes antes de agregar alguna
<img width="513" height="266" alt="image" src="https://github.com/user-attachments/assets/0c27c980-ea97-4cd4-b7a2-7706d69f5767" />
<img width="388" height="113" alt="image" src="https://github.com/user-attachments/assets/f9bf2c8a-762c-4839-9600-63fff73a8a50" />







