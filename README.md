
# Mi Día — Gestor de Actividades con .NET MAUI

## Descripción del proyecto

Mi Día es una aplicación móvil desarrollada con .NET MAUI, utilizando C# y XAML. Su objetivo es ayudar a los usuarios a organizar sus actividades diarias de forma sencilla, permitiéndoles llevar un control de las tareas que tienen pendientes y de las que ya completaron.

La aplicación cuenta con dos pantallas principales. La primera permite consultar las actividades registradas, marcarlas como completadas, eliminarlas y revisar el progreso diario. La segunda contiene un formulario para agregar nuevas actividades con su nombre, descripción y categoría.

También incluye validaciones para evitar que se guarden actividades con información incompleta y un sistema de almacenamiento local que permite conservar los datos aunque se cierre la aplicación.

Este proyecto fue desarrollado como parte de una investigación del curso Desarrollo de Software IV de la Universidad de Costa Rica, con el propósito de conocer el funcionamiento de .NET MAUI y aplicar conceptos de programación en C#, diseño de interfaces con XAML, navegación entre pantallas, manejo de eventos y almacenamiento de datos.

## Tecnologías utilizadas

- **.NET MAUI:** framework utilizado para desarrollar la aplicación móvil.
- **.NET 10:** versión de .NET utilizada en el proyecto.
- **C#:** lenguaje de programación utilizado para implementar la lógica y las funcionalidades.
- **XAML:** lenguaje utilizado para diseñar las pantallas y sus componentes visuales.
- **Visual Studio Code:** entorno que puede utilizarse para desarrollar y ejecutar el proyecto.
- **Extensión .NET MAUI de Microsoft:** permite trabajar con proyectos .NET MAUI desde Visual Studio Code.
- **Android SDK:** herramientas necesarias para compilar y ejecutar la aplicación en Android.
- **Emulador Android:** permite ejecutar y probar la aplicación desde una computadora.
- **Preferences:** herramienta de .NET MAUI utilizada para almacenar las actividades localmente.
- **JSON:** formato utilizado para guardar y recuperar la información de las actividades.

.NET MAUI permite desarrollar aplicaciones para diferentes plataformas utilizando una misma base de código. En este proyecto se configuró la ejecución para Android.

## Funcionalidades principales

La aplicación cuenta con las siguientes funcionalidades:

### 1. Lista de actividades

La pantalla principal muestra las actividades registradas mediante una lista.

Cada actividad contiene:

- Nombre de la actividad.
- Descripción.
- Categoría.
- Estado de la actividad, completada o pendiente.

Al iniciar la aplicación por primera vez, aparecen dos actividades de ejemplo que permiten conocer el funcionamiento de la lista.

Cuando no existen actividades registradas, se muestra un mensaje indicando que todavía no hay actividades y que se puede agregar una nueva.

### 2. Registro de actividades

La aplicación permite agregar nuevas actividades mediante un formulario que contiene tres campos:

- **Nombre:** permite escribir el nombre de la actividad.
- **Descripción:** permite indicar qué se necesita realizar.
- **Categoría:** permite seleccionar el tipo de actividad.

Las categorías disponibles son:

- Estudio.
- Personal.
- Ejercicio.
- Hogar.

El formulario incluye un botón para guardar la actividad y otro para cancelar el registro.

### 3. Validación de datos

Antes de guardar una actividad, la aplicación comprueba que los tres campos del formulario estén completos.

Si falta información, aparece el mensaje:

"Completá los tres campos antes de guardar."

En ese caso, la actividad no se registra hasta que el usuario complete los campos necesarios.

Cuando la información es válida, se crea la actividad, se guarda y aparece un mensaje de confirmación.

### 4. Marcar actividades como completadas

Cada actividad tiene una casilla que permite indicar si ya fue realizada.

Al marcar una actividad, su estado cambia a completada y se actualiza automáticamente el progreso mostrado en la pantalla principal.

También es posible desmarcarla si se necesita cambiar nuevamente su estado a pendiente.

Los cambios se guardan para conservar el estado de las actividades.

### 5. Eliminar actividades

La aplicación permite eliminar actividades que ya no se necesitan.

Al presionar el botón Eliminar, aparece un mensaje de confirmación con el nombre de la actividad seleccionada.

El usuario puede confirmar la eliminación o cancelarla.

Si confirma, la actividad se elimina de la lista, se actualiza el almacenamiento y se vuelve a calcular el progreso.

### 6. Seguimiento del progreso

La pantalla principal incluye una sección llamada "Tu progreso".

Esta sección muestra cuántas actividades se han completado respecto al total registrado.

