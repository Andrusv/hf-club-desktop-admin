# Interfaz de usuario para proyecto HF-Club
* Se desarrolló la interfaz de usuario de administrador en desktop que interactuará con el API del proyecto 'hf-club-api', recibiendo, enviando y manipulando JSONs simples y anidados.

Para el proyecto se utilizó una arquitectura por layers, siendo estas mismas 'Presentation', 'Domain' y 'DataAcess'

*  Presentation: Capa de las interfaces de usuario, que interactuará directamente con la capa de 'Domain'.
*  Domain: Capa de lógica de negocio, que contiene todas las funciones y la mayoría de objetos en el proyecto, interactuando directamente con la capa de 'Domain'.
*  DataAcess: Capa de acceso de datos. Esta será la encargada de almacenar dentro de sí todas las librerías de conexión y manejo de datos que serán el resultado de interactuar con la API que a su vez se encargará de manejar toda la comunicación con las bases de datos MySQL y MongoDB.
