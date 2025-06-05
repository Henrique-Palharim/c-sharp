namespace ImagensDinamicas
{
    partial class frmCarregaFoto
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
            this.txtNomeJogador1 = new System.Windows.Forms.TextBox();
            this.txtNomeJogador2 = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.picFotoJogador1 = new System.Windows.Forms.PictureBox();
            this.btCarregarFoto1 = new System.Windows.Forms.Button();
            this.openFDFoto = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.picFotoJogador2 = new System.Windows.Forms.PictureBox();
            this.btCarregarFoto2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.btContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeJogador1
            // 
            this.txtNomeJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador1.ForeColor = System.Drawing.Color.Black;
            this.txtNomeJogador1.Location = new System.Drawing.Point(84, 134);
            this.txtNomeJogador1.Name = "txtNomeJogador1";
            this.txtNomeJogador1.Size = new System.Drawing.Size(187, 29);
            this.txtNomeJogador1.TabIndex = 1;
            // 
            // txtNomeJogador2
            // 
            this.txtNomeJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador2.ForeColor = System.Drawing.Color.Black;
            this.txtNomeJogador2.Location = new System.Drawing.Point(384, 134);
            this.txtNomeJogador2.Name = "txtNomeJogador2";
            this.txtNomeJogador2.Size = new System.Drawing.Size(187, 29);
            this.txtNomeJogador2.TabIndex = 4;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(246, 609);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(107, 36);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(360, 609);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(107, 36);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // picFotoJogador1
            // 
            this.picFotoJogador1.BackColor = System.Drawing.Color.White;
            this.picFotoJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoJogador1.Location = new System.Drawing.Point(84, 187);
            this.picFotoJogador1.Name = "picFotoJogador1";
            this.picFotoJogador1.Size = new System.Drawing.Size(187, 211);
            this.picFotoJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoJogador1.TabIndex = 7;
            this.picFotoJogador1.TabStop = false;
            // 
            // btCarregarFoto1
            // 
            this.btCarregarFoto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregarFoto1.Location = new System.Drawing.Point(84, 404);
            this.btCarregarFoto1.Name = "btCarregarFoto1";
            this.btCarregarFoto1.Size = new System.Drawing.Size(187, 36);
            this.btCarregarFoto1.TabIndex = 8;
            this.btCarregarFoto1.Text = "Carregar &Foto";
            this.btCarregarFoto1.UseVisualStyleBackColor = true;
            this.btCarregarFoto1.Click += new System.EventHandler(this.btCarregarFoto1_Click);
            // 
            // openFDFoto
            // 
            this.openFDFoto.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "JOGADORES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFotoJogador2
            // 
            this.picFotoJogador2.BackColor = System.Drawing.Color.White;
            this.picFotoJogador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoJogador2.Location = new System.Drawing.Point(384, 187);
            this.picFotoJogador2.Name = "picFotoJogador2";
            this.picFotoJogador2.Size = new System.Drawing.Size(187, 211);
            this.picFotoJogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoJogador2.TabIndex = 11;
            this.picFotoJogador2.TabStop = false;
            // 
            // btCarregarFoto2
            // 
            this.btCarregarFoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregarFoto2.Location = new System.Drawing.Point(384, 404);
            this.btCarregarFoto2.Name = "btCarregarFoto2";
            this.btCarregarFoto2.Size = new System.Drawing.Size(187, 36);
            this.btCarregarFoto2.TabIndex = 12;
            this.btCarregarFoto2.Text = "Carregar &Foto";
            this.btCarregarFoto2.UseVisualStyleBackColor = true;
            this.btCarregarFoto2.Click += new System.EventHandler(this.btCarregarFoto2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placar:";
            // 
            // lblPlacar
            // 
            this.lblPlacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(321, 514);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(78, 26);
            this.lblPlacar.TabIndex = 14;
            this.lblPlacar.Text = "0 x 0";
            this.lblPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btContinuar
            // 
            this.btContinuar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinuar.Location = new System.Drawing.Point(133, 609);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(107, 36);
            this.btContinuar.TabIndex = 15;
            this.btContinuar.Text = "&Continuar";
            this.btContinuar.UseVisualStyleBackColor = false;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // frmCarregaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(651, 691);
            this.Controls.Add(this.btContinuar);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCarregarFoto2);
            this.Controls.Add(this.picFotoJogador2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCarregarFoto1);
            this.Controls.Add(this.picFotoJogador1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txtNomeJogador2);
            this.Controls.Add(this.txtNomeJogador1);
            this.Name = "frmCarregaFoto";
            this.Text = "Carregar Foto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCarregaFoto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeJogador1;
        private System.Windows.Forms.TextBox txtNomeJogador2;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox picFotoJogador1;
        private System.Windows.Forms.Button btCarregarFoto1;
        private System.Windows.Forms.OpenFileDialog openFDFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFotoJogador2;
        private System.Windows.Forms.Button btCarregarFoto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Button btContinuar;
    }
}

