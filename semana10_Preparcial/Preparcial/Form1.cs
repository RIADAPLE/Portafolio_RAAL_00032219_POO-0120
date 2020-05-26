using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial
{
    public partial class Form1 : Form
    {
        private Usuario usuario;
        public Form1(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = 
                "Bienvenido " + usuario.usuario + " [" + (usuario.admin ? "Administrador" : "Usuario") + "]";
            
            List<Prodcuto> lista1 = ProductoDAO.getLista();
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "precio";
            cmbProducto.DisplayMember = "nombre1";
            cmbProducto.DataSource = lista1;

            Prodcuto kk = (Prodcuto) cmbProducto.SelectedItem;
            label4.Text = "Precio: $" +kk.precio.ToString();
            
            if (usuario.admin)
            {    
                // Los administradores si tienen acceso a esta informacion
                actualizarControles();
                mostrarPedidos();
            }
            else
            {
                // Los usuarios NO administradores no tienen permiso de acceder a estas pestanas
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
            }
        }

        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<Usuario> lista = UsuarioDAO.getLista();
            
            // Tabla (data grid view)
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista;
            // Menu desplegable (combo box)
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = lista;
            
            List<Usuario> lista2 = UsuarioDAO.getLista();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista2;
        }

        private void mostrarPedidos()
        {
            List<Pedido> lista3 = PedidoDAO.getLista();
            dvgPedidos.DataSource = null;
            dvgPedidos.DataSource = lista3;
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.usuario + "?", 
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha sucedido un error, favor intente dentro de un minuto.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Su compra se ha realizado!", 
                "Comprado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}