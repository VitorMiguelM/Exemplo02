namespace Exemplo02
{
    partial class Exemplo02
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbValorHora = new System.Windows.Forms.Label();
            this.lbQuantidadeHoras = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtQuantidadeHoras = new System.Windows.Forms.TextBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.cbUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.lbUnidadeFederativa = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNome.Location = new System.Drawing.Point(35, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 16);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbValorHora
            // 
            this.lbValorHora.AutoSize = true;
            this.lbValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorHora.Location = new System.Drawing.Point(29, 59);
            this.lbValorHora.Name = "lbValorHora";
            this.lbValorHora.Size = new System.Drawing.Size(83, 16);
            this.lbValorHora.TabIndex = 1;
            this.lbValorHora.Text = "Valor Hora";
            // 
            // lbQuantidadeHoras
            // 
            this.lbQuantidadeHoras.AutoSize = true;
            this.lbQuantidadeHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeHoras.Location = new System.Drawing.Point(2, 114);
            this.lbQuantidadeHoras.Name = "lbQuantidadeHoras";
            this.lbQuantidadeHoras.Size = new System.Drawing.Size(143, 15);
            this.lbQuantidadeHoras.TabIndex = 2;
            this.lbQuantidadeHoras.Text = "Quantidade de Horas";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(12, 78);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(117, 20);
            this.txtValorHora.TabIndex = 4;
            // 
            // txtQuantidadeHoras
            // 
            this.txtQuantidadeHoras.Location = new System.Drawing.Point(12, 133);
            this.txtQuantidadeHoras.Name = "txtQuantidadeHoras";
            this.txtQuantidadeHoras.Size = new System.Drawing.Size(117, 20);
            this.txtQuantidadeHoras.TabIndex = 5;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMacho.Location = new System.Drawing.Point(15, 159);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(96, 20);
            this.rbMacho.TabIndex = 6;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Masculino";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemea.Location = new System.Drawing.Point(117, 159);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(89, 20);
            this.rbFemea.TabIndex = 7;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Feminino";
            this.rbFemea.UseVisualStyleBackColor = true;
            // 
            // cbUnidadeFederativa
            // 
            this.cbUnidadeFederativa.FormattingEnabled = true;
            this.cbUnidadeFederativa.Items.AddRange(new object[] {
            "AC\t ",
            "AL\t ",
            "AP\t ",
            "AM\t ",
            "BA\t ",
            "CE\t ",
            "DF\t ",
            "ES\t ",
            "GO\t ",
            "MA\t ",
            "MT\t ",
            "MS\t ",
            "MG\t ",
            "PA\t ",
            "PB\t ",
            "PR\t ",
            "PE\t ",
            "PI\t ",
            "RJ\t ",
            "RN\t ",
            "RS\t ",
            "RO\t ",
            "RR\t ",
            "SC\t ",
            "SP\t",
            " SE\t ",
            "TO"});
            this.cbUnidadeFederativa.Location = new System.Drawing.Point(186, 28);
            this.cbUnidadeFederativa.Name = "cbUnidadeFederativa";
            this.cbUnidadeFederativa.Size = new System.Drawing.Size(164, 21);
            this.cbUnidadeFederativa.TabIndex = 8;
            // 
            // lbUnidadeFederativa
            // 
            this.lbUnidadeFederativa.AutoSize = true;
            this.lbUnidadeFederativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidadeFederativa.Location = new System.Drawing.Point(183, 9);
            this.lbUnidadeFederativa.Name = "lbUnidadeFederativa";
            this.lbUnidadeFederativa.Size = new System.Drawing.Size(146, 16);
            this.lbUnidadeFederativa.TabIndex = 9;
            this.lbUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(183, 59);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(58, 16);
            this.lbCidade.TabIndex = 10;
            this.lbCidade.Text = "Cidade";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(328, 59);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(50, 16);
            this.lbBairro.TabIndex = 11;
            this.lbBairro.Text = "Bairro";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.Location = new System.Drawing.Point(56, 186);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(103, 16);
            this.lbComplemento.TabIndex = 12;
            this.lbComplemento.Text = "Complemento";
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogradouro.Location = new System.Drawing.Point(165, 114);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(88, 16);
            this.lbLogradouro.TabIndex = 13;
            this.lbLogradouro.Text = "Logradouro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(328, 114);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(62, 16);
            this.lbNumero.TabIndex = 14;
            this.lbNumero.Text = "Número";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(148, 78);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(124, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(288, 78);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(123, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(148, 133);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(124, 20);
            this.txtLogradouro.TabIndex = 17;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(288, 133);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(123, 20);
            this.txtNumero.TabIndex = 18;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(5, 205);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(211, 63);
            this.txtComplemento.TabIndex = 19;
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCadastrar.Location = new System.Drawing.Point(226, 235);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(127, 23);
            this.bttCadastrar.TabIndex = 20;
            this.bttCadastrar.Text = "Cadastrar";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(275, 202);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(136, 20);
            this.dtpDataNascimento.TabIndex = 21;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(272, 186);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(146, 16);
            this.lbDataNascimento.TabIndex = 22;
            this.lbDataNascimento.Text = "Data de nascimento";
            // 
            // Exemplo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(423, 272);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.bttCadastrar);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbLogradouro);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbUnidadeFederativa);
            this.Controls.Add(this.cbUnidadeFederativa);
            this.Controls.Add(this.rbFemea);
            this.Controls.Add(this.rbMacho);
            this.Controls.Add(this.txtQuantidadeHoras);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbQuantidadeHoras);
            this.Controls.Add(this.lbValorHora);
            this.Controls.Add(this.lbNome);
            this.Name = "Exemplo02";
            this.Text = "Exemplo02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbValorHora;
        private System.Windows.Forms.Label lbQuantidadeHoras;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtQuantidadeHoras;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.ComboBox cbUnidadeFederativa;
        private System.Windows.Forms.Label lbUnidadeFederativa;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button bttCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lbDataNascimento;
    }
}

