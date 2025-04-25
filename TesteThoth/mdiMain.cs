using System;
using System.Windows.Forms;

namespace TesteThoth
{
    public partial class mdiMain : Form
    {
        public mdiMain()
        {
            InitializeComponent();

            FormClosing += mdiMain_FormClosing;
        }

        private void mdiMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.UserClosing)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
            }

            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCadastrarUsuarios_Click(object sender, System.EventArgs e)
        {
            Form form = new frmUsuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            Form form = new frmUsuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuCompromissos_Click(object sender, EventArgs e)
        {
            Form form = new frmCompromissos();
            form.MdiParent = this;
            form.Show();
        }

        private void cmdAgendar_Click(object sender, EventArgs e)
        {
            Form form = new frmCompromissos();
            form.MdiParent = this;
            form.Show();
        }
    }
}
