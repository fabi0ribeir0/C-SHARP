namespace ClasseVirtual
{
    partial class Principal
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
            this.btnTeste1 = new System.Windows.Forms.Button();
            this.btnTeste2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeste1
            // 
            this.btnTeste1.Location = new System.Drawing.Point(61, 370);
            this.btnTeste1.Name = "btnTeste1";
            this.btnTeste1.Size = new System.Drawing.Size(75, 23);
            this.btnTeste1.TabIndex = 0;
            this.btnTeste1.Text = "Teste1";
            this.btnTeste1.UseVisualStyleBackColor = true;
            this.btnTeste1.Click += new System.EventHandler(this.btnTeste1_Click);
            // 
            // btnTeste2
            // 
            this.btnTeste2.Location = new System.Drawing.Point(230, 370);
            this.btnTeste2.Name = "btnTeste2";
            this.btnTeste2.Size = new System.Drawing.Size(75, 23);
            this.btnTeste2.TabIndex = 1;
            this.btnTeste2.Text = "Teste2";
            this.btnTeste2.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 479);
            this.Controls.Add(this.btnTeste2);
            this.Controls.Add(this.btnTeste1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeste1;
        private System.Windows.Forms.Button btnTeste2;
    }
}

