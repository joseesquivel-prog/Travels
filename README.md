# TravelApp - Sistema de Viajes y Envío de Paquetes

Esta es una aplicación completa desarrollada en .NET 8 que consta de dos proyectos:

## Proyectos

### 1. TravelApp.API
- **Puerto:** https://localhost:7000
- Web API que proporciona endpoints RESTful
- Entity Framework Core con SQL Server LocalDB
- Swagger UI para documentación de la API
- CORS configurado para permitir conexiones desde el MVC

### 2. TravelApp.MVC
- **Puerto:** https://localhost:7001
- Aplicación MVC para la interfaz de usuario
- Consume la API mediante HttpClient
- Bootstrap 5 para el diseño responsivo
- Validaciones del lado cliente y servidor

## Funcionalidades

### Gestión de Pasajes
- Reserva de pasajes de viaje
- Selección de origen y destino
- Múltiples horarios disponibles
- Cálculo automático de costos
- Validaciones completas

### Gestión de Paquetes
- Registro de envíos
- Información de remitente y destinatario
- Cálculo de costos por peso
- Seguimiento de estado
- Fecha de entrega estimada

### Características Técnicas
- Arquitectura separada (API + MVC)
- Modelos con validaciones
- Interfaz moderna y responsiva
- Comunicación asíncrona entre proyectos
- Manejo de errores y mensajes de éxito

## Configuración para Visual Studio 2022

### Pasos para ejecutar:

1. **Abrir la solución:**
   - Abrir `TravelApp.sln` en Visual Studio 2022

2. **Configurar proyectos de inicio múltiples:**
   - Click derecho en la solución → "Set Startup Projects"
   - Seleccionar "Multiple startup projects"
   - Configurar ambos proyectos como "Start":
     - TravelApp.API
     - TravelApp.MVC

3. **Configurar puertos (si es necesario):**
   - TravelApp.API: https://localhost:7000
   - TravelApp.MVC: https://localhost:7001

4. **Base de datos:**
   - La aplicación usa SQL Server LocalDB
   - Ejecutar en Package Manager Console (proyecto API):
     ```
     Add-Migration InitialCreate
     Update-Database
     ```

5. **Ejecutar:**
   - Presionar F5 o "Start" para ejecutar ambos proyectos
   - La API se abrirá con Swagger UI
   - El MVC se abrirá con la interfaz de usuario

## Estructura de la Solución

```
TravelApp/
├── TravelApp.API/
│   ├── Controllers/
│   ├── Data/
│   ├── Models/
│   └── Program.cs
├── TravelApp.MVC/
│   ├── Controllers/
│   ├── Models/
│   ├── Services/
│   ├── Views/
│   └── Program.cs
└── TravelApp.sln
```

## URLs de Acceso

- **API:** https://localhost:7000/swagger
- **Aplicación Web:** https://localhost:7001

La aplicación está lista para desarrollo local. Los proyectos están completamente separados y se comunican únicamente a través de las APIs REST.