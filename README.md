# Restaurante System 🍽️

## Realizado por

- William Ramírez
- Daniel Diaz
- Romel Gualoto

Sistema de gestión de reservas para restaurantes pequeños y medianos, desarrollado con principios de arquitectura limpia y buenas prácticas de programación.

## Objetivo

Automatizar y optimizar el proceso de reservas de mesas mediante un sistema modular que combina microservicios y un núcleo monolítico.

## Tecnologías utilizadas

- .NET Core 8 – Backend de las APIs
- Angular – Aplicación web SPA (cliente)
- SQL Server – Base de datos relacional
- RabbitMQ – Cola de mensajes para eventos
- Kong – API Gateway
- Docker – Contenedores
- Prometheus – Monitoreo

## Arquitectura general

- **Monolito (MVC):** Gestión de reservas y lógica central.
- **Microservicio:** Autenticación y manejo de usuarios.
- **API Gateway (Kong):** Enrutamiento y seguridad.
- **RabbitMQ:** Integración por eventos asíncronos.

## Estructura del proyecto
restaurante-system/
│
├── README.md
├── .gitignore
├── RestBook.Reservations/ # Núcleo monolítico
├── AuthService/ # Microservicio de autenticación
├── Frontend/ # Cliente SPA en Angular
└── docker-compose.yml # Infraestructura de contenedores

