using System;
using ThothEntity;
using ThothBusiness;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TesteThoth
{
    public partial class frmCompromissos : Form
    {
        public frmCompromissos()
        {
            InitializeComponent();
        }

        private void frmCompromissos_Load(object sender, System.EventArgs e)
        {
            ConfigurarTela();
            PopularComboUsuario();

            cmdNovo.Focus();

            CarregarCompromissoUsuario(frmLogin.usuarioLogado.Id, dtpCompromisso.Value.ToString("yyyyMMdd"));
        }

        private void PopularComboUsuario()
        {
            UsuarioBus usuarioBus = new UsuarioBus();
            List<Usuario> usuarios = usuarioBus.ListarUsuarios();

            cmbUsuarios.Items.Clear();
            cmbUsuarios.DisplayMember = "NomeUsuario";
            cmbUsuarios.ValueMember = "IdUsuario";
            cmbUsuarios.DataSource = usuarios;
            cmbUsuarios.SelectedItem = frmLogin.usuarioLogado.Id;
        }

        private void ConfigurarTela()
        {
            ConfigurarGrid();
            PrepararCampos(true);
        }

        private void PrepararCampos(bool isLoading)
        {
            if (isLoading)
            {
                dtpCompromisso.Value = DateTime.Now;
            }

            txtHorarioInicial.Enabled = false;
            txtHorarioInicial.Text = "09:00";
            cmdHrIniSomar.Enabled = false;
            cmdHrIniDiminuir.Enabled = false;
            txtHorarioFinal.Enabled = false;
            txtHorarioFinal.Text = "18:00";
            cmdHrFinSomar.Enabled = false;
            cmdHrFinDiminuir.Enabled = false;
            txtDescricao.Enabled = false;
            txtDescricao.Text = string.Empty;
            txtLocal.Enabled = false;
            txtLocal.Text = string.Empty;
            
            chkDiaTodo.Enabled = false;
            chkDiaTodo.Checked = false;

            cmdIncluir.Enabled = false;
            cmdCancelar.Enabled = false;

            cmdNovo.Enabled = true;
            cmdAlterar.Enabled = true;
            cmdExcluir.Enabled = true;
        }

        private void ConfigurarGrid()
        {
            gridCompromissos.ColumnCount = 6;

            gridCompromissos.Columns[0].HeaderText = "Horario Inicial";
            gridCompromissos.Columns[1].HeaderText = "Horario Final";
            gridCompromissos.Columns[2].HeaderText = "Dia Inteiro";
            gridCompromissos.Columns[3].HeaderText = "Descrição";
            gridCompromissos.Columns[4].HeaderText = "Local";
            gridCompromissos.Columns[5].HeaderText = "IdCompromisso";

            gridCompromissos.Columns[0].Width = 100;
            gridCompromissos.Columns[1].Width = 100;
            gridCompromissos.Columns[2].Width = 50;
            gridCompromissos.Columns[3].Width = 200;
            gridCompromissos.Columns[4].Width = 200;
            gridCompromissos.Columns[5].Width = 0;

            gridCompromissos.Columns[0].ReadOnly = true;
            gridCompromissos.Columns[1].ReadOnly = true;
            gridCompromissos.Columns[2].ReadOnly = true;
            gridCompromissos.Columns[3].ReadOnly = true;
            gridCompromissos.Columns[4].ReadOnly = true;
            gridCompromissos.Columns[5].Visible = false;
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCompromissoUsuario((int)cmbUsuarios.SelectedValue, dtpCompromisso.Value.ToString("yyyyMMdd"));
        }

        private void CarregarCompromissoUsuario(int idUsuario, string dataAgenda)
        {
            CompromissoBus comprBus = new CompromissoBus();
            List<Compromisso> compromissos = comprBus.ListarCompromissos(idUsuario, dataAgenda);

            gridCompromissos.Rows.Clear();
            for (int i = 0; i < compromissos.Count; i++)
            {
                gridCompromissos.Rows.Add();
                gridCompromissos.Rows[i].Cells[0].Value = compromissos[i].HorarioInicial;
                gridCompromissos.Rows[i].Cells[1].Value = compromissos[i].HorarioFinal;
                gridCompromissos.Rows[i].Cells[2].Value = compromissos[i].DiaTodo ? "Não" : "Sim";
                gridCompromissos.Rows[i].Cells[3].Value = compromissos[i].Descricao;
                gridCompromissos.Rows[i].Cells[4].Value = compromissos[i].Local;
                gridCompromissos.Rows[i].Cells[5].Value = compromissos[i].IdCompromisso;
            }
        }

        private void dtpCompromisso_ValueChanged(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem != null)
            {
                CarregarCompromissoUsuario((int)cmbUsuarios.SelectedValue, dtpCompromisso.Value.ToString("yyyyMMdd"));
            }
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            cmbUsuarios.Enabled = false;
            dtpCompromisso.Enabled = false;

            txtHorarioInicial.Enabled = true;
            cmdHrIniSomar.Enabled = true;
            cmdHrIniDiminuir.Enabled = true;
            txtHorarioFinal.Enabled = true;
            cmdHrFinSomar.Enabled = true;
            cmdHrFinDiminuir.Enabled = true;

            chkDiaTodo.Enabled = true;
            chkDiaTodo.Checked = false;

            txtDescricao.Enabled = true;
            txtLocal.Enabled = true;

            cmdIncluir.Enabled = true;
            cmdCancelar.Enabled = true;

            cmdNovo.Enabled = false;
            cmdAlterar.Enabled = false;
            cmdExcluir.Enabled = false;

            SetarHorarios();
            txtHorarioInicial.Focus();

            cmdIncluir.Tag = "I";
            txtIdCompromisso.Text = "0";
        }

        private void SetarHorarios()
        {
            txtHorarioInicial.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");
            int horaFinal = DateTime.Now.Hour;
            int minutoFinal = DateTime.Now.Minute + 30;
            if (minutoFinal > 59)
            {
                minutoFinal = 30;
                horaFinal++;
            }
            //Aqui precisa saber se a agenda é de 24 horas ou não. Se sim, tem que colocar a data final no banco e controlar
            //para facilitar esse teste, só vou permitir datas dentro do "horário comercial extendido" (08:00 as 21:00)
            if (horaFinal > 21)
            {
                horaFinal = 21;
                minutoFinal = 0;
            }
            txtHorarioFinal.Text = horaFinal.ToString("00") + ":" + minutoFinal.ToString("00");
        }

        private bool ValidarHorarios(int horaInicial, int horaFinal, int minutoInicial, int minutoFinal)
        {
            if (horaInicial > horaFinal)
            {
                MessageBox.Show("Horário inicial não pode ser maior que o horário final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHorarioInicial.Focus();
                return false;
            }
            if (horaInicial == horaFinal)
            {
                if (minutoInicial > minutoFinal)
                {
                    MessageBox.Show("Horário inicial não pode ser maior que o horário final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHorarioInicial.Focus();
                    return false;
                }

                if (minutoInicial == minutoFinal)
                {
                    MessageBox.Show("Horário inicial não pode ser igual ao horário final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHorarioInicial.Focus();
                    return false;
                }
            }

            return true;
        }

        private void cmdHrIniSomar_Click(object sender, EventArgs e)
        {
            int minuto = Convert.ToInt32(txtHorarioInicial.Text.Substring(3, 2));
            int hora = Convert.ToInt32(txtHorarioInicial.Text.Substring(0, 2));
            
            minuto++;
            if (minuto > 59)
            {
                minuto = 0;
                hora++;
                if (hora > 21)
                {
                    hora = 8;
                    minuto = 0;
                }
            }

            txtHorarioInicial.Text = hora.ToString("00") + ":" + minuto.ToString("00");
        }

        private void cmdHrIniDiminuir_Click(object sender, EventArgs e)
        {
            int minuto = Convert.ToInt32(txtHorarioInicial.Text.Substring(3, 2));
            int hora = Convert.ToInt32(txtHorarioInicial.Text.Substring(0, 2));

            minuto--;
            if (minuto < 0)
            {
                minuto = 59;
                hora--;
                if (hora < 8)
                {
                    hora = 21;
                    minuto = 0;
                }
            }

            txtHorarioInicial.Text = hora.ToString("00") + ":" + minuto.ToString("00");
        }

        private void cmdHrFinSomar_Click(object sender, EventArgs e)
        {
            int minuto = Convert.ToInt32(txtHorarioFinal.Text.Substring(3, 2));
            int hora = Convert.ToInt32(txtHorarioFinal.Text.Substring(0, 2));

            minuto++;
            if (minuto > 59)
            {
                minuto = 0;
                hora++;
                if (hora > 21)
                {
                    hora = 8;
                    minuto = 0;
                }
            }

            txtHorarioFinal.Text = hora.ToString("00") + ":" + minuto.ToString("00");
        }

        private void cmdHrFinDiminuir_Click(object sender, EventArgs e)
        {
            int minuto = Convert.ToInt32(txtHorarioFinal.Text.Substring(3, 2));
            int hora = Convert.ToInt32(txtHorarioFinal.Text.Substring(0, 2));

            minuto--;
            if (minuto < 0)
            {
                minuto = 59;
                hora--;
                if (hora < 8)
                {
                    hora = 21;
                    minuto = 0;
                }
            }

            txtHorarioFinal.Text = hora.ToString("00") + ":" + minuto.ToString("00");
        }

        private void chkDiaTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiaTodo.Checked)
            {
                CompromissoBus compromissoBus = new CompromissoBus();
                if (compromissoBus.ExisteOutroCompromisso((int)cmbUsuarios.SelectedValue, dtpCompromisso.Value.ToString("yyyyMMdd"), Convert.ToInt32(txtIdCompromisso.Text)))
                {
                    MessageBox.Show("Já existe um compromisso para o usuário nesse dia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkDiaTodo.Checked = false;
                    return;
                }

                txtHorarioInicial.Text = "08:00";
                txtHorarioInicial.Enabled = false;
                txtHorarioFinal.Text = "20:59";
                txtHorarioFinal.Enabled = false;

                cmdHrIniSomar.Enabled = false;
                cmdHrIniDiminuir.Enabled = false;
                cmdHrFinSomar.Enabled = false;
                cmdHrFinDiminuir.Enabled = false;
            }
            else
            {
                SetarHorarios();
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            int horaInicial = Convert.ToInt32(txtHorarioInicial.Text.Substring(0, 2));
            int horaFinal = Convert.ToInt32(txtHorarioFinal.Text.Substring(0, 2));
            int minutoInicial = Convert.ToInt32(txtHorarioInicial.Text.Substring(3, 2));
            int minutoFinal = Convert.ToInt32(txtHorarioFinal.Text.Substring(3, 2));
            bool ret = ValidarHorarios(horaInicial, horaFinal, minutoInicial, minutoFinal);
            if (!ret)
            {
                return;
            }

            CompromissoBus compromissoBus = new CompromissoBus();
            Compromisso compromisso = new Compromisso
            {
                Usuario = new Usuario
                {
                    IdUsuario = (int)cmbUsuarios.SelectedValue
                },
                IdCompromisso = cmdIncluir.Tag.ToString() == "I" ? 0 : Convert.ToInt32(txtIdCompromisso.Text),
                Data = dtpCompromisso.Value,
                HorarioInicial = txtHorarioInicial.Text,
                HorarioFinal = txtHorarioFinal.Text,
                DiaTodo = chkDiaTodo.Checked,
                Descricao = txtDescricao.Text,
                Local = txtLocal.Text
            };

            if (cmdIncluir.Tag.ToString() == "I")
            {
                int idCmprmso = compromissoBus.InserirCompromisso(compromisso);
                if (idCmprmso > 0)
                {
                    MessageBox.Show("Compromisso inserido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao inserir compromisso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (compromissoBus.AlterarCompromisso(compromisso))
                {
                    MessageBox.Show("Compromisso alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar compromisso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarCompromissoUsuario((int)cmbUsuarios.SelectedValue, dtpCompromisso.Value.ToString("yyyyMMdd"));

            PrepararCampos(false);
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            if (gridCompromissos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um compromisso para alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gridCompromissos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um compromisso para alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (gridCompromissos.SelectedRows[0].Cells[0].Value == null)
            {
                return;
            }

            txtHorarioInicial.Text = gridCompromissos.SelectedRows[0].Cells[0].Value.ToString();
            txtHorarioInicial.Enabled = true;
            cmdHrIniSomar.Enabled = true;
            cmdHrIniDiminuir.Enabled = true;
            txtHorarioFinal.Text = gridCompromissos.SelectedRows[0].Cells[1].Value.ToString();
            txtHorarioFinal.Enabled = true;
            cmdHrFinSomar.Enabled = true;
            cmdHrFinDiminuir.Enabled = true;
            chkDiaTodo.Checked = (string)gridCompromissos.SelectedRows[0].Cells[2].Value != "Não";
            chkDiaTodo.Enabled = true;
            txtDescricao.Text = gridCompromissos.SelectedRows[0].Cells[3].Value.ToString();
            txtDescricao.Enabled = true;
            txtLocal.Text = gridCompromissos.SelectedRows[0].Cells[4].Value.ToString();
            txtLocal.Enabled = true;
            txtIdCompromisso.Text = gridCompromissos.SelectedRows[0].Cells[5].Value.ToString();
            
            cmdIncluir.Enabled = true;
            cmdCancelar.Enabled = true;

            cmdNovo.Enabled = false;
            cmdAlterar.Enabled = false;
            cmdExcluir.Enabled = false;

            cmdIncluir.Tag = "A";
            txtHorarioInicial.Focus();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (gridCompromissos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um compromisso para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gridCompromissos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um compromisso para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (gridCompromissos.SelectedRows[0].Cells[0].Value == null)
            {
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir o compromisso selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CompromissoBus compromissoBus = new CompromissoBus();
                int idUsuario = (int)cmbUsuarios.SelectedValue;
                int idCompromisso = Convert.ToInt32(gridCompromissos.SelectedRows[0].Cells[5].Value);
                if (compromissoBus.ExcluirCompromisso(idUsuario, idCompromisso))
                {
                    MessageBox.Show("Compromisso excluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir compromisso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                CarregarCompromissoUsuario((int)cmbUsuarios.SelectedValue, dtpCompromisso.Value.ToString("yyyyMMdd"));
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            PrepararCampos(false);
        }
    }
}
