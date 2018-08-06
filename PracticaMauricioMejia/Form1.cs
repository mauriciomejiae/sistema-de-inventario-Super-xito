/*
Planteamiento del problema:
El Almacén Superéxito, requiere realizar una aplicación para llevar el control de su inventario 
que contenga una interfaz gráfica de usuario que permita a través de opciones, registrar, eliminar
productos y salir de la aplicación. Para el registro de productos se requiere el código, el nombre,
la descripción, el precio y el tipo de producto ya sea este (electrodoméstico, electrónico, 
comestible o de hogar) estos tipos de productos se requiere que se seleccionen de una lista
desplegable al hacer el registro. La eliminación debe realizarse en el mismo orden de ingreso,
cumpliendo así con el comportamiento de una Cola, es decir el primero que ingresa es el primero
que sale, a través de la colección genérica Queue <T>. adicionalmente se requiere conocer el 
acumulado total del valor del inventario ingresado a la cola.

==========================================================================================
Curso: Estructura de datos
Autor: Mauricio Mejia Estevez
Fecha: Diciembre 12 de 2017
Licencia: Creaive Commons 
===========================================================================================
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMauricioMejia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtContraseña;  /*Focus caja de texto contraseña al iniciar el formulario*/
        }

        private void tsmAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Mauricio Mejia Estevez \n Curso: Estructura de Datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmNombreApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre App: Sistema de inventario Superéxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmPlanteamiento_Click(object sender, EventArgs e)
        {
            string Planteamiento = "El Almacén Superéxito, requiere realizar una aplicación para llevar el control de su inventario que contenga una interfaz " +
                "gráfica de usuario que permita a través de opciones, registrar, eliminar productos y salir de la aplicación. Para el registro de productos se" +
                " requiere el código, el nombre, la descripción, el precio y el tipo de producto ya sea este (electrodoméstico, electrónico, comestible o de hogar)" +
                " estos tipos de productos se requiere que se seleccionen de una lista desplegable al hacer el registro. La eliminación debe realizarse en el mismo" +
                " orden de ingreso, cumpliendo así con el comportamiento de una Cola, es decir el primero que ingresa es el primero que sale, a través de la colección" +
                " genérica Queue <T>. adicionalmente se requiere conocer el acumulado total del valor del inventario ingresado a la cola.";
            MessageBox.Show(Planteamiento, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "123")
            {
                error.SetError(txtContraseña, "");
                MessageBox.Show("Bienvenido al sistema de inventario - Superéxito", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            else
            {
                error.SetError(txtContraseña, "Debe ingresar la contraseña correcta");
                txtContraseña.Focus();
                return;
            }
            error.SetError(txtContraseña, "");
        }

    }
    
}