También incluye una barra de progreso que cambia según la cantidad de actividades realizadas.

Por ejemplo, si existen cuatro actividades y se completaron dos, se muestra el siguiente resultado:

"2 de 4 actividades completadas"

La barra de progreso representa el 50 % de las actividades completadas.

### 7. Navegación entre pantallas

La aplicación utiliza la navegación de .NET MAUI mediante Shell.

Desde la pantalla principal, el usuario puede ingresar al formulario para registrar una nueva actividad.

Después de guardar, aparece un mensaje de confirmación y la aplicación regresa a la pantalla principal.

El botón Cancelar también permite regresar sin registrar una actividad.

### 8. Actualización de la lista

Las actividades se administran mediante una colección de tipo ObservableCollection.

Esta colección permite que la lista de la pantalla principal se actualice cuando se agregan o eliminan actividades.

De esta manera, los cambios pueden visualizarse sin necesidad de cerrar y volver a abrir la aplicación.

### 9. Almacenamiento local

La aplicación utiliza Preferences de .NET MAUI para conservar las actividades en el dispositivo.

Antes de guardar, la información de la colección se convierte a formato JSON mediante System.Text.Json.

Cuando se vuelve a abrir la aplicación, los datos guardados se recuperan y se cargan nuevamente en la lista.

Esto permite conservar las actividades registradas, incluyendo su estado de completada o pendiente.

No se necesita una conexión a Internet para utilizar estas funcionalidades.

## Requisitos para ejecutar el proyecto

Para ejecutar la aplicación en Windows es necesario contar con:

- SDK de .NET 10.
- Visual Studio Code con la extensión .NET MAUI, o Visual Studio con las herramientas de .NET MAUI.
- Herramientas de desarrollo de Android para .NET.
- Android SDK configurado.
- Emulador Android o dispositivo físico habilitado para desarrollo.

El proyecto está configurado para Android y establece Android 7.0 (API 24) como versión mínima compatible.

Las herramientas de desarrollo deben ser compatibles con la versión de .NET utilizada.

## Instalación y configuración

### 1. Preparar el entorno de desarrollo

Instalar el SDK de .NET 10 y un entorno de desarrollo compatible con .NET MAUI.

Si se utiliza Visual Studio Code, abrir la sección de extensiones e instalar .NET MAUI, publicada por Microsoft, junto con las extensiones de C# necesarias.

También se deben instalar el Android SDK y las herramientas correspondientes para trabajar con aplicaciones Android.

Documentación oficial de instalación:

https://learn.microsoft.com/es-es/dotnet/maui/get-started/installation

### 2. Comprobar las herramientas instaladas

Abrir una terminal de PowerShell y ejecutar:

```powershell
dotnet --info
```

Este comando permite consultar la versión del SDK de .NET y la información del entorno instalado.

Después ejecutar:

```powershell
dotnet workload list
```

Este comando muestra las cargas de trabajo instaladas y permite comprobar si se cuenta con las herramientas necesarias para desarrollar aplicaciones Android.

Si faltan componentes, deben instalarse siguiendo la documentación oficial de .NET MAUI.

### 3. Clonar el repositorio

Abrir una terminal y ejecutar:

```powershell
git clone https://github.com/mpauvenegue-coder/MAUI_GestorTareas_.git
```

Después ingresar a la carpeta del repositorio:

```powershell
cd MAUI_GestorTareas_
```

### 4. Abrir el proyecto

Abrir la carpeta del repositorio en Visual Studio Code o Visual Studio.

Localizar el archivo:

`GestorTareas.csproj`

Este archivo contiene la configuración principal del proyecto y permite identificar las dependencias y la plataforma de destino.

### 5. Comprobar la compilación

Desde una terminal ubicada en la carpeta principal del proyecto, ejecutar:

```powershell
dotnet build GestorTareas.csproj -f net10.0-android
```

Este comando permite comprobar que el proyecto pueda compilarse para Android.

Para ejecutarlo correctamente, deben estar instalados el SDK de .NET, las herramientas de .NET MAUI y los componentes de Android compatibles.

### 6. Preparar el emulador Android

Abrir el administrador de emuladores del entorno de desarrollo.

Si todavía no existe un dispositivo virtual, crear un emulador Android compatible.

Iniciar el emulador y comprobar que muestre la pantalla principal del sistema Android.

También se puede utilizar un dispositivo físico con las opciones de desarrollador y la depuración USB habilitadas.

### 7. Ejecutar la aplicación

Con el emulador Android iniciado o un dispositivo compatible conectado, seleccionar el proyecto y ejecutarlo desde el entorno de desarrollo.

