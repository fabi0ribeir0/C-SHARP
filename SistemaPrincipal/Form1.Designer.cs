namespace SistemaPrincipal
{
    partial class Form1
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
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.Nota1 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.Nota4 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.Nota3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(81, 12);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(187, 115);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 5;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(39, 15);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(36, 13);
            this.Nota1.TabIndex = 6;
            this.Nota1.Text = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(39, 41);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(36, 13);
            this.Nota2.TabIndex = 7;
            this.Nota2.Text = "Nota2";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(81, 38);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 2;
            // 
            // Nota4
            // 
            this.Nota4.AutoSize = true;
            this.Nota4.Location = new System.Drawing.Point(39, 93);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(36, 13);
            this.Nota4.TabIndex = 9;
            this.Nota4.Text = "Nota4";
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(81, 90);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 4;
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(39, 67);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(36, 13);
            this.Nota3.TabIndex = 8;
            this.Nota3.Text = "Nota3";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(81, 64);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 3;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(39, 119);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "Média";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(81, 116);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Situação:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSituacao.Location = new System.Drawing.Point(93, 170);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 20);
            this.lblSituacao.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 212);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.Nota4);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.Nota1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtNota1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Label Nota2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label Nota4;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label Nota3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSituacao;
    }
}

