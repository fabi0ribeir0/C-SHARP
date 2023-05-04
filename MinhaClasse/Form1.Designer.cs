namespace MinhaClasse
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNascionalidade = new System.Windows.Forms.Label();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(313, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(16, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "...";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(31, 111);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(16, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "...";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(31, 187);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(16, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "...";
            // 
            // lblNascionalidade
            // 
            this.lblNascionalidade.AutoSize = true;
            this.lblNascionalidade.Location = new System.Drawing.Point(31, 274);
            this.lblNascionalidade.Name = "lblNascionalidade";
            this.lblNascionalidade.Size = new System.Drawing.Size(16, 13);
            this.lblNascionalidade.TabIndex = 4;
            this.lblNascionalidade.Text = "...";
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(34, 410);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(313, 23);
            this.btnMetodo.TabIndex = 5;
            this.btnMetodo.Text = "Metodo";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.Location = new System.Drawing.Point(34, 451);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(313, 23);
            this.btnMetodo2.TabIndex = 6;
            this.btnMetodo2.Text = "Metodo2";
            this.btnMetodo2.UseVisualStyleBackColor = true;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 486);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.lblNascionalidade);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNascionalidade;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnMetodo2;
    }
}

