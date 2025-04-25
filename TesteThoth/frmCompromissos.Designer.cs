namespace TesteThoth
{
    partial class frmCompromissos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompromissos));
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpBoxCompromissos = new System.Windows.Forms.GroupBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdIncluir = new System.Windows.Forms.Button();
            this.chkDiaTodo = new System.Windows.Forms.CheckBox();
            this.cmdHrFinDiminuir = new System.Windows.Forms.Button();
            this.cmdHrFinSomar = new System.Windows.Forms.Button();
            this.txtHorarioFinal = new System.Windows.Forms.MaskedTextBox();
            this.cmdHrIniDiminuir = new System.Windows.Forms.Button();
            this.cmdHrIniSomar = new System.Windows.Forms.Button();
            this.lblHorarioFinal = new System.Windows.Forms.Label();
            this.txtHorarioInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblHorarioInicial = new System.Windows.Forms.Label();
            this.lblAgendamento = new System.Windows.Forms.Label();
            this.lblCompromissos = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.gridCompromissos = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpCompromisso = new System.Windows.Forms.DateTimePicker();
            this.txtIdCompromisso = new System.Windows.Forms.TextBox();
            this.grpBoxCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(154, 12);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(231, 21);
            this.cmbUsuarios.TabIndex = 0;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Blue;
            this.lblUsuario.Location = new System.Drawing.Point(12, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(136, 14);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Selecione o usuário";
            // 
            // grpBoxCompromissos
            // 
            this.grpBoxCompromissos.Controls.Add(this.txtLocal);
            this.grpBoxCompromissos.Controls.Add(this.txtDescricao);
            this.grpBoxCompromissos.Controls.Add(this.lblLocal);
            this.grpBoxCompromissos.Controls.Add(this.lblDescricao);
            this.grpBoxCompromissos.Controls.Add(this.cmdCancelar);
            this.grpBoxCompromissos.Controls.Add(this.cmdIncluir);
            this.grpBoxCompromissos.Controls.Add(this.chkDiaTodo);
            this.grpBoxCompromissos.Controls.Add(this.cmdHrFinDiminuir);
            this.grpBoxCompromissos.Controls.Add(this.cmdHrFinSomar);
            this.grpBoxCompromissos.Controls.Add(this.txtHorarioFinal);
            this.grpBoxCompromissos.Controls.Add(this.cmdHrIniDiminuir);
            this.grpBoxCompromissos.Controls.Add(this.cmdHrIniSomar);
            this.grpBoxCompromissos.Controls.Add(this.lblHorarioFinal);
            this.grpBoxCompromissos.Controls.Add(this.txtHorarioInicial);
            this.grpBoxCompromissos.Controls.Add(this.lblHorarioInicial);
            this.grpBoxCompromissos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBoxCompromissos.Location = new System.Drawing.Point(12, 102);
            this.grpBoxCompromissos.Name = "grpBoxCompromissos";
            this.grpBoxCompromissos.Size = new System.Drawing.Size(594, 118);
            this.grpBoxCompromissos.TabIndex = 2;
            this.grpBoxCompromissos.TabStop = false;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(116, 88);
            this.txtLocal.MaxLength = 200;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(370, 20);
            this.txtLocal.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(116, 62);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(370, 20);
            this.txtDescricao.TabIndex = 15;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.Black;
            this.lblLocal.Location = new System.Drawing.Point(10, 94);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(42, 14);
            this.lblLocal.TabIndex = 14;
            this.lblLocal.Text = "Local";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(10, 62);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(72, 14);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(513, 62);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(71, 23);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Location = new System.Drawing.Point(513, 24);
            this.cmdIncluir.Name = "cmdIncluir";
            this.cmdIncluir.Size = new System.Drawing.Size(71, 23);
            this.cmdIncluir.TabIndex = 11;
            this.cmdIncluir.Text = "&Salvar";
            this.cmdIncluir.UseVisualStyleBackColor = true;
            this.cmdIncluir.Click += new System.EventHandler(this.cmdIncluir_Click);
            // 
            // chkDiaTodo
            // 
            this.chkDiaTodo.AutoSize = true;
            this.chkDiaTodo.Location = new System.Drawing.Point(420, 24);
            this.chkDiaTodo.Name = "chkDiaTodo";
            this.chkDiaTodo.Size = new System.Drawing.Size(66, 17);
            this.chkDiaTodo.TabIndex = 10;
            this.chkDiaTodo.Text = "Dia todo";
            this.chkDiaTodo.UseVisualStyleBackColor = true;
            this.chkDiaTodo.CheckedChanged += new System.EventHandler(this.chkDiaTodo_CheckedChanged);
            // 
            // cmdHrFinDiminuir
            // 
            this.cmdHrFinDiminuir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHrFinDiminuir.Image = ((System.Drawing.Image)(resources.GetObject("cmdHrFinDiminuir.Image")));
            this.cmdHrFinDiminuir.Location = new System.Drawing.Point(380, 31);
            this.cmdHrFinDiminuir.Name = "cmdHrFinDiminuir";
            this.cmdHrFinDiminuir.Size = new System.Drawing.Size(20, 20);
            this.cmdHrFinDiminuir.TabIndex = 9;
            this.cmdHrFinDiminuir.UseVisualStyleBackColor = true;
            this.cmdHrFinDiminuir.Click += new System.EventHandler(this.cmdHrFinDiminuir_Click);
            // 
            // cmdHrFinSomar
            // 
            this.cmdHrFinSomar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHrFinSomar.Image = ((System.Drawing.Image)(resources.GetObject("cmdHrFinSomar.Image")));
            this.cmdHrFinSomar.Location = new System.Drawing.Point(380, 12);
            this.cmdHrFinSomar.Name = "cmdHrFinSomar";
            this.cmdHrFinSomar.Size = new System.Drawing.Size(20, 20);
            this.cmdHrFinSomar.TabIndex = 8;
            this.cmdHrFinSomar.UseVisualStyleBackColor = true;
            this.cmdHrFinSomar.Click += new System.EventHandler(this.cmdHrFinSomar_Click);
            // 
            // txtHorarioFinal
            // 
            this.txtHorarioFinal.Location = new System.Drawing.Point(325, 22);
            this.txtHorarioFinal.Mask = "99:99";
            this.txtHorarioFinal.Name = "txtHorarioFinal";
            this.txtHorarioFinal.Size = new System.Drawing.Size(49, 20);
            this.txtHorarioFinal.TabIndex = 7;
            // 
            // cmdHrIniDiminuir
            // 
            this.cmdHrIniDiminuir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHrIniDiminuir.Image = ((System.Drawing.Image)(resources.GetObject("cmdHrIniDiminuir.Image")));
            this.cmdHrIniDiminuir.Location = new System.Drawing.Point(171, 31);
            this.cmdHrIniDiminuir.Name = "cmdHrIniDiminuir";
            this.cmdHrIniDiminuir.Size = new System.Drawing.Size(20, 20);
            this.cmdHrIniDiminuir.TabIndex = 6;
            this.cmdHrIniDiminuir.UseVisualStyleBackColor = true;
            this.cmdHrIniDiminuir.Click += new System.EventHandler(this.cmdHrIniDiminuir_Click);
            // 
            // cmdHrIniSomar
            // 
            this.cmdHrIniSomar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHrIniSomar.Image = ((System.Drawing.Image)(resources.GetObject("cmdHrIniSomar.Image")));
            this.cmdHrIniSomar.Location = new System.Drawing.Point(171, 12);
            this.cmdHrIniSomar.Name = "cmdHrIniSomar";
            this.cmdHrIniSomar.Size = new System.Drawing.Size(20, 20);
            this.cmdHrIniSomar.TabIndex = 5;
            this.cmdHrIniSomar.UseVisualStyleBackColor = true;
            this.cmdHrIniSomar.Click += new System.EventHandler(this.cmdHrIniSomar_Click);
            // 
            // lblHorarioFinal
            // 
            this.lblHorarioFinal.AutoSize = true;
            this.lblHorarioFinal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioFinal.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioFinal.Location = new System.Drawing.Point(226, 25);
            this.lblHorarioFinal.Name = "lblHorarioFinal";
            this.lblHorarioFinal.Size = new System.Drawing.Size(93, 14);
            this.lblHorarioFinal.TabIndex = 4;
            this.lblHorarioFinal.Text = "Horário Final";
            // 
            // txtHorarioInicial
            // 
            this.txtHorarioInicial.Location = new System.Drawing.Point(116, 22);
            this.txtHorarioInicial.Mask = "99:99";
            this.txtHorarioInicial.Name = "txtHorarioInicial";
            this.txtHorarioInicial.Size = new System.Drawing.Size(49, 20);
            this.txtHorarioInicial.TabIndex = 3;
            // 
            // lblHorarioInicial
            // 
            this.lblHorarioInicial.AutoSize = true;
            this.lblHorarioInicial.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioInicial.ForeColor = System.Drawing.Color.Black;
            this.lblHorarioInicial.Location = new System.Drawing.Point(10, 25);
            this.lblHorarioInicial.Name = "lblHorarioInicial";
            this.lblHorarioInicial.Size = new System.Drawing.Size(102, 14);
            this.lblHorarioInicial.TabIndex = 2;
            this.lblHorarioInicial.Text = "Horário Inicial";
            // 
            // lblAgendamento
            // 
            this.lblAgendamento.AutoSize = true;
            this.lblAgendamento.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamento.ForeColor = System.Drawing.Color.Blue;
            this.lblAgendamento.Location = new System.Drawing.Point(12, 87);
            this.lblAgendamento.Name = "lblAgendamento";
            this.lblAgendamento.Size = new System.Drawing.Size(97, 14);
            this.lblAgendamento.TabIndex = 3;
            this.lblAgendamento.Text = "Agendamento";
            // 
            // lblCompromissos
            // 
            this.lblCompromissos.AutoSize = true;
            this.lblCompromissos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompromissos.ForeColor = System.Drawing.Color.Blue;
            this.lblCompromissos.Location = new System.Drawing.Point(12, 239);
            this.lblCompromissos.Name = "lblCompromissos";
            this.lblCompromissos.Size = new System.Drawing.Size(178, 14);
            this.lblCompromissos.TabIndex = 4;
            this.lblCompromissos.Text = "Compromissos agendados";
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(533, 422);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(63, 25);
            this.cmdSair.TabIndex = 16;
            this.cmdSair.Text = "&Fechar";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(533, 325);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(63, 25);
            this.cmdExcluir.TabIndex = 15;
            this.cmdExcluir.Text = "&Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Location = new System.Drawing.Point(533, 294);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(63, 25);
            this.cmdAlterar.TabIndex = 14;
            this.cmdAlterar.Text = "&Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(533, 263);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(63, 25);
            this.cmdNovo.TabIndex = 13;
            this.cmdNovo.Text = "&Novo";
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // gridCompromissos
            // 
            this.gridCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompromissos.Location = new System.Drawing.Point(12, 263);
            this.gridCompromissos.Name = "gridCompromissos";
            this.gridCompromissos.Size = new System.Drawing.Size(515, 184);
            this.gridCompromissos.TabIndex = 17;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Blue;
            this.lblData.Location = new System.Drawing.Point(12, 45);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(116, 14);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Selecione a data";
            // 
            // dtpCompromisso
            // 
            this.dtpCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompromisso.Location = new System.Drawing.Point(154, 42);
            this.dtpCompromisso.Name = "dtpCompromisso";
            this.dtpCompromisso.Size = new System.Drawing.Size(101, 20);
            this.dtpCompromisso.TabIndex = 19;
            this.dtpCompromisso.ValueChanged += new System.EventHandler(this.dtpCompromisso_ValueChanged);
            // 
            // txtIdCompromisso
            // 
            this.txtIdCompromisso.Enabled = false;
            this.txtIdCompromisso.Location = new System.Drawing.Point(534, 233);
            this.txtIdCompromisso.Name = "txtIdCompromisso";
            this.txtIdCompromisso.Size = new System.Drawing.Size(62, 20);
            this.txtIdCompromisso.TabIndex = 20;
            this.txtIdCompromisso.Visible = false;
            // 
            // frmCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 463);
            this.Controls.Add(this.txtIdCompromisso);
            this.Controls.Add(this.dtpCompromisso);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.gridCompromissos);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.lblCompromissos);
            this.Controls.Add(this.lblAgendamento);
            this.Controls.Add(this.grpBoxCompromissos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cmbUsuarios);
            this.Name = "frmCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompromissos";
            this.Load += new System.EventHandler(this.frmCompromissos_Load);
            this.grpBoxCompromissos.ResumeLayout(false);
            this.grpBoxCompromissos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox grpBoxCompromissos;
        private System.Windows.Forms.Label lblHorarioInicial;
        private System.Windows.Forms.Label lblHorarioFinal;
        private System.Windows.Forms.MaskedTextBox txtHorarioInicial;
        private System.Windows.Forms.Button cmdHrIniSomar;
        private System.Windows.Forms.Button cmdHrIniDiminuir;
        private System.Windows.Forms.Button cmdHrFinDiminuir;
        private System.Windows.Forms.Button cmdHrFinSomar;
        private System.Windows.Forms.MaskedTextBox txtHorarioFinal;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdIncluir;
        private System.Windows.Forms.CheckBox chkDiaTodo;
        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.Label lblCompromissos;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.DataGridView gridCompromissos;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpCompromisso;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtIdCompromisso;
    }
}