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
    public partial class FrmPerfil : Form
    {
        NegocioPerfil obj = new NegocioPerfil();   
        public FrmPerfil(string criterio)
        {
            InitializeComponent();
            cargarTodo(criterio);
        }

        public void cargarTodo(string criterio)
        {
            if (criterio == null)
            {
                dgvTabla.DataSource = obj.Perfiles();
            }
            else
            {
                dgvTabla.DataSource = obj.PerfilesCriterio(criterio);
               

            }


        }

    }
}
