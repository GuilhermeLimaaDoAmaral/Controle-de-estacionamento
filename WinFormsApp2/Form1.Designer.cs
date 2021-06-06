
namespace WinFormsApp2
{
    partial class frCadEstacionamento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbHoraSaida = new System.Windows.Forms.Label();
            this.lbDuracao = new System.Windows.Forms.Label();
            this.lbTempoCobrado = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbValorPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempoCobrado = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraChegada = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.mskDuracao = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tvSisEstacio = new System.Windows.Forms.DataGridView();
            this.btDeletar = new System.Windows.Forms.Button();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvSisEstacio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(85, 44);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(41, 15);
            this.lbPlaca.TabIndex = 0;
            this.lbPlaca.Text = "Placa: ";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(89, 73);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(37, 15);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data: ";
            // 
            // lbHoraSaida
            // 
            this.lbHoraSaida.AutoSize = true;
            this.lbHoraSaida.Location = new System.Drawing.Point(27, 131);
            this.lbHoraSaida.Name = "lbHoraSaida";
            this.lbHoraSaida.Size = new System.Drawing.Size(99, 15);
            this.lbHoraSaida.TabIndex = 2;
            this.lbHoraSaida.Text = "Horário de saída: ";
            // 
            // lbDuracao
            // 
            this.lbDuracao.AutoSize = true;
            this.lbDuracao.Location = new System.Drawing.Point(16, 168);
            this.lbDuracao.Name = "lbDuracao";
            this.lbDuracao.Size = new System.Drawing.Size(54, 15);
            this.lbDuracao.TabIndex = 3;
            this.lbDuracao.Text = "Duração:";
            // 
            // lbTempoCobrado
            // 
            this.lbTempoCobrado.AutoSize = true;
            this.lbTempoCobrado.Location = new System.Drawing.Point(136, 168);
            this.lbTempoCobrado.Name = "lbTempoCobrado";
            this.lbTempoCobrado.Size = new System.Drawing.Size(93, 15);
            this.lbTempoCobrado.TabIndex = 4;
            this.lbTempoCobrado.Text = "Tempo cobrado:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(16, 212);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(40, 15);
            this.lbPreco.TabIndex = 5;
            this.lbPreco.Text = "Preço:";
            // 
            // lbValorPagar
            // 
            this.lbValorPagar.AutoSize = true;
            this.lbValorPagar.Location = new System.Drawing.Point(137, 212);
            this.lbValorPagar.Name = "lbValorPagar";
            this.lbValorPagar.Size = new System.Drawing.Size(78, 15);
            this.lbValorPagar.TabIndex = 6;
            this.lbValorPagar.Text = "Valor a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Horário de chegada:";
            // 
            // txtTempoCobrado
            // 
            this.txtTempoCobrado.Enabled = false;
            this.txtTempoCobrado.Location = new System.Drawing.Point(136, 186);
            this.txtTempoCobrado.Name = "txtTempoCobrado";
            this.txtTempoCobrado.Size = new System.Drawing.Size(100, 23);
            this.txtTempoCobrado.TabIndex = 14;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(16, 230);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 23);
            this.txtPreco.TabIndex = 15;
            this.txtPreco.Text = "2.00";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Enabled = false;
            this.txtValorPagar.Location = new System.Drawing.Point(137, 230);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 23);
            this.txtValorPagar.TabIndex = 16;
            this.txtValorPagar.Text = "0.00";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(137, 271);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btCadastrar.TabIndex = 17;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(136, 70);
            this.mskData.Mask = "00-00-0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(100, 23);
            this.mskData.TabIndex = 10;
            this.mskData.Leave += new System.EventHandler(this.mskData_Leave);
            // 
            // mskHoraChegada
            // 
            this.mskHoraChegada.Location = new System.Drawing.Point(136, 99);
            this.mskHoraChegada.Mask = "00:00:00";
            this.mskHoraChegada.Name = "mskHoraChegada";
            this.mskHoraChegada.Size = new System.Drawing.Size(100, 23);
            this.mskHoraChegada.TabIndex = 11;
            this.mskHoraChegada.ValidatingType = typeof(int);
            this.mskHoraChegada.Leave += new System.EventHandler(this.mskHoraChegada_Leave);
            // 
            // mskHoraSaida
            // 
            this.mskHoraSaida.Location = new System.Drawing.Point(137, 128);
            this.mskHoraSaida.Mask = "00:00:00";
            this.mskHoraSaida.Name = "mskHoraSaida";
            this.mskHoraSaida.Size = new System.Drawing.Size(100, 23);
            this.mskHoraSaida.TabIndex = 12;
            this.mskHoraSaida.Leave += new System.EventHandler(this.mskHoraSaida_Leave);
            // 
            // mskDuracao
            // 
            this.mskDuracao.Enabled = false;
            this.mskDuracao.Location = new System.Drawing.Point(16, 186);
            this.mskDuracao.Mask = "00:00:00";
            this.mskDuracao.Name = "mskDuracao";
            this.mskDuracao.Size = new System.Drawing.Size(100, 23);
            this.mskDuracao.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp2.Properties.Resources.carro1;
            this.pictureBox1.Location = new System.Drawing.Point(584, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // tvSisEstacio
            // 
            this.tvSisEstacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvSisEstacio.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tvSisEstacio.Location = new System.Drawing.Point(260, 12);
            this.tvSisEstacio.Name = "tvSisEstacio";
            this.tvSisEstacio.ReadOnly = true;
            this.tvSisEstacio.RowTemplate.Height = 25;
            this.tvSisEstacio.Size = new System.Drawing.Size(691, 243);
            this.tvSisEstacio.TabIndex = 19;
            this.tvSisEstacio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tvSisEstacio_CellContentClick);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(260, 271);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(99, 23);
            this.btDeletar.TabIndex = 20;
            this.btDeletar.Text = "Deleta";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(137, 41);
            this.mskPlaca.Mask = "000-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(100, 23);
            this.mskPlaca.TabIndex = 9;
            this.mskPlaca.Leave += new System.EventHandler(this.mskPlaca_Leave);
            // 
            // frCadEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 352);
            this.Controls.Add(this.mskPlaca);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.tvSisEstacio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskDuracao);
            this.Controls.Add(this.mskHoraSaida);
            this.Controls.Add(this.mskHoraChegada);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtTempoCobrado);
            this.Controls.Add(this.lbValorPagar);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbTempoCobrado);
            this.Controls.Add(this.lbDuracao);
            this.Controls.Add(this.lbHoraSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbPlaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frCadEstacionamento";
            this.Text = "Cadastro de estacionamento";
            this.Load += new System.EventHandler(this.frCadEstacionamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvSisEstacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbHoraSaida;
        private System.Windows.Forms.Label lbDuracao;
        private System.Windows.Forms.Label lbTempoCobrado;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbValorPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempoCobrado;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.MaskedTextBox mskHoraChegada;
        private System.Windows.Forms.MaskedTextBox mskHoraSaida;
        private System.Windows.Forms.MaskedTextBox mskDuracao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tvSisEstacio;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
    }
}

