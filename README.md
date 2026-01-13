# proyecto-ia-mejoras-software-registrador-datos
“Mejoras al software de configuración de registradores de datos basados en Arduino y ESP32.”

Este repositorio contiene la base documental y el código de una aplicación en **C# (Windows Forms)** para **configurar registradores de datos** basados en **Arduino y ESP32**.  
El trabajo se centra en describir el funcionamiento observable del configurador (a partir del código fuente), generar archivos **JSON** de configuración y documentar un plan de pruebas funcionales (PoC).  
Incluye además recomendaciones de mejoras de software de bajo costo para trabajo futuro.

---

## Requisitos

- **Sistema operativo:** Windows 10/11  
- **IDE:** Visual Studio (recomendado 2019/2022)  
- **Framework:** .NET (según el proyecto C# incluido)  
- **Dependencias:** Newtonsoft.Json (Json.NET) y bibliotecas estándar de WinForms / SerialPort

> Nota: Si el proyecto no restaura paquetes automáticamente, usar “Restore NuGet Packages” desde Visual Studio.

---

## Estructura del repositorio

- `/src` → Código fuente de la aplicación C# (WinForms)  
- `/docs` → Informe técnico
- `/assets` → Capturas, diagramas y material visual  
- `/examples` → Archivos JSON exportados por la aplicación (ejemplos)

---

## Cómo compilar y ejecutar

1. Abrir Visual Studio.
2. Ir a **File → Open → Project/Solution**.
3. Seleccionar la solución/proyecto dentro de `/src` (archivo `.sln` o `.csproj`).
4. Compilar: **Build → Build Solution**
5. Ejecutar: **Debug → Start Debugging** (o `Ctrl+F5` para ejecutar sin depurar)

---

## Cómo generar archivos JSON (pasos en la aplicación)

La aplicación permite generar distintos archivos JSON a partir de la configuración realizada en la interfaz:

### A) Crear parámetros (configuración por sensor/propiedad)
1. En la pantalla principal (Form1), usar **Añadir** para abrir el formulario de edición (DataForm).
2. En DataForm, completar los campos disponibles (según UI):
   - Parámetro / Propiedad
   - Sensor (dependiente del parámetro)
   - Socket_Number (según la lista del configurador)
   - Math_Analysis (tipo de análisis estadístico)
   - Parameter_Title (unidad o título)
3. Confirmar para que el parámetro aparezca en la tabla (DataGridView).

### B) Exportar configuración general (SystemConfig)
1. En Form1, establecer los campos globales:
   - Devices (p. ej., Arduino)
   - Sampling_Time
   - Baudrate
   - WiFi_Name / WiFi_Password (si aplica)
2. Usar la opción de **Guardar configuración** (SystemConfig).
3. Seleccionar la ruta y guardar el archivo JSON.

### C) Exportar “database” (lista simplificada por IDs)
1. Con la lista de parámetros ya creada, usar la opción de **Guardar database**.
2. Seleccionar la ruta y guardar el JSON generado (lista de objetos con IDs).

### D) (Opcional) Enviar actualización de fecha/hora por puerto serie
1. Seleccionar el puerto COM.
2. Abrir el puerto.
3. Presionar **Update** (envía el JSON de fecha/hora).

---

## Cómo reproducir las pruebas (T1–T7)

Las pruebas están diseñadas para poder ejecutarse con la aplicación compilada.  
La evidencia sugerida puede ser captura de pantalla, archivo exportado o grabación corta de pantalla.

### T1 — Añadir parámetro
- **Procedimiento:** Añadir → completar DataForm → Confirmar  
- **Resultado esperado:** aparece una nueva fila en la tabla

### T2 — Editar parámetro
- **Procedimiento:** seleccionar fila → Editar → modificar → Confirmar  
- **Resultado esperado:** la fila queda actualizada

### T3 — Eliminar parámetro
- **Procedimiento:** seleccionar fila → Eliminar  
- **Resultado esperado:** la fila desaparece y la tabla se actualiza

### T4 — Guardar SystemConfig
- **Procedimiento:** completar campos globales → Guardar configuración → elegir ruta  
- **Resultado esperado:** se crea un archivo JSON (SystemConfig)

### T5 — Guardar database
- **Procedimiento:** con N parámetros creados → Guardar database → elegir ruta  
- **Resultado esperado:** se crea un JSON con N entradas (IDs)

### T6 — Puerto serie: abrir/cerrar
- **Procedimiento:** seleccionar COM → Abrir → Cerrar  
- **Resultado esperado:** estado de conexión consistente (habilitación de botones/indicadores)

### T7 — Update datetime (serie)
- **Procedimiento:** puerto abierto → presionar Update  
- **Resultado esperado:** se envía un JSON de fecha/hora por el puerto serie  
  - **Evidencia opcional:** monitor serial u otro receptor mostrando la trama

---

## Autores / Créditos

- **Estudiante:** Daniel de la Cruz Medina (4to de Automática)  
- **Profesor:** Alain Martínez  
- **Universidad:** Universidad Central “Marta Abreu” de Las Villas  
- **Asignatura:** Ingeniería Automática
