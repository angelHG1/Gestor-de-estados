# Gestor-de-estados

## Explicacíon del problema
Se solicitó un programa que permita gestionar solicitudes con el uso de enumeradores y listas principalmente, el programa debe permitir registrar una nueva solicitud, mostrar todas las solicitudes registradas, cambiar el estado de una solicitud existente y buscar una solicitud por ID. Así como tambien debe tener la capacidad de validar que los estados solo puedan ser seleccionados a partir del enumerador.

## Uso del enum en el pragrama
Se creó un enumerador llamado EstadoSolicitud el cual incluye como constante 4 valores posibles para las solicitudes: Pendiente, EnProceso, Aprobada y Cancelada.
Se usó este enumerador para evitar errores de escritura limitando las opciones disponibles, así mejorando la claridad del codigo.

## Uso de lista
Como se solicitó que se puedan manejar mas de una solicitud dentro del programa (digase guardarlas o modificarlas), se hizo uso de una lista del tipo "Solicitud"
para que pueda guardar en un solo espacio de la lista todos los datos de una solucitud, como es Id, nombre, etc.

## Flujo del programa y casos de uso (Screenshots)
