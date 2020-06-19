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
        public FrmAgenda(string criterio)
        {
            InitializeComponent();
            cargarTodo(criterio);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void cargarTodo(string criterio)
        {
            if(criterio == null)
            {
                dtgAgenda.DataSource = obj.Agendas();
            }
            else
            {
                dtgAgenda.DataSource = obj.AgendasCriterio(criterio);

            }
           

        }

        private void dtgAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgenda_agregar frmhijo = new FrmAgenda_agregar();
            frmhijo.Show();
        }
    }
}
