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
    public partial class FrmTutor : Form
    {
        public FrmTutor()
        {
            InitializeComponent();
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
    }
}