También se puede utilizar el siguiente comando desde la carpeta principal:

```powershell
dotnet run --project GestorTareas.csproj -f net10.0-android
```

La ejecución mediante terminal requiere que el entorno Android esté correctamente configurado y que exista un dispositivo de destino disponible.

Al iniciar, la aplicación muestra la pantalla principal "Mi Día", con las actividades registradas.

## Estructura del proyecto

```text
MAUI_GestorTareas/
│
├── Models/
│   └── Actividad.cs
│
├── Services/
│   └── ActividadesService.cs
│
├── Views/
│   ├── InicioPage.xaml
│   ├── InicioPage.xaml.cs
│   ├── NuevaActividadPage.xaml
│   └── NuevaActividadPage.xaml.cs
│
├── Platforms/
│   └── Android/
│       ├── AndroidManifest.xml
│       ├── MainActivity.cs
│       └── MainApplication.cs
│
├── App.xaml
├── App.xaml.cs
├── AppShell.xaml
├── AppShell.xaml.cs
├── MauiProgram.cs
├── GestorTareas.csproj
├── .gitignore
└── README.md
```

### Archivos principales

- **MauiProgram.cs:** contiene la configuración inicial de .NET MAUI y prepara la aplicación para ejecutarse.
- **App.xaml:** contiene los recursos generales de la aplicación, incluyendo la definición del color principal.
- **App.xaml.cs:** crea la ventana principal utilizando AppShell.
- **AppShell.xaml:** define la pantalla inicial y la configuración visual de la navegación.
- **AppShell.xaml.cs:** registra la ruta utilizada para abrir el formulario de nuevas actividades.
- **Models/Actividad.cs:** define los datos de cada actividad, incluyendo título, descripción, categoría y estado.
- **Services/ActividadesService.cs:** administra la colección de actividades y permite guardar y recuperar los datos localmente.
- **Views/InicioPage.xaml:** contiene el diseño de la pantalla principal, la lista de actividades y la barra de progreso.
- **Views/InicioPage.xaml.cs:** contiene la lógica para actualizar el progreso, abrir el formulario, completar actividades y eliminarlas.
- **Views/NuevaActividadPage.xaml:** contiene el diseño del formulario para registrar nuevas actividades.
- **Views/NuevaActividadPage.xaml.cs:** contiene las validaciones, el registro de actividades y los eventos de los botones Guardar y Cancelar.
- **Platforms/Android:** contiene los archivos de configuración necesarios para ejecutar la aplicación en Android.
- **GestorTareas.csproj:** contiene la configuración general del proyecto, las dependencias y la plataforma de destino.
- **.gitignore:** indica qué carpetas y archivos generados no deben incluirse en el repositorio.

## Funcionamiento del código

La aplicación inicia mediante `MauiProgram.cs`, que configura .NET MAUI y prepara los componentes necesarios para su ejecución.

Después, `App.xaml.cs` crea la ventana principal utilizando `AppShell`, donde se establece `InicioPage` como pantalla inicial y se registra la ruta de navegación hacia `NuevaActividadPage`.

El modelo `Actividad.cs` define cuatro propiedades:

- `Titulo`: almacena el nombre de la actividad.
- `Descripcion`: almacena la información de la actividad.
- `Categoria`: indica el tipo de actividad.
- `Completada`: indica si la actividad está realizada o pendiente.

El servicio `ActividadesService.cs` utiliza una `ObservableCollection<Actividad>` para administrar las actividades.

Cuando se utiliza el servicio por primera vez, se ejecuta `CargarActividades()`, que intenta recuperar los datos guardados mediante Preferences.

Si existen datos válidos, estos se convierten desde JSON a una lista de actividades y se agregan a la colección.

Si no existen datos guardados, el servicio agrega dos actividades de ejemplo y las guarda localmente.

La pantalla `InicioPage` utiliza esta colección para mostrar las actividades.

Al presionar el botón para agregar una actividad, se ejecuta `OnAgregarClicked`, que abre `NuevaActividadPage` mediante Shell.

En el formulario, el método `OnGuardarClicked` obtiene el título, la descripción y la categoría seleccionada.

Después verifica que ninguno de los campos esté vacío. Si falta información, muestra un mensaje de error.

Si los datos son correctos, crea un objeto de tipo `Actividad`, lo agrega a la colección y llama a `GuardarActividades()`.

Este método utiliza `JsonSerializer.Serialize()` para convertir los datos a JSON y `Preferences.Default.Set()` para almacenarlos.

