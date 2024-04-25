# personaapi_dotnet

## Instalación y Configuración
Cabe aclarar que todo se encuentra descrito a mayor detalle dentro del documento de implementación.

### 1. Instalación de SQL Server Express
Para este proyecto básico de MVC en Visual Studio con .NET, utilizaremos SQL Server Express como nuestro motor de base de datos. Sigue estos pasos para la instalación:
- Descarga el instalador desde el [enlace oficial de Microsoft](https://www.microsoft.com/en-us/download/details.aspx?id=104781&lc=1033).
- Sigue los pasos de instalación, eligiendo la instalación básica del servicio.
- Después de la instalación, asegúrate de copiar el String de conexión necesario para futuras configuraciones:

### 2. Instalación de SQL Server Management Studio
Para administrar SQL Server, necesitaremos SQL Server Management Studio (SSMS). Sigue estos pasos:
- Descarga SSMS desde el [sitio oficial de Microsoft](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).
- Abre SSMS y establece la conexión al servidor SQL Server previamente instalado.
- Recupera el String de Conexión, ya que será necesario más adelante.

### 3. Instalación de Visual Studio Community 2022
Para desarrollar el proyecto MVC en Visual Studio con .NET, necesitaremos Visual Studio. Sigue estos pasos:
- Descarga Visual Studio desde el [sitio oficial de Microsoft](https://visualstudio.microsoft.com/downloads/).
- Durante la descarga, asegúrate de seleccionar los complementos necesarios.

## Creación de Base de Datos y Proyecto

### 1. Creación de base de datos y tablas
Ejecuta el ddl anexo para crear la base de datos 'persona_db' y las tablas necesarias. También el DML, para tener datos iniciales.

### 2. Creación de Proyecto
En Visual Studio, crea un nuevo proyecto utilizando la plantilla de Aplicación Web de ASP.NET Core (Modelo-Vista-Controlador). Asegúrate de seleccionar .NET 8.0 como framework.

###3. Instalación de paquetes NuGet
Instala los siguientes paquetes NuGet para trabajar con bases de datos en una aplicación .NET utilizando Entity Framework Core:

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

### 4. Conexión a SQL Express
Añade una dependencia de servicio para conectar tu proyecto al servicio de SQL Server Express local. Utiliza el String de conexión proporcionado anteriormente.


