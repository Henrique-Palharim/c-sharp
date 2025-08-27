namespace Banco
{
    partial class frmPix
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
            this.btnExtrato = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.numValorTransferencia = new System.Windows.Forms.NumericUpDown();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.txtContaRemetente = new System.Windows.Forms.TextBox();
            this.txtContaPagador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPagador = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMetodoPagamento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtrato
            // 
            this.btnExtrato.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.Location = new System.Drawing.Point(317, 526);
            this.btnExtrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(182, 48);
            this.btnExtrato.TabIndex = 9;
            this.btnExtrato.Text = "&Extrato";
            this.btnExtrato.UseVisualStyleBackColor = false;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(299, 211);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Nº Conta Remetente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 211);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Nº Conta Pagador:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 440);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Mensagem (opcional):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(364, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 37);
            this.label8.TabIndex = 38;
            this.label8.Text = "PIX";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(105, 472);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.Size = new System.Drawing.Size(595, 46);
            this.txtMensagem.TabIndex = 7;
            // 
            // numValorTransferencia
            // 
            this.numValorTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numValorTransferencia.DecimalPlaces = 2;
            this.numValorTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorTransferencia.Location = new System.Drawing.Point(510, 235);
            this.numValorTransferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorTransferencia.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numValorTransferencia.Name = "numValorTransferencia";
            this.numValorTransferencia.Size = new System.Drawing.Size(190, 26);
            this.numValorTransferencia.TabIndex = 4;
            this.numValorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(105, 526);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(182, 48);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "&Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // txtContaRemetente
            // 
            this.txtContaRemetente.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContaRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaRemetente.Location = new System.Drawing.Point(327, 234);
            this.txtContaRemetente.MaxLength = 10;
            this.txtContaRemetente.Name = "txtContaRemetente";
            this.txtContaRemetente.Size = new System.Drawing.Size(117, 26);
            this.txtContaRemetente.TabIndex = 3;
            // 
            // txtContaPagador
            // 
            this.txtContaPagador.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContaPagador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaPagador.Location = new System.Drawing.Point(142, 234);
            this.txtContaPagador.MaxLength = 10;
            this.txtContaPagador.Name = "txtContaPagador";
            this.txtContaPagador.Size = new System.Drawing.Size(117, 26);
            this.txtContaPagador.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nome Pagador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nome Remetente:";
            // 
            // txtPagador
            // 
            this.txtPagador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagador.Location = new System.Drawing.Point(262, 100);
            this.txtPagador.Name = "txtPagador";
            this.txtPagador.Size = new System.Drawing.Size(438, 26);
            this.txtPagador.TabIndex = 0;
            // 
            // txtRemetente
            // 
            this.txtRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemetente.Location = new System.Drawing.Point(262, 144);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(438, 26);
            this.txtRemetente.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.MistyRose;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(618, 526);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 48);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.BackColor = System.Drawing.Color.PaleTurquoise;
            this.comboBoxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Items.AddRange(new object[] {
            "Débito",
            "Crédito"});
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(510, 382);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(190, 28);
            this.comboBoxFormaPagamento.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Forma de PIX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Método de PIX:";
            // 
            // comboBoxMetodoPagamento
            // 
            this.comboBoxMetodoPagamento.BackColor = System.Drawing.Color.LightBlue;
            this.comboBoxMetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetodoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMetodoPagamento.FormattingEnabled = true;
            this.comboBoxMetodoPagamento.Items.AddRange(new object[] {
            "QR Code",
            "Chave CPF/CNPJ",
            "Chave Celular",
            "Chave E-mail",
            "Dados Bancários"});
            this.comboBoxMetodoPagamento.Location = new System.Drawing.Point(510, 314);
            this.comboBoxMetodoPagamento.Name = "comboBoxMetodoPagamento";
            this.comboBoxMetodoPagamento.Size = new System.Drawing.Size(190, 28);
            this.comboBoxMetodoPagamento.TabIndex = 5;
            // 
            // frmPix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(775, 658);
            this.Controls.Add(this.comboBoxMetodoPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.numValorTransferencia);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtContaRemetente);
            this.Controls.Add(this.txtContaPagador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPagador);
            this.Controls.Add(this.txtRemetente);
            this.Name = "frmPix";
            this.Text = "frmPix";
            this.Load += new System.EventHandler(this.frmPix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.NumericUpDown numValorTransferencia;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox txtContaRemetente;
        private System.Windows.Forms.TextBox txtContaPagador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPagador;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMetodoPagamento;
    }
}