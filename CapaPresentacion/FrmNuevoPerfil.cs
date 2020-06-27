using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.dto;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmNuevoPerfil : Form
    {
        private EstudianteDAO dao;
        private EstudianteDTO record = new EstudianteDTO();
        private List<CarreraDTO> carreras = new List<CarreraDTO>();
        public FrmNuevoPerfil()
        {
            InitializeComponent();
            if (dao == null) dao = new EstudianteDAO();
            record.perfilTesis = new PerfilTesisDTO();
            cargarComboCarreras();
        }

        public void cargarComboCarreras() {
            /*CARGAR DATOS DE LA CAPA NEGOCIOS PARA LOS COMBOS*/
            carreras = dao.cargarComboCarrera();
            this.cbxCarrera.ValueMember = "id";
            this.cbxCarrera.DataSource = carreras;
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
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

        private void btnElegirTutor_Click(object sender, EventArgs e)
        {
            FrmTutor ftu = new FrmTutor();            
            ftu.FormClosed += new FormClosedEventHandler(RefresOnCLose);            
            ftu.setEstudiante(record);
            ftu.loadDatagrid();
            ftu.ShowDialog();
        }

        private void RefresOnCLose(object sender, FormClosedEventArgs e) {
            if (record.perfilTesis.licenciado != null) {
                txtTutor.Text = record.perfilTesis.licenciado.nombre + " " + record.perfilTesis.licenciado.apellido;
            }
        }

        private void btnCancelarNuevop_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevoP_Click(object sender, EventArgs e) {
            int carreraIndex = this.cbxCarrera.SelectedIndex;
            CarreraDTO carrera = this.cbxCarrera.Items[carreraIndex] as CarreraDTO;
            if (record.perfilTesis.licenciado == null) {
                MessageBox.Show("El campo del tutor es requerido");
                return;
            }
            record.id_carrera = carrera.id;
            record.registro = this.txtRegistroAlum.Text.ToString() ?? null;
            record.nombre = this.txtNombreAlum.Text.ToString() ?? null;
            record.apellido = this.txtApellidoAlum.Text.ToString() ?? null;
            record.email = this.txtEmailAlum.Text.ToString() ?? null;
            record.telefono = this.txtTelefonoAlum.Text.ToString() ?? null;
            record.celular = this.txtCelularAlum.Text.ToString() ?? null;
            record.direccion = this.txtDirecionAlum.Text.ToString() ?? null;
            record.perfilTesis.tema = this.txtTemaTesis.Text.ToString() ?? null;
            record.perfilTesis.fecha_recepcion_titulacion = this.dtPresentacion.Value.ToString("yyyy-MM-dd");
            record.perfilTesis.fecha_aprobacion_jefe_carrera = this.dtAprovacion.Value.ToString("yyyy-MM-dd");

            if (record.id == 0) {
                bool crear = dao.crearEstudiante(record);
                if (crear == true) {
                    MessageBox.Show("Estudiante creado!!!");
                    this.Close();
                    return;
                } else {
                    MessageBox.Show("Estudiante no pudo ser creado!!!");
                }                
            }
        }
    }
}
