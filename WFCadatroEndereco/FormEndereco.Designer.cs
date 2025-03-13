namespace WFCadastroEndereco
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblCep = new Label();
            lblLinha = new Label();
            mtbCep = new MaskedTextBox();
            txtLogradouro = new TextBox();
            lblLogradouro = new Label();
            txtNumero = new TextBox();
            cbxUf = new ComboBox();
            lblUf = new Label();
            lblNumero = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            chkNumero = new CheckBox();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(12, 26);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(12, 44);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(412, 23);
            txtNomeCompleto.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(196, 324);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 42);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(12, 93);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "CEP";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(13, 83);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(481, 1);
            lblLinha.TabIndex = 11;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(12, 111);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(124, 23);
            mtbCep.TabIndex = 1;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(12, 164);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(245, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(13, 146);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 16;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(283, 164);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(83, 23);
            txtNumero.TabIndex = 3;
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(12, 324);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 8;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(13, 306);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 19;
            lblUf.Text = "UF";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(283, 146);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 20;
            lblNumero.Text = "Numero";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(13, 220);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(191, 23);
            txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(13, 202);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 22;
            lblComplemento.Text = "Complemento";
            // 
            // chkNumero
            // 
            chkNumero.AutoSize = true;
            chkNumero.Location = new Point(372, 166);
            chkNumero.Name = "chkNumero";
            chkNumero.Size = new Size(101, 19);
            chkNumero.TabIndex = 4;
            chkNumero.Text = "Sem Numero?";
            chkNumero.UseVisualStyleBackColor = true;
            chkNumero.CheckedChanged += chkNumero_CheckedChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(13, 271);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(244, 23);
            txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(12, 253);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 25;
            lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(241, 220);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(144, 23);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(241, 202);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 27;
            lblBairro.Text = "Bairro";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 428);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(lblCidade);
            Controls.Add(txtCidade);
            Controls.Add(chkNumero);
            Controls.Add(lblComplemento);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            Controls.Add(lblUf);
            Controls.Add(cbxUf);
            Controls.Add(txtNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(txtLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private TextBox txtLogradouro;
        private Label lblCep;
        private Label lblLinha;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private TextBox txtNumero;
        private ComboBox cbxUf;
        private Label lblUf;
        private Label lblNumero;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private CheckBox chkNumero;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtBairro;
        private Label lblBairro;
    }
}