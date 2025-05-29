namespace ImagensDinamicas
{
    partial class frmJogoDados
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
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.btJogar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lblMostrarGanhador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDado1
            // 
            this.picDado1.BackColor = System.Drawing.Color.White;
            this.picDado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado1.Location = new System.Drawing.Point(55, 210);
            this.picDado1.Margin = new System.Windows.Forms.Padding(6);
            this.picDado1.Name = "picDado1";
            this.picDado1.Size = new System.Drawing.Size(200, 200);
            this.picDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado1.TabIndex = 0;
            this.picDado1.TabStop = false;
            // 
            // lblJogador1
            // 
            this.lblJogador1.BackColor = System.Drawing.Color.White;
            this.lblJogador1.Location = new System.Drawing.Point(55, 164);
            this.lblJogador1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(200, 30);
            this.lblJogador1.TabIndex = 1;
            this.lblJogador1.Text = "Jogador 1";
            this.lblJogador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlacar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar1.Location = new System.Drawing.Point(121, 435);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(65, 65);
            this.lblPlacar1.TabIndex = 2;
            this.lblPlacar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlacar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar2.Location = new System.Drawing.Point(395, 435);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(65, 65);
            this.lblPlacar2.TabIndex = 5;
            this.lblPlacar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador2
            // 
            this.lblJogador2.BackColor = System.Drawing.Color.White;
            this.lblJogador2.Location = new System.Drawing.Point(329, 164);
            this.lblJogador2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(200, 30);
            this.lblJogador2.TabIndex = 4;
            this.lblJogador2.Text = "Jogador 2";
            this.lblJogador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDado2
            // 
            this.picDado2.BackColor = System.Drawing.Color.White;
            this.picDado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado2.Location = new System.Drawing.Point(329, 210);
            this.picDado2.Margin = new System.Windows.Forms.Padding(6);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(200, 200);
            this.picDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado2.TabIndex = 3;
            this.picDado2.TabStop = false;
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btReiniciar.Location = new System.Drawing.Point(121, 681);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(102, 49);
            this.btReiniciar.TabIndex = 6;
            this.btReiniciar.Text = "&Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btJogar.ForeColor = System.Drawing.Color.Black;
            this.btJogar.Location = new System.Drawing.Point(238, 681);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(102, 49);
            this.btJogar.TabIndex = 7;
            this.btJogar.Text = "&Jogar";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.ForeColor = System.Drawing.Color.Black;
            this.btSair.Location = new System.Drawing.Point(358, 681);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(102, 49);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lblMostrarGanhador
            // 
            this.lblMostrarGanhador.BackColor = System.Drawing.Color.White;
            this.lblMostrarGanhador.Location = new System.Drawing.Point(117, 572);
            this.lblMostrarGanhador.Name = "lblMostrarGanhador";
            this.lblMostrarGanhador.Size = new System.Drawing.Size(343, 33);
            this.lblMostrarGanhador.TabIndex = 9;
            this.lblMostrarGanhador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "DADOS DA SORTE";
            // 
            // frmJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(594, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMostrarGanhador);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.lblPlacar2);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.picDado2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.picDado1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmJogoDados";
            this.Text = "Jogo de Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJogoDados_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lblMostrarGanhador;
        private System.Windows.Forms.Label label2;
    }
}