Cuando se guarda la actividad, aparece un mensaje de confirmación y la aplicación regresa a la pantalla principal.

Para completar una actividad, se utiliza el evento `OnCompletadaChanged`, que modifica la propiedad `Completada`, guarda los cambios y actualiza el progreso.

Para eliminar una actividad, se utiliza `OnEliminarClicked`, que solicita una confirmación antes de quitarla de la colección.

Finalmente, el método `ActualizarProgreso()` calcula la cantidad total de actividades y cuántas están completadas para actualizar el texto y la barra de progreso.

## Pruebas de funcionamiento

Para comprobar el funcionamiento de la aplicación, se pueden realizar las siguientes pruebas:

### 1. Inicio de la aplicación

Abrir la aplicación y comprobar que se muestra la pantalla "Mi Día".

En una instalación sin datos guardados deben aparecer las dos actividades de ejemplo.

### 2. Navegación al formulario

Presionar el botón para agregar una actividad y comprobar que se abre la pantalla "Nueva actividad".

### 3. Validación de campos vacíos

Intentar guardar una actividad sin completar los campos del formulario.

Se debe mostrar el mensaje de validación y evitar que se guarde la actividad.

### 4. Registro de una actividad

Completar el nombre, la descripción y la categoría.

Presionar "Guardar actividad" y comprobar que aparece el mensaje de confirmación.

Después verificar que la actividad aparezca en la pantalla principal.

### 5. Cancelación del registro

Abrir el formulario y presionar "Cancelar".

La aplicación debe regresar a la pantalla principal sin guardar una nueva actividad.

### 6. Marcar una actividad como completada

Seleccionar la casilla de una actividad.

Comprobar que su estado cambia y que se actualizan la cantidad de actividades completadas y la barra de progreso.

### 7. Eliminar una actividad

Presionar el botón Eliminar de una actividad.

Comprobar que aparece el mensaje de confirmación y que, al aceptar, la actividad desaparece de la lista.

### 8. Conservación de los datos

Agregar una actividad, cerrar la aplicación y volver a abrirla.

Comprobar que la actividad permanece registrada y que se conserva su estado.

### 9. Lista sin actividades

Eliminar todas las actividades registradas.

Comprobar que aparece el mensaje que indica que todavía no existen actividades.

Estas pruebas permiten verificar la navegación, las validaciones, el registro, la eliminación, el seguimiento del progreso y el almacenamiento local de los datos.

## Datos de ejemplo

Cuando no existen actividades guardadas, la aplicación registra automáticamente dos actividades.

| Nombre | Descripción | Categoría | Estado |
|---|---|---|---|
| Estudiar | Repasar para el examen | Estudio | Pendiente |
| Hacer ejercicio | Entrenar durante 30 minutos | Ejercicio | Pendiente |

Estas actividades permiten observar cómo se presenta la información en la pantalla principal.

También se pueden registrar actividades nuevas utilizando el formulario.

## Limitaciones

- La aplicación está configurada para ejecutarse en Android.
- No cuenta con una base de datos externa.
- No utiliza una API REST ni necesita conexión a Internet para administrar las actividades.
- Los datos se almacenan localmente y no se sincronizan entre diferentes dispositivos.
- Si se eliminan los datos de la aplicación desde la configuración del dispositivo, se pueden perder las actividades guardadas.
- No incluye cuentas de usuario ni inicio de sesión.
- No cuenta con una función para editar el título, la descripción o la categoría de una actividad después de guardarla.
- El rendimiento del emulador depende de los recursos disponibles en la computadora.

El proyecto se enfoca en implementar las funciones de un gestor de actividades utilizando .NET MAUI, C#, XAML y almacenamiento local.

## Integrantes

**Universidad de Costa Rica — Sede del Pacífico**

**Carrera:** Informática Empresarial

**Curso:** IF-0009 Desarrollo de Software IV

**Profesor:** Mag. Irwin Leal Elizondo

**Estudiantes:**

- Suly Daniela Bustos Medina — C5D410
- María Paula Venegas Sosa — C5K896

## Referencias

Microsoft. Documentación de .NET MAUI.

https://learn.microsoft.com/es-es/dotnet/maui/

Microsoft. Instalación de .NET MAUI.

https://learn.microsoft.com/es-es/dotnet/maui/get-started/installation

Microsoft. Almacenamiento de preferencias en .NET MAUI.

https://learn.microsoft.com/es-es/dotnet/maui/platform-integration/storage/preferences

Microsoft. Serialización y deserialización de JSON en .NET.

https://learn.microsoft.com/es-es/dotnet/standard/serialization/system-text-json/overview