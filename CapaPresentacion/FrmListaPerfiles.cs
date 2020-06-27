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
    public partial class FrmListaPerfiles : Form
    {
        private string currentUid;
        private EstudianteDAO dao;
        private List<EstudianteDTO> list = new List<EstudianteDTO>();
        public FrmListaPerfiles()
        {
            InitializeComponent();
            if (dao == null) dao = new EstudianteDAO();
        }

        public void loadDataGrid(string uid, string busqueda) {
            currentUid = uid;
            dgvPerfiles.Rows.Clear();
            list = dao.cargarEstudiantes(uid, busqueda);
            foreach (EstudianteDTO item in list) {
                dgvPerfiles.Rows.Add(
                    item.registro,
                    item.nombre + " " + item.apellido,
                    item.email,
                    item.carrera.nombre,
                    item.perfilTesis.tema,
                    item.perfilTesis.licenciado.nombre + " " + item.perfilTesis.licenciado.apellido,
                    item.perfilTesis.fecha_recepcion_titulacion,
                    item.perfilTesis.estado
                );
            }
        }

        private void btnExitLP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdiar_Click(object sender, EventArgs e)
        {
            FrmRevisiones fre = new FrmRevisiones();
            fre.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            string busqueda = txtFiltarPerfil.Text.ToString().Trim();
            if (busqueda.Equals("")) busqueda = null;
            loadDataGrid(currentUid, busqueda);
        }
    }
}
