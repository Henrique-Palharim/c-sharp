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
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 31);
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
            this.lblSaldo.Location = new System.Drawing.Point(103, 60);
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
            this.label2.Location = new System.Drawing.Point(204, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Saque:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numValorSaque
            // 
            this.numValorSaque.DecimalPlaces = 2;
            this.numValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorSaque.Location = new System.Drawing.Point(208, 186);
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
            this.numValorSaque.ValueChanged += new System.EventHandler(this.numValorSaque_ValueChanged);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSacar.Location = new System.Drawing.Point(208, 294);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(177, 48);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // numValorDeposito
            // 
            this.numValorDeposito.DecimalPlaces = 2;
            this.numValorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorDeposito.Location = new System.Drawing.Point(484, 186);
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
            this.numValorDeposito.ValueChanged += new System.EventHandler(this.numValorDeposito_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Depósito;";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.BackColor = System.Drawing.Color.SkyBlue;
            this.btDepositar.Location = new System.Drawing.Point(484, 294);
            this.btDepositar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(177, 48);
            this.btDepositar.TabIndex = 7;
            this.btDepositar.Text = "&Depositar";
            this.btDepositar.UseVisualStyleBackColor = false;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 31);
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
            this.numLimiteCredito.Location = new System.Drawing.Point(340, 60);
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
            this.label5.Location = new System.Drawing.Point(554, 31);
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
            this.lblSaldoLimite.Location = new System.Drawing.Point(558, 60);
            this.lblSaldoLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoLimite.Name = "lblSaldoLimite";
            this.lblSaldoLimite.Size = new System.Drawing.Size(272, 26);
            this.lblSaldoLimite.TabIndex = 11;
            this.lblSaldoLimite.Text = "0,00";
            this.lblSaldoLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCaixaEletronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(903, 384);
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
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).EndInit();
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
    }
}

