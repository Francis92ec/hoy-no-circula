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


hoy-no-circula/
│
├── backend/
│   └── HoyNoCircula.Api/
│       ├── Controllers/
│       ├── Models/
│       ├── Dtos/
│       ├── Services/
│       ├── Data/
│       ├── Program.cs
│       └── appsettings.json
│
├── frontend/
│   └── hoy-no-circula-front/
│       ├── src/
│       ├── angular.json
│       ├── package.json
│       └── tsconfig.json
│
├── database/
│   └── scripts.sql
│
├── .gitignore
└── README.md
