namespace Banco
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
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.BackColor = System.Drawing.Color.Firebrick;
            this.btnTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnTransferencia.Location = new System.Drawing.Point(134, 279);
            this.btnTransferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(123, 54);
            this.btnTransferencia.TabIndex = 0;
            this.btnTransferencia.Text = "Transferir";
            this.btnTransferencia.UseVisualStyleBackColor = false;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnPix
            // 
            this.btnPix.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPix.ForeColor = System.Drawing.Color.White;
            this.btnPix.Location = new System.Drawing.Point(392, 279);
            this.btnPix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(123, 54);
            this.btnPix.TabIndex = 1;
            this.btnPix.Text = "Pix";
            this.btnPix.UseVisualStyleBackColor = false;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.Location = new System.Drawing.Point(392, 384);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 35);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Banco.Properties.Resources.transferencia;
            this.pictureBox1.Location = new System.Drawing.Point(90, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Banco.Properties.Resources.pix;
            this.pictureBox2.Location = new System.Drawing.Point(353, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(58, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(527, 399);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Banco.Properties.Resources.dinheiro__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 487);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnPix;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}