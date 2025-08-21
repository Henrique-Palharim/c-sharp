namespace Banco
{
    partial class frmCaixaEletronica
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numValorSaque = new System.Windows.Forms.NumericUpDown();
            this.btnSacar = new System.Windows.Forms.Button();
            this.numValorDeposito = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btDepositar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldoLimite = new System.Windows.Forms.Label();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.txtPagador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContaPagador = new System.Windows.Forms.TextBox();
            this.txtContaRemetente = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.numValorTransferencia = new System.Windows.Forms.NumericUpDown();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(244, 128);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(186, 26);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "0,00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Saque:";
            // 
            // numValorSaque
            // 
            this.numValorSaque.DecimalPlaces = 2;
            this.numValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorSaque.Location = new System.Drawing.Point(153, 229);
            this.numValorSaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorSaque.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numValorSaque.Name = "numValorSaque";
            this.numValorSaque.Size = new System.Drawing.Size(182, 26);
            this.numValorSaque.TabIndex = 3;
            this.numValorSaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.LightCoral;
            this.btnSacar.Location = new System.Drawing.Point(153, 290);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(182, 48);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // numValorDeposito
            // 
            this.numValorDeposito.DecimalPlaces = 2;
            this.numValorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorDeposito.Location = new System.Drawing.Point(382, 229);
            this.numValorDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorDeposito.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numValorDeposito.Name = "numValorDeposito";
            this.numValorDeposito.Size = new System.Drawing.Size(182, 26);
            this.numValorDeposito.TabIndex = 6;
            this.numValorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Depósito;";
            // 
            // btDepositar
            // 
            this.btDepositar.BackColor = System.Drawing.Color.LightCoral;
            this.btDepositar.Location = new System.Drawing.Point(382, 290);
            this.btDepositar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(182, 48);
            this.btDepositar.TabIndex = 7;
            this.btDepositar.Text = "&Depositar";
            this.btDepositar.UseVisualStyleBackColor = false;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Limite:";
            // 
            // numLimiteCredito
            // 
            this.numLimiteCredito.DecimalPlaces = 2;
            this.numLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimiteCredito.Location = new System.Drawing.Point(25, 128);
            this.numLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numLimiteCredito.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numLimiteCredito.Name = "numLimiteCredito";
            this.numLimiteCredito.Size = new System.Drawing.Size(182, 26);
            this.numLimiteCredito.TabIndex = 9;
            this.numLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLimiteCredito.Validating += new System.ComponentModel.CancelEventHandler(this.numLimiteCredito_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo com Limite:";
            // 
            // lblSaldoLimite
            // 
            this.lblSaldoLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSaldoLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldoLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoLimite.Location = new System.Drawing.Point(473, 128);
            this.lblSaldoLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoLimite.Name = "lblSaldoLimite";
            this.lblSaldoLimite.Size = new System.Drawing.Size(228, 26);
            this.lblSaldoLimite.TabIndex = 11;
            this.lblSaldoLimite.Text = "0,00";
            this.lblSaldoLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRemetente
            // 
            this.txtRemetente.Location = new System.Drawing.Point(1011, 156);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(438, 26);
            this.txtRemetente.TabIndex = 12;
            this.txtRemetente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemetente_KeyPress);
            // 
            // txtPagador
            // 
            this.txtPagador.Location = new System.Drawing.Point(1011, 112);
            this.txtPagador.Name = "txtPagador";
            this.txtPagador.Size = new System.Drawing.Size(438, 26);
            this.txtPagador.TabIndex = 13;
            this.txtPagador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagador_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(850, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome Remetente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(872, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome Pagador:";
            // 
            // txtContaPagador
            // 
            this.txtContaPagador.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContaPagador.Location = new System.Drawing.Point(891, 246);
            this.txtContaPagador.MaxLength = 10;
            this.txtContaPagador.Name = "txtContaPagador";
            this.txtContaPagador.Size = new System.Drawing.Size(117, 26);
            this.txtContaPagador.TabIndex = 16;
            // 
            // txtContaRemetente
            // 
            this.txtContaRemetente.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContaRemetente.Location = new System.Drawing.Point(1076, 246);
            this.txtContaRemetente.MaxLength = 10;
            this.txtContaRemetente.Name = "txtContaRemetente";
            this.txtContaRemetente.Size = new System.Drawing.Size(117, 26);
            this.txtContaRemetente.TabIndex = 17;
            this.txtContaRemetente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContaRemetente_KeyPress);
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTransferir.Location = new System.Drawing.Point(971, 392);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(182, 48);
            this.btnTransferir.TabIndex = 18;
            this.btnTransferir.Text = "&Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // numValorTransferencia
            // 
            this.numValorTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numValorTransferencia.DecimalPlaces = 2;
            this.numValorTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorTransferencia.Location = new System.Drawing.Point(1259, 247);
            this.numValorTransferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorTransferencia.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numValorTransferencia.Name = "numValorTransferencia";
            this.numValorTransferencia.Size = new System.Drawing.Size(190, 26);
            this.numValorTransferencia.TabIndex = 19;
            this.numValorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(854, 338);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(595, 26);
            this.txtMensagem.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(1113, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 39);
            this.label8.TabIndex = 22;
            this.label8.Text = "PIX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1255, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(850, 306);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mensagem (opcional):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(872, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nº Conta Pagador:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1048, 223);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Nº Conta Remetente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(182, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(302, 39);
            this.label13.TabIndex = 27;
            this.label13.Text = "TRANSFERÊNCIA";
            // 
            // btnExtrato
            // 
            this.btnExtrato.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExtrato.Location = new System.Drawing.Point(1183, 392);
            this.btnExtrato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(182, 48);
            this.btnExtrato.TabIndex = 28;
            this.btnExtrato.Text = "&Extrato";
            this.btnExtrato.UseVisualStyleBackColor = false;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(741, -2);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 477);
            this.label14.TabIndex = 29;
            // 
            // frmCaixaEletronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1485, 474);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.lblSaldoLimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numLimiteCredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.numValorDeposito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.numValorSaque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCaixaEletronica";
            this.Text = "Caixa Eletrônico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCaixaEletronica_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numValorSaque;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.NumericUpDown numValorDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLimiteCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldoLimite;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox txtPagador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContaPagador;
        private System.Windows.Forms.TextBox txtContaRemetente;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.NumericUpDown numValorTransferencia;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Label label14;
    }
}

