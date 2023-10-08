# Problema 1
La creación de un sistema de generación de informes personalizados con diferentes
formatos de salida

Problema: Sistema de Generación de Informes Personalizados

L@ llamaron para desarrollar un software empresarial que necesita generar informes a
partir de una base de datos. Los informes pueden tener diferentes formatos de salida, como
PDF, Excel y HTML. Además, cada tipo de informe puede requerir pasos específicos de
generación, como consultar la base de datos, aplicar cálculos y formatear el resultado final.
Dado que los informes y los formatos de salida pueden ser diversos, es importante tener
una solución que maneje esta complejidad y permita la generación de informes de manera
flexible y extensible.

El patrón de diseño que escoja debe permitir manejar la variación en la generación de
informes y formatos de salida, al tiempo que garantiza que los pasos generales sean
consistentes para todos los tipos de informes. Esto facilita la extensión del sistema a medida
que se agregan nuevos tipos de informes o formatos de salida en el futuro.

#Justificación
Se eligió el patrón de comportamiento “Command”:

Para la generación de informes personalizados, este patrón nos permite tener flexibilidad al ejecutar las diferentes acciones,
 como objetos diferentes e independientes, facilitando las ejecuciones, adicionalmente nos permite ejecutarla de manera fácil en diferentes momentos,
 permitiendo ser escalable ya sea para agregar informes o formatos de salida sin alterar el código existente.

