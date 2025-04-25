namespace TesteThoth
{
    partial class frmUsuarios
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
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.lblGrid = new System.Windows.Forms.Label();
            this.grpBoxCadUsuarios = new System.Windows.Forms.GroupBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdVerSenha = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.grpBoxCadUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(15, 149);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(425, 149);
            this.gridUsuarios.TabIndex = 3;
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrid.Location = new System.Drawing.Point(15, 130);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(164, 16);
            this.lblGrid.TabIndex = 4;
            this.lblGrid.Text = "Usuários cadastrados";
            // 
            // grpBoxCadUsuarios
            // 
            this.grpBoxCadUsuarios.Controls.Add(this.txtIdUsuario);
            this.grpBoxCadUsuarios.Controls.Add(this.cmdCancelar);
            this.grpBoxCadUsuarios.Controls.Add(this.cmdOk);
            this.grpBoxCadUsuarios.Controls.Add(this.cmdVerSenha);
            this.grpBoxCadUsuarios.Controls.Add(this.txtSenha);
            this.grpBoxCadUsuarios.Controls.Add(this.txtLogin);
            this.grpBoxCadUsuarios.Controls.Add(this.txtNome);
            this.grpBoxCadUsuarios.Controls.Add(this.lblSenha);
            this.grpBoxCadUsuarios.Controls.Add(this.lblLogin);
            this.grpBoxCadUsuarios.Controls.Add(this.lblNome);
            this.grpBoxCadUsuarios.Location = new System.Drawing.Point(11, 8);
            this.grpBoxCadUsuarios.Name = "grpBoxCadUsuarios";
            this.grpBoxCadUsuarios.Size = new System.Drawing.Size(428, 109);
            this.grpBoxCadUsuarios.TabIndex = 8;
            this.grpBoxCadUsuarios.TabStop = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(363, 45);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(48, 20);
            this.txtIdUsuario.TabIndex = 16;
            this.txtIdUsuario.Visible = false;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(348, 72);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(63, 25);
            this.cmdCancelar.TabIndex = 15;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(279, 72);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(63, 25);
            this.cmdOk.TabIndex = 14;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdVerSenha
            // 
            this.cmdVerSenha.BackColor = System.Drawing.Color.White;
            this.cmdVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVerSenha.ForeColor = System.Drawing.Color.White;
            this.cmdVerSenha.Location = new System.Drawing.Point(178, 75);
            this.cmdVerSenha.Name = "cmdVerSenha";
            this.cmdVerSenha.Size = new System.Drawing.Size(27, 18);
            this.cmdVerSenha.TabIndex = 3;
            this.cmdVerSenha.UseVisualStyleBackColor = false;
            this.cmdVerSenha.Click += new System.EventHandler(this.cmdVerSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(69, 74);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(103, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(69, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(136, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(69, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Blue;
            this.lblSenha.Location = new System.Drawing.Point(14, 76);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblLogin.Location = new System.Drawing.Point(14, 47);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 16);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Blue;
            this.lblNome.Location = new System.Drawing.Point(14, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(15, 308);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(63, 25);
            this.cmdNovo.TabIndex = 9;
            this.cmdNovo.Text = "&Novo";
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Location = new System.Drawing.Point(84, 308);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(63, 25);
            this.cmdAlterar.TabIndex = 10;
            this.cmdAlterar.Text = "&Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(153, 308);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(63, 25);
            this.cmdExcluir.TabIndex = 11;
            this.cmdExcluir.Text = "&Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(377, 308);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(63, 25);
            this.cmdSair.TabIndex = 12;
            this.cmdSair.Text = "&Fechar";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 341);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.grpBoxCadUsuarios);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.gridUsuarios);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.grpBoxCadUsuarios.ResumeLayout(false);
            this.grpBoxCadUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.GroupBox grpBoxCadUsuarios;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button cmdVerSenha;
        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TextBox txtIdUsuario;
    }
}