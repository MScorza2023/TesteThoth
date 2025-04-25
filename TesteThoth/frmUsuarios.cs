using System;
using ThothEntity;
using ThothBusiness;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TesteThoth
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarTela();
            ConfigurarGrid();
            PopularGrid();

            cmdNovo.Focus();
        }

        private void PopularGrid()
        {
            UsuarioBus usuarioBus = new UsuarioBus();
            List<Usuario> usuarios = usuarioBus.ListarUsuarios();

            gridUsuarios.RowCount = 1;
            for (int i = 0; i < usuarios.Count; i++)
            {
                gridUsuarios.Rows.Add(usuarios[i].IdUsuario, usuarios[i].NomeUsuario, usuarios[i].Login, usuarios[i].Senha);
            }
        }

        private void ConfigurarGrid()
        {
            gridUsuarios.ColumnCount = 4;

            gridUsuarios.Columns[0].HeaderText = "ID";
            gridUsuarios.Columns[1].HeaderText = "Nome";
            gridUsuarios.Columns[2].HeaderText = "Login";
            gridUsuarios.Columns[3].HeaderText = "Senha";
            gridUsuarios.Columns[0].Width = 50;
            gridUsuarios.Columns[1].Width = 200;
            gridUsuarios.Columns[2].Width = 100;
            gridUsuarios.Columns[3].Width = 0;
            gridUsuarios.Columns[0].ReadOnly = true;
            gridUsuarios.Columns[1].ReadOnly = true;
            gridUsuarios.Columns[2].ReadOnly = true;
            gridUsuarios.Columns[3].ReadOnly = true;
            gridUsuarios.Columns[3].Visible = false;
        }

        private void ConfigurarTela()
        {
            cmdOk.Enabled = false;
            cmdOk.Tag = string.Empty;
            cmdCancelar.Enabled = false;

            txtSenha.PasswordChar = '\0';
            cmdVerSenha.Tag = "ver";
            cmdVerSenha.BackgroundImage = Image.FromFile("E:\\Teste Prático Thoth\\TesteThoth\\Imagens\\Ver.ico");
            cmdVerSenha.BackgroundImageLayout = ImageLayout.Center;

            txtNome.Text = string.Empty;
            txtNome.Enabled = false;
            txtLogin.Text = string.Empty;
            txtLogin.Enabled = false;
            txtSenha.Text = string.Empty;
            txtSenha.Enabled = false;

            cmdVerSenha.Enabled = false;
        }

        private void cmdVerSenha_Click(object sender, EventArgs e)
        {
            if (cmdVerSenha.Tag.ToString() == "ver")
            {
                txtSenha.UseSystemPasswordChar = false;

                cmdVerSenha.Tag = "esconder";
                cmdVerSenha.BackgroundImage = Image.FromFile("E:\\Teste Prático Thoth\\TesteThoth\\Imagens\\Esconder.ico");
                cmdVerSenha.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;

                cmdVerSenha.Tag = "ver";
                cmdVerSenha.BackgroundImage = Image.FromFile("E:\\Teste Prático Thoth\\TesteThoth\\Imagens\\Ver.ico");
                cmdVerSenha.BackgroundImageLayout = ImageLayout.Center;
            }
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtNome.Enabled = true;

            txtLogin.Text = string.Empty;
            txtLogin.Enabled = true;

            txtSenha.Text = string.Empty;
            txtSenha.Enabled = true;

            cmdVerSenha.Enabled = true;

            cmdOk.Tag = "I";
            cmdOk.Enabled = true;
            cmdCancelar.Enabled = true;
            txtNome.Focus();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Por favor, digite o nome do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Por favor, digite o login do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por favor, digite a senha do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            UsuarioBus usuarioBus = new UsuarioBus();
            if (usuarioBus.NomeExiste(txtNome.Text.Trim(), cmdOk.Tag.ToString(), Convert.ToInt32(txtIdUsuario.Text)))
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (usuarioBus.LoginExiste(txtLogin.Text.Trim(), cmdOk.Tag.ToString(), Convert.ToInt32(txtIdUsuario.Text)))
            {
                MessageBox.Show("Já existe um usuário cadastrado com o mesmo login!" + Environment.NewLine + "Por favor, escolha outro login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }

            Usuario usuario = new Usuario
            {
                IdUsuario = cmdOk.Tag.ToString() == "I" ? 0 : Convert.ToInt32(txtIdUsuario.Text),
                NomeUsuario = txtNome.Text.Trim(),
                Login = txtLogin.Text.Trim(),
                Senha = txtSenha.Text.Trim()
            };

            if (cmdOk.Tag.ToString() == "I")
            {
                if (usuarioBus.InserirUsuario(usuario) > 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (usuarioBus.AlterarUsuario(usuario))
                {
                    MessageBox.Show("Dados do usuário alterado(s) com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o(s) dado(s) do usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
            PopularGrid();
            ConfigurarTela();
            cmdOk.Tag = string.Empty;
            cmdNovo.Focus();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            ConfigurarTela();
            cmdNovo.Focus();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            if (gridUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gridUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um usuário para alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmdVerSenha.Enabled = true;

            cmdOk.Tag = "A";
            txtIdUsuario.Text = gridUsuarios.SelectedRows[0].Cells[0].Value.ToString();

            txtNome.Text = gridUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            txtNome.Enabled = true;
            txtLogin.Text = gridUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            txtLogin.Enabled = true;
            txtSenha.Text = gridUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            txtSenha.Enabled = true;

            cmdVerSenha.Enabled = true;

            cmdOk.Tag = "A";
            cmdOk.Enabled = true;
            cmdCancelar.Enabled = true;
            txtNome.Focus();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (gridUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gridUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um usuário para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir o usuário " + gridUsuarios.SelectedRows[0].Cells[1].Value.ToString() + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioBus usuarioBus = new UsuarioBus();
                if (usuarioBus.ExcluirUsuario(int.Parse(gridUsuarios.SelectedRows[0].Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Usuário excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            PopularGrid();
            ConfigurarTela();
            cmdNovo.Focus();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
