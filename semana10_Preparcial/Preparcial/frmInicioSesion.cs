using System;
using System.Windows.Forms;

namespace Preparcial
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
        }

        private void btnIniSes_Click(object sender, EventArgs e)
        { 
            if (cmbUsuario.SelectedValue.Equals(txtContrasena.Text))
                {
                    Usuario u = (Usuario) cmbUsuario.SelectedItem;

                    MessageBox.Show("¡Bienvenido!", 
                            "Pc Gamer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Form1 ventana = new Form1(u);
                    ventana.Show();
                    this.Hide();
                    
                }
                else
                    MessageBox.Show("¡Contraseña incorrecta!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}