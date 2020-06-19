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
        NegocioAgenda obj = new NegocioAgenda();
        private int id;
        private int id_perfil;
        private int id_examen;
        private string fecha;
        private string hora;
        private string aula;
        public FrmAgenda_agregar()
        {
            InitializeComponent();
            Inicializador();
            
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

           
            if (obj.Agenda_insert(id, id_perfil, id_examen, fecha, hora, aula))
            {
                MessageBox.Show("Se añadio correctamente");
            }
            else
                MessageBox.Show("No se registro correctamente");
        }

        public void Inicializador()
        {
            cmbPerfilesAprobados.Items.Clear();
            LimpiarForm();
            
            cmbPerfilesAprobados.DataSource = obj.cargarPerfilAprobadoNoAgendado();
            cmbPerfilesAprobados.DisplayMember = "tema";
            cmbPerfilesAprobados.ValueMember = "id";

        }

        public void LimpiarForm()
        {

            txtRegistro.Clear();
            txtNombreAlumno.Clear();
            txtCarrera.Clear();
            txtTema.Clear();
            txtTutor.Clear();
            txtidexamen.Clear();
        }


        public void perfilseleccionado(int id)
        {
           

            DataTable perfil = new DataTable();
            perfil = obj.cargarPerfilSeleccionado(id);
            DataRow dr = null;

                for (int i = 0; i < perfil.Rows.Count; i++)
                {
                    dr = perfil.Rows[i];
                    txtRegistro.Text = (dr[1].ToString());
                    txtNombreAlumno.Text = dr[2].ToString() + " " + dr[3].ToString();
                    txtCarrera.Text = dr[4].ToString();
                    txtTema.Text = dr[5].ToString();
                    txtTutor.Text = dr[6].ToString() + " " + dr[7].ToString();
                    txtidexamen.Text = dr[8].ToString();

                }
            
            
        }

        private void cmbPerfilesAprobados_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarForm();

                if (cmbPerfilesAprobados.SelectedItem.ToString() != "")
                {
                    string a = cmbPerfilesAprobados.SelectedValue.ToString();
                    int id = Convert.ToInt32(a);

                    perfilseleccionado(id);

                }
            }
            catch(Exception es)
            {
                ///MessageBox.Show(es.Message);
            }


            
        }
    }
}
