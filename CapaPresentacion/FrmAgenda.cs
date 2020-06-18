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
    }
}
