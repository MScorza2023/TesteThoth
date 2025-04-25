using System;
using System.Windows.Forms;

namespace TesteThoth
{
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;

        public mdiMain()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmUsuarios
            {
                MdiParent = this,
                Text = "Usuários"
            };
            form.Show();
        }
    }
}
