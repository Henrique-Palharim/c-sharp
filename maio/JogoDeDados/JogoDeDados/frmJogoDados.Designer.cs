namespace JogoDeDados
{
    partial class frmJogoDados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMostrarGanhador = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btJogar = new System.Windows.Forms.Button();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.timerAtualizaDado = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 44);
            this.label2.TabIndex = 21;
            this.label2.Text = "DADOS DA SORTE";
            // 
            // lblMostrarGanhador
            // 
            this.lblMostrarGanhador.BackColor = System.Drawing.Color.White;
            this.lblMostrarGanhador.Location = new System.Drawing.Point(117, 571);
            this.lblMostrarGanhador.Name = "lblMostrarGanhador";
            this.lblMostrarGanhador.Size = new System.Drawing.Size(343, 33);
            this.lblMostrarGanhador.TabIndex = 20;
            this.lblMostrarGanhador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.ForeColor = System.Drawing.Color.Black;
            this.btSair.Location = new System.Drawing.Point(358, 680);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(102, 49);
            this.btSair.TabIndex = 19;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btJogar.ForeColor = System.Drawing.Color.Black;
            this.btJogar.Location = new System.Drawing.Point(238, 680);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(102, 49);
            this.btJogar.TabIndex = 18;
            this.btJogar.Text = "&Jogar";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btReiniciar.Location = new System.Drawing.Point(121, 680);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(102, 49);
            this.btReiniciar.TabIndex = 17;
            this.btReiniciar.Text = "&Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click_1);
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlacar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar2.Location = new System.Drawing.Point(395, 434);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(65, 65);
            this.lblPlacar2.TabIndex = 16;
            this.lblPlacar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(329, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jogador 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDado2
            // 
            this.picDado2.BackColor = System.Drawing.Color.White;
            this.picDado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado2.Location = new System.Drawing.Point(329, 209);
            this.picDado2.Margin = new System.Windows.Forms.Padding(6);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(200, 200);
            this.picDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado2.TabIndex = 14;
            this.picDado2.TabStop = false;
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlacar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar1.Location = new System.Drawing.Point(121, 434);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(65, 65);
            this.lblPlacar1.TabIndex = 13;
            this.lblPlacar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogador 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDado1
            // 
            this.picDado1.BackColor = System.Drawing.Color.White;
            this.picDado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado1.Location = new System.Drawing.Point(55, 209);
            this.picDado1.Margin = new System.Windows.Forms.Padding(6);
            this.picDado1.Name = "picDado1";
            this.picDado1.Size = new System.Drawing.Size(200, 200);
            this.picDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado1.TabIndex = 11;
            this.picDado1.TabStop = false;
            // 
            // timerAtualizaDado
            // 
            this.timerAtualizaDado.Interval = 250;
            this.timerAtualizaDado.Tick += new System.EventHandler(this.timerAtualizaDado_Tick_1);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picDado2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDado1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmJogoDados";
            this.Text = "Jogo de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMostrarGanhador;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.Timer timerAtualizaDado;
    }
}

