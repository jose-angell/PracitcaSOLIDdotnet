# 🧱 Práctica de Principios SOLID en .NET

Este proyecto es una aplicación de consola desarrollada en C# con el objetivo de practicar y aplicar los principios SOLID, enfocados en ejemplos como la generación, guardado y envío de reportes.

---

## 📦 Estructura del Proyecto

```plaintext
PracitcaSOLID/
├── Reports/
│   ├── IReportGenerator.cs
│   ├── PdfReportGenerator.cs
│   ├── IReportSaver.cs
│   ├── DiskReportSaver.cs
│   ├── IReportSender.cs
│   ├── EmailReportSender.cs
│   └── ReportService.cs
├── Program.cs
├── PracitcaSOLID.csproj
└── ...
```
## 🎯 Objetivos
- Aplicar los principios SRP (Responsabilidad Única) y OCP (Abierto/Cerrado).

- Utilizar interfaces para invertir dependencias.

- Mejorar la testabilidad y extensibilidad del código.

- Practicar el diseño limpio y mantenible.

  ## ▶️ Cómo Ejecutar
- dotnet restore
- dotnet run

 ## 🛠️ Herramientas Usadas
- .NET SDK
- C#
- Visual Studio o VS Code
- xUnit (para pruebas)
- Moq (para mocks)
