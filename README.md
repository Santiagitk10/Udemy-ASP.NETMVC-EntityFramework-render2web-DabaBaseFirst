# Udemy-ASP.NETMVC-EntityFramework-render2web-DabaBaseFirst

Scaffolding 
Para hacer el scaffolding de las tablas de la base de datos a código se utiliza el siguiete comando. NOTA: A partir de .Net6 se debe agregar el Encrypt en false en la cadena de conexión

Scaffold-DbContext "Server=RENDER2WEB\SQLEXPRESS;Database=BasePruebaReverse;User ID=render2web;Password=123456;Encrypt=false" Microsoft.EntityFrameworkCore.SqlServer

NOTA: Usándo este método se crean todos los modelos en cualquier parte dentro del proyecto. Es mejor hacerlo de forma personalizada


Para hacerlo de manera personalizada se crean los folders que se requieran, en este caso Datos y Modelos, se setea la cadena de conexión en el program. Se hace la inicialización del archivo de DbContext. Una vez se tenga esto se utiliza el siguiente comando en la consola del administrador de paquetes:

Scaffold-DbContext "AQUICONEXIONBASEDEDATOS" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Datos -Context ApplicationDbContext -Force

NOTA: El -Force en el comando anterior es para que cuando se vuelva a correr el comando si se modifica la base de datos el sistema reescriba los modelos que ya existían. 
