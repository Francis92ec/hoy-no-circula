# 🚗 Hoy No Circula – Aplicación Web
# Francisco Valle

Aplicación web para el registro de vehículos y validación de circulación (Hoy No Circula) en función de la fecha y hora ingresadas.

El sistema permite:
- Registrar vehículos
- Consultar si un vehículo puede circular
- Mostrar el resultado en un modal con información del vehículo

---

## 🧱 Arquitectura

- Frontend: Angular
- Backend: ASP.NET Core Web API
- Base de datos: SQL Server
- Comunicación: REST (HTTP / JSON)

Arquitectura desacoplada lista para producción.

---

## 📂 Estructura del Proyecto
<img width="1133" height="638" alt="Arquitectura" src="https://github.com/user-attachments/assets/092e81a0-84ea-4903-bc2f-c14f8ef17ad7" />

## Requisitos Previos

Node.js 18+
Angular CLI
.NET SDK 8 o superior
SQL Server
Git

## Backend – Ejecución
cd backend/HoyNoCircula.Api
dotnet restore
dotnet run

## La API se levanta por defecto en:

https://localhost:7257

## Frontend – Ejecución
cd frontend/hoy-no-circula-front
npm install
ng serve

## La aplicación se levanta en:

http://localhost:4200

Base de Datos

Crear una base de datos en SQL Server

##  Ejecutar el script:
database/CreacionTablas.sql

Incluye:
Tabla Vehiculos
Tabla Consultas

## Endpoints Principales
- Registrar vehículo
POST /api/vehiculos

- Consultar Hoy No Circula
POST /api/vehiculos/consulta
