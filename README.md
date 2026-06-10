# CitasApp

App de citas médicas construida con ASP.NET Core MVC (.NET 10).

## Arquitectura

Hexagonal (Ports & Adapters) dividida en cuatro proyectos:

| Proyecto | Responsabilidad |
|---|---|
| `CitasApp.Domain` | Modelos e interfaces (sin dependencias externas) |
| `CitasApp.Application` | Servicios de aplicación (orquesta el Domain) |
| `CitasApp.Infrastructure` | Repositorios JSON y en memoria (implementa las interfaces del Domain) |
| `CitasApp.Web` | Controllers, views y configuración (MVC) |

## Flujo de dependencias

```
Web → Application → Domain ← Infrastructure
```

## Entidades

- **Paciente** — lista y detalle de pacientes registrados
- **Médico** — lista y detalle de médicos disponibles
- **Cita** — agenda completa y filtro por paciente

## Persistencia

Archivos JSON en `CitasApp.Web/data/`:

- `pacientes.json`
- `medicos.json`
- `citas.json`

También incluye `MemoriaPacienteRepository` para demostrar el swap de adapter.

## Navegación

| Ruta | Descripción |
|---|---|
| `/Paciente` | Lista de pacientes |
| `/Medico` | Lista de médicos |
| `/Cita` | Agenda completa |
| `/Cita/PorPaciente?pacienteId=1` | Citas de un paciente específico |

## Requisitos

- .NET 10.0
- Visual Studio 2022

## Ramas

| Rama | Descripción |
|---|---|
| `main` | Estado evaluable con persistencia JSON en un solo proyecto |
| `hexagonal` | Arquitectura hexagonal multi-proyecto con capa de aplicación |
