namespace ImagensDinamicas
{
    partial class frmMenu
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
            this.btJogoDeDados = new System.Windows.Forms.Button();
            this.btCarregaFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.picDados = new System.Windows.Forms.PictureBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btJogoDeDados
            // 
            this.btJogoDeDados.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btJogoDeDados.Location = new System.Drawing.Point(117, 106);
            this.btJogoDeDados.Margin = new System.Windows.Forms.Padding(6);
            this.btJogoDeDados.Name = "btJogoDeDados";
            this.btJogoDeDados.Size = new System.Drawing.Size(176, 203);
            this.btJogoDeDados.TabIndex = 0;
            this.btJogoDeDados.Text = "Jogo de &Dados";
            this.btJogoDeDados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btJogoDeDados.UseVisualStyleBackColor = false;
            this.btJogoDeDados.Click += new System.EventHandler(this.btJogoDeDados_Click);
            // 
            // btCarregaFoto
            // 
            this.btCarregaFoto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCarregaFoto.Location = new System.Drawing.Point(437, 106);
            this.btCarregaFoto.Margin = new System.Windows.Forms.Padding(6);
            this.btCarregaFoto.Name = "btCarregaFoto";
            this.btCarregaFoto.Size = new System.Drawing.Size(176, 203);
            this.btCarregaFoto.TabIndex = 1;
            this.btCarregaFoto.Text = "&Perfil / Placar";
            this.btCarregaFoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCarregaFoto.UseVisualStyleBackColor = false;
            this.btCarregaFoto.Click += new System.EventHandler(this.btCarregaFoto_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUAL APLICAÇÃO VOCÊ DESEJA ACESSAR ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.Location = new System.Drawing.Point(513, 339);
            this.btSair.Margin = new System.Windows.Forms.Padding(6);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(100, 34);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // picDados
            // 
            this.picDados.BackColor = System.Drawing.Color.White;
            this.picDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDados.Location = new System.Drawing.Point(128, 142);
            this.picDados.Name = "picDados";
            this.picDados.Size = new System.Drawing.Size(153, 153);
            this.picDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDados.TabIndex = 4;
            this.picDados.TabStop = false;
            this.picDados.Click += new System.EventHandler(this.picDados_Click);
            this.picDados.MouseEnter += new System.EventHandler(this.picDados_MouseEnter);
            this.picDados.MouseLeave += new System.EventHandler(this.picDados_MouseLeave);
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.White;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(448, 142);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(153, 153);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 5;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            this.picFoto.MouseEnter += new System.EventHandler(this.picFoto_MouseEnter);
            this.picFoto.MouseLeave += new System.EventHandler(this.picFoto_MouseLeave);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(706, 399);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.picDados);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCarregaFoto);
            this.Controls.Add(this.btJogoDeDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btJogoDeDados;
        private System.Windows.Forms.Button btCarregaFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox picDados;
        private System.Windows.Forms.PictureBox picFoto;
    }
}