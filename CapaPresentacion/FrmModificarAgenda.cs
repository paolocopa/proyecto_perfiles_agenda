using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class FrmModificarAgenda : Form
    {
        private int id;
      //  private int id_perfil;
       // private int id_examen;
        private string fecha;
        private string hora;
        private string aula;
        public FrmModificarAgenda()
        {
            InitializeComponent();
        }

        private void btnGuardarCambiosAgenda_Click(object sender, EventArgs e)
        {
            //id = Convert.ToInt32(cmbPerfilesAprobados.SelectedValue.ToString());
            // id  = Convert.ToInt32(txtEditarNroAgenda.Text.ToString());
            // id_perfil = Convert.ToInt32(id);
            // id_examen = Convert.ToInt32(txtidexamen.Text.ToString());
            id = Convert.ToInt32(txtEditarNroAgenda.Text.ToString());
            fecha = dtFechaAgenda.Value.ToString("yyyy-MM-dd");
            hora = dtEditarHora.Value.ToString("HH:mm");
            aula = textEditarAula.Text.ToString();

            NegocioAgenda obj = new NegocioAgenda();
            if (obj.Agenda_Update( fecha, hora, aula,id))
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
                MessageBox.Show("No se modifico correctamente");

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
