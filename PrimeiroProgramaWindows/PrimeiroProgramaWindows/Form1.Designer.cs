using System;

namespace PrimeiroProgramaWindows
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.txbNota3 = new System.Windows.Forms.TextBox();
            this.txbNota4 = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnCalculaMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(8, 35);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(8, 61);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(8, 87);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 3;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(8, 113);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(39, 13);
            this.lblNota4.TabIndex = 4;
            this.lblNota4.Text = "Nota 4";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(53, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(384, 20);
            this.txbNome.TabIndex = 5;
            // 
            // txbNota1
            // 
            this.txbNota1.Location = new System.Drawing.Point(53, 32);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(100, 20);
            this.txbNota1.TabIndex = 6;
            // 
            // txbNota2
            // 
            this.txbNota2.Location = new System.Drawing.Point(53, 58);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(100, 20);
            this.txbNota2.TabIndex = 7;
            // 
            // txbNota3
            // 
            this.txbNota3.Location = new System.Drawing.Point(53, 84);
            this.txbNota3.Name = "txbNota3";
            this.txbNota3.Size = new System.Drawing.Size(100, 20);
            this.txbNota3.TabIndex = 8;
            // 
            // txbNota4
            // 
            this.txbNota4.Location = new System.Drawing.Point(53, 110);
            this.txbNota4.Name = "txbNota4";
            this.txbNota4.Size = new System.Drawing.Size(100, 20);
            this.txbNota4.TabIndex = 9;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(49, 138);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(57, 20);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "Média";
            // 
            // btnCalculaMedia
            // 
            this.btnCalculaMedia.Location = new System.Drawing.Point(53, 165);
            this.btnCalculaMedia.Name = "btnCalculaMedia";
            this.btnCalculaMedia.Size = new System.Drawing.Size(100, 31);
            this.btnCalculaMedia.TabIndex = 11;
            this.btnCalculaMedia.Text = "Calcular Média";
            this.btnCalculaMedia.UseVisualStyleBackColor = true;
            this.btnCalculaMedia.Click += new System.EventHandler(this.btnCalculaMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 209);
            this.Controls.Add(this.btnCalculaMedia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txbNota4);
            this.Controls.Add(this.txbNota3);
            this.Controls.Add(this.txbNota2);
            this.Controls.Add(this.txbNota1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Média Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbNota1;
        private System.Windows.Forms.TextBox txbNota2;
        private System.Windows.Forms.TextBox txbNota3;
        private System.Windows.Forms.TextBox txbNota4;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnCalculaMedia;
    }
}

