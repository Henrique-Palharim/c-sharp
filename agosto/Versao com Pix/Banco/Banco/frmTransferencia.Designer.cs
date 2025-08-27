namespace Banco
{
    partial class frmTransferencia
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
            this.label13 = new System.Windows.Forms.Label();
            this.lblSaldoLimite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.numValorDeposito = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.numValorSaque = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(225, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 37);
            this.label13.TabIndex = 40;
            this.label13.Text = "TRANSFERÊNCIA";
            // 
            // lblSaldoLimite
            // 
            this.lblSaldoLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSaldoLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldoLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoLimite.Location = new System.Drawing.Point(512, 150);
            this.lblSaldoLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoLimite.Name = "lblSaldoLimite";
            this.lblSaldoLimite.Size = new System.Drawing.Size(228, 26);
            this.lblSaldoLimite.TabIndex = 39;
            this.lblSaldoLimite.Text = "0,00";
            this.lblSaldoLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Saldo com Limite:";
            // 
            // numLimiteCredito
            // 
            this.numLimiteCredito.DecimalPlaces = 2;
            this.numLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimiteCredito.Location = new System.Drawing.Point(64, 150);
            this.numLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numLimiteCredito.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numLimiteCredito.Name = "numLimiteCredito";
            this.numLimiteCredito.Size = new System.Drawing.Size(182, 26);
            this.numLimiteCredito.TabIndex = 0;
            this.numLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLimiteCredito.Validating += new System.ComponentModel.CancelEventHandler(this.numLimiteCredito_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Limite:";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(421, 312);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(182, 48);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "&Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click_1);
            // 
            // numValorDeposito
            // 
            this.numValorDeposito.DecimalPlaces = 2;
            this.numValorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorDeposito.Location = new System.Drawing.Point(421, 251);
            this.numValorDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorDeposito.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numValorDeposito.Name = "numValorDeposito";
            this.numValorDeposito.Size = new System.Drawing.Size(182, 26);
            this.numValorDeposito.TabIndex = 2;
            this.numValorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Valor Depósito;";
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.LightCoral;
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(192, 312);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(182, 48);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // numValorSaque
            // 
            this.numValorSaque.DecimalPlaces = 2;
            this.numValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorSaque.Location = new System.Drawing.Point(192, 251);
            this.numValorSaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorSaque.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numValorSaque.Name = "numValorSaque";
            this.numValorSaque.Size = new System.Drawing.Size(182, 26);
            this.numValorSaque.TabIndex = 1;
            this.numValorSaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Valor Saque:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(283, 150);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(186, 26);
            this.lblSaldo.TabIndex = 29;
            this.lblSaldo.Text = "0,00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Saldo:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.MistyRose;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(658, 312);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 48);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSaldoLimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numLimiteCredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.numValorDeposito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.numValorSaque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Name = "frmTransferencia";
            this.Text = "frmTransferencia";
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSaldoLimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLimiteCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.NumericUpDown numValorDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.NumericUpDown numValorSaque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}