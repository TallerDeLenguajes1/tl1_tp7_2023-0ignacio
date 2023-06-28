## Respuesta Ejercicio 1

### "--output"
El parámetro "--output" se utiliza para especificar la ruta de salida del proyecto de consola generado. El valor " . " después del parámetro "--output" indica que el proyecto se generará en el directorio actual, es decir, el directorio en el que se ejecutó el comando.

### Consecuencias

1. Al especificar el directorio actual como la ruta de salida, el proyecto se generará en ese directorio. Esto significa que los archivos y carpetas del proyecto se agregarán al directorio en el que se encuentra cuando se ejecuta el comando. Si hay archivos o carpetas existentes en ese directorio con los mismos nombres, pueden producirse conflictos o se sobrescribirán.

2. Al no especificar una ruta específica después del "--output", se genera una estructura de directorios simplificada. Los archivos del proyecto, como el archivo de código fuente principal y el archivo de configuración, se colocarán directamente en el directorio actual, en lugar de tener una estructura de carpetas más compleja con subdirectorios separados para los archivos del proyecto.