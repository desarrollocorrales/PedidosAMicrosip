using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PadidosAMicrosip.GUIs
{
    public partial class Splash_Inicio : Form
    {
        public Splash_Inicio()
        {
            InitializeComponent();
        }

        private void Splash_Inicio_Shown(object sender, EventArgs e)
        {
            AbrirFrmPrincipal();
        }

        private void AbrirFrmPrincipal()
        {
            Frm_Principal frmPrincipal = new Frm_Principal();

            this.Hide();
            frmPrincipal.ShowDialog();
            this.Close();
        }
    }
}
