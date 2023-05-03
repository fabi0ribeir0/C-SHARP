namespace Foreach
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnForeach = new System.Windows.Forms.Button();
            this.btnForeach2 = new System.Windows.Forms.Button();
            this.btnNome = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(29, 25);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(316, 355);
            this.lista.TabIndex = 0;
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(2, 386);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(75, 23);
            this.btnForeach.TabIndex = 1;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // btnForeach2
            // 
            this.btnForeach2.Location = new System.Drawing.Point(132, 386);
            this.btnForeach2.Name = "btnForeach2";
            this.btnForeach2.Size = new System.Drawing.Size(75, 23);
            this.btnForeach2.TabIndex = 2;
            this.btnForeach2.Text = "Foreach2";
            this.btnForeach2.UseVisualStyleBackColor = true;
            this.btnForeach2.Click += new System.EventHandler(this.btnForeach2_Click);
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(270, 423);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(75, 23);
            this.btnNome.TabIndex = 3;
            this.btnNome.Text = "Nome?";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(164, 423);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 458);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.btnForeach2);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnForeach;
        private System.Windows.Forms.Button btnForeach2;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}

