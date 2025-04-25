using ThothEntity;
using ThothBusiness;
using System.Windows.Forms;

namespace TesteThoth
{
    public partial class frmLogin : Form
    {
        public static UsuarioLogado usuarioLogado = new UsuarioLogado();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdEntrar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Por favor, digite o login para acessar o sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por favor, digite a senha para acessar o sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            usuarioLogado.Id = LoginExiste();
            if (usuarioLogado.Id > 0 && SenhaCorreta(usuarioLogado.Id))
            {
                MessageBox.Show("Bem vindo, " + usuarioLogado.Nome + "!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();

                Form form = new mdiMain();
                form.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtLogin.Focus();
            }
        }

        private bool SenhaCorreta(int idUsuario)
        {
            UsuarioBus usuarioBus = new UsuarioBus();
            bool ok = usuarioBus.ValidarSenha(idUsuario, txtSenha.Text.Trim(), out string nomeUsuario);
            usuarioLogado.Nome = nomeUsuario;
            return ok;
        }

        private int LoginExiste()
        {
            UsuarioBus usuarioBus = new UsuarioBus();
            return usuarioBus.ValidarLogin(txtLogin.Text.Trim());
        }

        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, System.EventArgs e)
        {
            txtLogin.Text = "Masco";
            txtSenha.Text = "thoth";
            cmdEntrar.Focus();
        }
    }
}
