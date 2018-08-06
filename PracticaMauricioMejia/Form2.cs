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
    public partial class Form2 : Form
    {
        Queue<ClsProducto> misProductos = new Queue<ClsProducto>();  /*Creación de la cola*/

        public Form2()
        {
            InitializeComponent();
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList; /*No permitir modificar el ComboBox Tipo*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCodigo;  /*Focus caja de texto código al iniciar el formulario*/
            CalcularTotales();
        }

        private void btnSalir_Click(object sender, EventArgs e) /*Creación del evento al presionar el botón salir*/
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cbxTipo.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtDescripcion.Enabled = true;

            if (!ValidarCodigo()) return; /*Validar que ingrese el código del producto antes de regristar*/

            if (ExisteCodigo(txtCodigo.Text)) /*Llamada al método ExisteCodigo*/
            {
                epvError.SetError(txtCodigo,"Código EAN ya ha sido registrado.");
                txtCodigo.Focus();
                return;
            }

            if (cbxTipo.Text == "") /*Validación*/
            {
                epvError.SetError(cbxTipo, "Debe seleccionar el tipo de producto.");
                cbxTipo.Focus();
                return;
            }
            epvError.SetError(cbxTipo, "");

            if (txtNombre.Text == "") /*Validación*/
            {
                epvError.SetError(txtNombre, "Debe ingresar el nombre  del producto.");
                txtNombre.Focus();
                return;
            }
            epvError.SetError(txtNombre, "");
             
            if (txtPrecio.Text == "") /*Validación*/
            {
                epvError.SetError(txtPrecio, "Debe ingresar el precio  del producto.");
                txtPrecio.Focus();
                return;
            }
            epvError.SetError(txtPrecio, "");

            if (txtDescripcion.Text == "") /*Validación*/
            {
                epvError.SetError(txtDescripcion, "Debe ingresar la descripción del producto.");
                txtDescripcion.Focus();
                return;
            }
            epvError.SetError(txtDescripcion, "");

            Int64 codigo; /*Validar que solo ingrese un valor numerico entero en el textbox codigo*/
            if (!Int64.TryParse(txtCodigo.Text, out codigo))
            {
                epvError.SetError(txtCodigo, "Debe ingresar un valor numerico entero.");
                txtCodigo.Focus();
                return;
            }
            epvError.SetError(txtCodigo, "");

            decimal precio; /*Validar que solo ingrese un valor numerico (puede ser Coma flotante) en el textbox */
            if (!Decimal.TryParse(txtPrecio.Text, out precio))
            {
                epvError.SetError(txtPrecio, "Debe ingresar un valor numerico.");
                txtPrecio.Focus();
                return;
            }
            epvError.SetError(txtPrecio, "");


            ClsProducto miProducto = new ClsProducto();
            miProducto.Codigo = txtCodigo.Text;
            miProducto.Tipo = cbxTipo.Text;
            miProducto.Nombre = txtNombre.Text;
            miProducto.Precio = Decimal.Parse(txtPrecio.Text);
            miProducto.Descripcion = txtDescripcion.Text;
            misProductos.Enqueue(miProducto); /* Encolar datos del objeto*/
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = misProductos.ToList();
            LimpiarCampos();
            txtCodigo.Focus();
            CalcularTotales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cbxTipo.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtDescripcion.Enabled = true;

            if (misProductos.Count != 0)
            {
                DialogResult rta = MessageBox.Show(this, "¿Esta seguro que desea eliminar el producto de la cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No) return;

                ClsProducto miProducto = new ClsProducto();
                miProducto = misProductos.Dequeue();
                txtCodigo.Text = miProducto.Codigo;
                cbxTipo.Text = miProducto.Tipo;
                txtNombre.Text = miProducto.Nombre;
                txtPrecio.Text = miProducto.Precio.ToString();
                txtDescripcion.Text = miProducto.Descripcion;
                dgvListaProductos.DataSource = misProductos.ToList();
                MessageBox.Show("¡El registro que estaba en cola fue eliminado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("La cola está vacia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
            }
            txtCodigo.Focus();
            CalcularTotales();
        }

        public void LimpiarCampos() /*Creación del método para limpiar los campos del formulario*/
        {
            txtCodigo.Clear();
            cbxTipo.SelectedIndex = -1;
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
        }

        public void CalcularTotales() /*Creación del método para calcular los totales */
        {
            double acumuladorTotalRegistros = 0;
            double acumuladorTotalAcumulado = 0;
            foreach (DataGridViewRow row in dgvListaProductos.Rows)
            {
                acumuladorTotalRegistros = dgvListaProductos.Rows.Count;
                acumuladorTotalAcumulado += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            txtTotalRegistros.Text = Convert.ToString(acumuladorTotalRegistros);
            txtTotalAcumulado.Text = Convert.ToString(acumuladorTotalAcumulado);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!ValidarCodigo()) return;
            ClsProducto miProducto = GetProducto(txtCodigo.Text);
            if(miProducto == null)
            {
                epvError.SetError(txtCodigo, "El producto no existe en la cola.");
                txtCodigo.Focus();
                return;
            }
            epvError.SetError(txtCodigo, "");

            txtCodigo.Text = miProducto.Codigo;
            cbxTipo.Text = miProducto.Tipo;
            txtNombre.Text = miProducto.Nombre;
            txtPrecio.Text = miProducto.Precio.ToString();
            txtDescripcion.Text = miProducto.Descripcion;

            cbxTipo.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtDescripcion.Enabled = false;
        }
       
        private bool ValidarCodigo()
        {
            if(txtCodigo.Text == "")
            {
                epvError.SetError(txtCodigo, "Debe ingresar el codigo EAN del producto.");
                txtCodigo.Focus();
                return false;
            }epvError.SetError(txtCodigo, "");
            return true;
        }

        private bool ExisteCodigo(string Codigo)         /*Método para validar si el codigo ya esta registrado*/
        {
            foreach (ClsProducto ExisteCodigo in misProductos)
            {
                if (ExisteCodigo.Codigo == Codigo) return true;
            }
            return false;
        }


        private ClsProducto GetProducto (string Codigo)
        {
            foreach (ClsProducto miProducto in misProductos)
            {
                if (miProducto.Codigo == Codigo) return miProducto;
            }
            return null;
        }


        private void txtCodigo_MouseDown(object sender, MouseEventArgs e) /*Evento para habilitar las cajas de texto y limpiarlas 
            cuando el puntero del mouse esta sobre txtCodigo y se presiona un botón del mouse*/
        {
            cbxTipo.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtDescripcion.Enabled = true;
            LimpiarCampos();

        }

        private void btnSalir_MouseEnter(object sender, EventArgs e) /*Evento que permite ver el label Salir a pasar el puntero sobre el btnSalir*/
        {
            lblSalir.Visible = true;

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e) /*Evento que permite ocultar el label Salir a pasar el puntero sobre el btnSalir*/
        {
            lblSalir.Visible = false;
        }


        private void pbxLicencia_MouseHover(object sender, EventArgs e)
        {
            txtLicencia.Visible = true;
            txtLicencia.Text = ("PracticaMauricioMejia por Mauricio Mejia Estevez se distribuye bajo una Licencia Creative Commons " +
                "Atribución-NoComercial-SinDerivar 4.0 Internacional.");
        }

        private void pbxLicencia_MouseLeave(object sender, EventArgs e)
        {
            txtLicencia.Visible = false;
        }
    }
}
