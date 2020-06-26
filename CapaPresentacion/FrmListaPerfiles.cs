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
    public partial class FrmListaPerfiles : Form
    {
        public FrmListaPerfiles()
        {
            InitializeComponent();
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
    }
}
