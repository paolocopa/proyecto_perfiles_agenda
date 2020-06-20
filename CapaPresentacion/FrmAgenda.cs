using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{//comentario

    public partial class FrmAgenda : Form
    {
        NegocioAgenda obj = new NegocioAgenda();
        public FrmAgenda()
        {
            InitializeComponent();
            cargarTodo();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void cargarTodo()
        {
            
            dtgAgenda.DataSource = obj.Agendas();

        }

        private void dtgAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgenda_agregar frmhijo = new FrmAgenda_agregar();
            frmhijo.Show();
        }

        private void dtgEditarAgenda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                FrmModificarAgenda FrmAgenModificar = new FrmModificarAgenda();
                int fila = e.RowIndex;
                FrmAgenModificar.txtEditarNroAgenda.Text = dtgAgenda.Rows[fila].Cells[0].Value.ToString();
                FrmAgenModificar.dtFechaAgenda.Text=dtgAgenda.Rows[fila].Cells[1].Value.ToString();
                FrmAgenModificar.dtEditarHora.Text = dtgAgenda.Rows[fila].Cells[2].Value.ToString();
                FrmAgenModificar.textEditarAula.Text = dtgAgenda.Rows[fila].Cells[3].Value.ToString();
                FrmAgenModificar.txtEditarTemaTesis.Text = dtgAgenda.Rows[fila].Cells[4].Value.ToString();
                FrmAgenModificar.txtEditarRegistro.Text = dtgAgenda.Rows[fila].Cells[6].Value.ToString();
                FrmAgenModificar.txtEditarNombreAlumno.Text = dtgAgenda.Rows[fila].Cells[7].Value.ToString();
                FrmAgenModificar.textModificarApellido.Text = dtgAgenda.Rows[fila].Cells[8].Value.ToString();
                FrmAgenModificar.txtEditarCarrera.Text = dtgAgenda.Rows[fila].Cells[9].Value.ToString();
                FrmAgenModificar.txtModificarFacultad.Text = dtgAgenda.Rows[fila].Cells[10].Value.ToString();

                FrmAgenModificar.Show();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila correcta");
            }
        }
    }
}
