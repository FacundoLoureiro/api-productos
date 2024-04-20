# api-productos #ASPNETCore #WebAPI #SQLServer #CRUD
API CRUD
Descripcion:
API CRUD desarrollada con ASP.NET Core Web API que permite realizar operaciones básicas de Crear (Create), Leer (Read), Actualizar (Update) y Eliminar (Delete) en una base de datos SQL Server. Proporciona endpoints para realizar las siguientes operaciones:

1. Alta (Create): Permite agregar nuevos registros a la base de datos.
2. Baja (Delete): Permite eliminar registros existentes de la base de datos.
3. Modificación (Update): Permite actualizar registros existentes en la base de datos.
4. Consulta por ID (Read): Permite obtener un registro específico de la base de datos utilizando su identificador único.
5. Consulta de toda la lista (Read): Permite obtener todos los registros almacenados en la base de datos.
   
La API está conectada a una base de datos SQL Server para almacenar y recuperar los datos.

Instrucciones de uso
Para usar la API CRUD, sigue estos pasos:

1. Clonar el repositorio desde GitHub: Clona el repositorio de tu API CRUD desde GitHub a tu máquina local.
2. Configurar la conexión a la base de datos: Abre el archivo de configuración de la base de datos (appsettings.json) y proporciona los detalles de conexión de tu base de datos SQL Server. Asegúrate de incluir el nombre del servidor, el nombre de la base de datos y las credenciales de tu usuario de SQL Server.
Agregar el usuario de SQL Server: Asegúrate de que tu usuario de SQL Server tenga los permisos adecuados para acceder y modificar la base de datos que especificaste en la configuración. Si es necesario, crea un nuevo usuario en SQL Server y otórgale los permisos necesarios.
3. Compilar y ejecutar la API: Compila la solución de tu API CRUD y ejecútala en tu entorno de desarrollo.
4. Accede a la documentación de Swagger: Una vez que la API esté en funcionamiento, accede a la documentación de Swagger en tu navegador web navegando a la URL de la API (https://localhost:<puerto>/swagger). Aquí encontrarás una interfaz interactiva que te permitirá probar y explorar los diferentes endpoints de la API.
6. Probar los endpoints de la API: Utiliza la interfaz de Swagger para probar los diferentes endpoints de la API, incluyendo la creación, eliminación, actualización y consulta de registros.
7. Integrar la API en tu aplicación: Una vez que hayas probado la API y estés satisfecho con su funcionalidad, intégrala en tu aplicación cliente para realizar operaciones CRUD en la base de datos desde tu aplicación.
