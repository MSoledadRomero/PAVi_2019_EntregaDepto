# Proyecto - Biblioteca #
**Proyecto realizado como Trabajo Práctico Integrador de la materia Programación de Aplicaciones Visuales 1, realizado por Fernandez Ezequiel, Pereyra Diego y Romero María Candelaria.**

### Objetivo del sistema: ###
Procesar datos y brindar información que permita gestionar la consulta, compra, préstamo y devolución de libros de una biblioteca. Registrar los préstamos y devoluciones de ejemplares y generar el historial de los mismos. 
Emitiendo los documentos y reportes necesarios para mostrar la información adecuada.

### Alcances: ###
<ul>
<li> Registrar nuevo socio </li>
<li> Registrar nuevo proveedor </li>
<li> Registrar compra a proveedor </li>
<li> Registrar préstamo de libro </li>
<li> Registrar libros y ejemplares </li>
<li> Emitir información disponibilidad de libros </li>
<li> Emitir información libros y ejemplares </li>
<li> Emitir listado de socios </li>
<li> Emitir listado de prestamos </li>
<li> Emitir información de proveedores </li>
</ul>


### Script para Base de Datos ###
Se podrá visualizar el script de base de datos ingresando en el siguiente link: 

https://github.com/diego728/TP_Aplicaciones_Visuales/blob/master/Base%20de%20Datos/BaseDeDatos.sql


### Código y Base de Datos ###

El código fuente del proyecto fue compartido utilizando Git, un sistema de control de versión distribuida, y GitHub, que es un sitio web y un servicio en la nube que ayuda a los desarrolladores a almacenar y administrar su código.

Respecto a la base de datos, únicamente el script fue compartido utilizando el medio citado anteriormente; luego el archivo de la base de datos real fue generado por cada uno de los integrantes del grupo localmente en sus computadoras.

A lo largo del desarrollo del proyecto utilizamos diferentes ramas para ir agregando nueva funcionalidad al sistema, que una vez terminado su desarrollo, fusionábamos con la rama master.


### Desarrollo ###

Acordamos trabajar en capas para una mejor organización del proyecto.


#### **Capas:** ####

| Capa | Descripción|
| ------ | ------ |
|**GUILayer**| Esta capa es la que contiene todos los formularios que verá el usuario. Presenta el sistema al usuario, le comunica información y permite su interacción con el sistema. Por lo tanto esta capa debe ser entendible y fácil de usar para el usuario, esta fue la razón por la cual decidimos utilizar la herramienta Metro Framework para dar un aspecto mas amigable a la interfaz de nuestro proyecto.Esta capa se comunica únicamente con la capa de negocio.|
|**BussinesLayer**| Esta capa expone la lógica de negocio. Se comunicará con la capa de acceso a datos y brindará la funcionalidad requerida por la capa de presentación para que el usuario, a través de la interfaz, interactúe con la aplicación. |
|**DataAccess**| Esta capa proporciona un acceso simplificado a los datos almacenados, en el almacenamiento persistente en nuestro caso, una base de datos en SQL Server. En esta capa también se lleva a cabo el mapeo de modelo relacional a modelo de objetos. Todas las clases contenidas en esta capa utilizan la clase DBConexión para comunicarse con la base de datos.|
|**Entities**| Se encarga de contener todos aquellos objetos del dominio (clases) que representan al negocio. Esta es la única capa que es transversal a todas las demas, es decir que puede ser instanciada en cualquiera de las demás capas, solo ella puede tener comunicación con el resto pero su función se limita a únicamente ser un puente de transporte de datos. Esta capa complementa a la Capa de Negocio.|


### Test ###

Los testeos fueron llevados a cabo por cada uno de los integrantes del grupo de forma manual.
Además, a lo largo del cuatrimestre, se llevaron a cabo testeos en horario de clase y mediante presentaciones programadas con los profesores.


### Validación de Campos Obligatorios ###

Decidimos que todos los campos, tanto TextBox, como los ComboBox, fueran obligatorios al momento de realizar las inserciones o actualizaciones de datos.
La validación se hace a través de la clase SoporteForm, que se encuentra dentro de la carpeta Soporte. Esta se creó con el objetivo de obtener abstracción mayor de algunos métodos y poder reutilizarlos en los diferentes formularios.
Entre los métodos que posee la clase SoporteForm se encuentran los métodos de validación que son los siguientes:

Dos sobrecargas para el metodo validarText.

```c#
        public bool validarText(TextBox nombreText)
        {
            if (string.IsNullOrEmpty(nombreText.Text))
            {
                nombreText.BackColor = Color.Red;
                return false;
            }
            else
            {
                nombreText.BackColor = Color.White;
                return true;
            }
        }
```

```c#
         public bool validarText(MetroFramework.Controls.MetroTextBox nombreText)
        {
            if (string.IsNullOrEmpty(nombreText.Text))
            {
                nombreText.BackColor = Color.Red;
                return false;
            }
            else
            {
                nombreText.BackColor = Color.White;
                return true;
            }
        }
```

Dos sobrecargas para el metodo validarCombo.

```c#
        public bool validarCombo(ComboBox combo)
        {
            if (combo.SelectedIndex == -1)
            {
                combo.BackColor = Color.Red;
                return false;
            }
            else
            {
                combo.BackColor = Color.White;
                return true;
            }
        }
```

```c#
        public bool validarCombo(MetroFramework.Controls.MetroComboBox combo)
        {
            if (combo.SelectedIndex == -1)
            {
                combo.BackColor = Color.Red;
                return false;
            }
            else
            {
                combo.BackColor = Color.White;
                return true;
            }
        }
```

La primer sobrecarga de ambos metodos recibe como parámetro el text o combo proveniente de Windows Forms, mientras que la segunda recibe como parámetro el text o combo proveniente de MetroFramework.
Esto es debido a que comenzamos utilizando todas los objetos gráficos que ya venian en Visual Studio, pero posteriormente instalamos la herramienta nombrada anteriormente y utilizamos los objetos que esta nos proveía.

### Distribución de Trabajo ### 

Parte del trabajo que realizo cada integrante fue propuesto por la profesora.
La distribución del trabajo restante se realizo teniendo en cuenta el conocimiento de cada integrante para una equitativa y eficiente participación de los mismos.



