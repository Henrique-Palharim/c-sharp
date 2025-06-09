namespace ImagensDinamicas
{
    partial class frmPlacar
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
            this.btSair = new System.Windows.Forms.Button();
            this.picFotoJogador1 = new System.Windows.Forms.PictureBox();
            this.openFDFoto = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.picFotoJogador2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.lblNomeJogador1 = new System.Windows.Forms.Label();
            this.lblNomeJogador2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador2)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(267, 570);
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
            this.label3.Text = "PLACAR";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 474);
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
            this.lblPlacar.Location = new System.Drawing.Point(321, 474);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(78, 26);
            this.lblPlacar.TabIndex = 14;
            this.lblPlacar.Text = "0 x 0";
            this.lblPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeJogador1
            // 
            this.lblNomeJogador1.BackColor = System.Drawing.Color.White;
            this.lblNomeJogador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador1.Location = new System.Drawing.Point(84, 134);
            this.lblNomeJogador1.Name = "lblNomeJogador1";
            this.lblNomeJogador1.Size = new System.Drawing.Size(187, 29);
            this.lblNomeJogador1.TabIndex = 15;
            this.lblNomeJogador1.Text = "aaaaa";
            // 
            // lblNomeJogador2
            // 
            this.lblNomeJogador2.BackColor = System.Drawing.Color.White;
            this.lblNomeJogador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador2.Location = new System.Drawing.Point(384, 134);
            this.lblNomeJogador2.Name = "lblNomeJogador2";
            this.lblNomeJogador2.Size = new System.Drawing.Size(187, 29);
            this.lblNomeJogador2.TabIndex = 16;
            this.lblNomeJogador2.Text = "aaaaa";
            // 
            // frmPlacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(651, 637);
            this.Controls.Add(this.lblNomeJogador2);
            this.Controls.Add(this.lblNomeJogador1);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFotoJogador2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picFotoJogador1);
            this.Controls.Add(this.btSair);
            this.Name = "frmPlacar";
            this.Text = "Placar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCarregaFoto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox picFotoJogador1;
        private System.Windows.Forms.OpenFileDialog openFDFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFotoJogador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Label lblNomeJogador1;
        private System.Windows.Forms.Label lblNomeJogador2;
    }
}

