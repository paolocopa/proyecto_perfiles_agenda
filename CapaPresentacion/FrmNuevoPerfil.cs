using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmNuevoPerfil : Form
    {
        NegocioPerfil obj = new NegocioPerfil();
        
        public FrmNuevoPerfil()
        {
            InitializeComponent();
            Inicializador();
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmPrincipal.frmNuevoPerfilCerrado = true;
            this.Close();
        }
        #region Arrastrar_Form

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevoP_Click(object sender, EventArgs e)
        {
            string tema = txtTema.Text.ToString();
            string estado = txtEstado.Text.ToString();
            string fecha_presentacion = dtPresentacion.Value.ToString("yyyy-MM-dd");
            string registro = txtRegistro.Text.ToString();
            string nombre = txtNombre.Text.ToString();
            string apellido = txtApellido.Text.ToString();
            string email = txtEmail.Text.ToString();
            string telefono = txtTelefono.Text.ToString();
            string celular = txtCelular.Text.ToString();
            int id_carrera = Convert.ToInt32(cmbCarrera.SelectedValue.ToString());
            int id_licenciado = Convert.ToInt32(cmbTutor.SelectedValue.ToString());
            bool res = obj.Perfil_insert(tema, estado, fecha_presentacion, registro, nombre, apellido, email, telefono, celular, id_carrera, id_licenciado);
            if(res == true)
            {
                LimpiarForm();
                MessageBox.Show("perfil registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar perfil ");
            }

           // CapaDatos.PerfilTesis obj = new CapaDatos.PerfilTesis();
            //string i = Convert.ToString( obj.UltimoId());
           // MessageBox.Show(tema + " " + estado + " " + fecha_presentacion + " " + registro + " " + nombre + " " + apellido + " " + email + " " + telefono + " " + celular+" "+id_carrera+" "+id_licenciado);


        }
        public void Inicializador()
        {
            cmbCarrera.Items.Clear();
            cmbTutor.Items.Clear();
            LimpiarForm();

            cmbCarrera.DataSource = obj.cargarCarreras();
            cmbCarrera.DisplayMember = "nombre";
            cmbCarrera.ValueMember = "id";
            cmbTutor.DataSource = obj.cargarLicenciados();
            cmbTutor.DisplayMember = "nombre";
            cmbTutor.ValueMember = "id";

        }
        public void LimpiarForm()
        {

            txtTema.Clear();
            txtRegistro.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();

            
        }

    }
}
