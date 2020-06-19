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
    public partial class FrmAgenda_agregar : Form
    {
        private int id;
        private int id_perfil;
        private int id_examen;
        private string fecha;
        private string hora;
        private string aula;
        public FrmAgenda_agregar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks >= 2)
            {
                if (FormWindowState.Normal == WindowState)
                {
                    Rectangle workingArea = new Rectangle();
                    workingArea = Screen.GetWorkingArea(pnlBarraTitulo);
                    MaximumSize = workingArea.Size;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MaximumSize = new Size(0, 0);
                    WindowState = FormWindowState.Normal;
                }
                pnlBarraTitulo.Select();
                return;
            }
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(cmbPerfilesAprobados.SelectedValue.ToString());
            id_perfil = Convert.ToInt32(id);
            id_examen = Convert.ToInt32(txtidexamen.Text.ToString());
            fecha = dtFechaAgenda.Value.ToString("yyyy-MM-dd");
            hora = dtHora.Value.ToString("HH:mm");
            aula = txtAula.Text.ToString();

            NegocioAgenda obj = new NegocioAgenda();
            if (obj.Agenda_insert(id, id_perfil, id_examen, fecha, hora, aula))
            {
                MessageBox.Show("Se añadio correctamente");
            }
            else
                MessageBox.Show("No se registro correctamente");
        }
    }
}
