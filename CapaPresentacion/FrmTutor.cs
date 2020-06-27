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
    public partial class FrmTutor : Form
    {
        private LicenciadoDAO dao;
        private List<LicenciadoDTO> list = new List<LicenciadoDTO>();
        public EstudianteDTO estudiante;

        public FrmTutor()
        {
            InitializeComponent();
            if (dao == null) dao = new LicenciadoDAO();
        }

        public void setEstudiante(EstudianteDTO estudiante) {
            this.estudiante = estudiante;
        }

        public void loadDatagrid() {
            dgvTutor.Rows.Clear();
            list = dao.cargarTutores();
            foreach (LicenciadoDTO item in list) {
                dgvTutor.Rows.Add(
                    item.id,
                    item.nombre,
                    item.apellido,
                    item.email,
                    item.telefono,
                    item.celular,
                    item.tipoLicenciado.tipo
                );
            }
        }

        private void btnCancelarTutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            FrmNewLicenciado fnl = new FrmNewLicenciado();
            fnl.ShowDialog();
        }

        private void btnCargarTutor_Click(object sender, EventArgs e)
        {
            int count = dgvTutor.SelectedRows.Count;            
            if (count == 0) {
                MessageBox.Show("Tienes que seleccionar un tutor");
                return;
            }
            if (count > 1) {
                MessageBox.Show("Solo puedes seleccionar un tutor");
                return;
            }
            if (estudiante == null) {
                MessageBox.Show("Los datos del estudiante esta vacio");
                return;
            }
            int index = dgvTutor.CurrentRow.Index;
            estudiante.perfilTesis.licenciado = list.ElementAt(index);
            this.Close();
        }
    }
}
