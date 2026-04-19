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

Se pasa a rellenar los datos de la solicitud y a seleccionar el estado de la misma. <img width="332" height="171" alt="image" src="https://github.com/user-attachments/assets/ab2e794a-5919-4923-9e17-f9c7204b193c" />


