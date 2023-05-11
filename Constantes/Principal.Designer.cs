namespace Constantes
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btbStatic = new System.Windows.Forms.Button();
            this.lblRodape = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(121, 461);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btbStatic
            // 
            this.btbStatic.Location = new System.Drawing.Point(375, 461);
            this.btbStatic.Name = "btbStatic";
            this.btbStatic.Size = new System.Drawing.Size(75, 23);
            this.btbStatic.TabIndex = 1;
            this.btbStatic.Text = "Static";
            this.btbStatic.UseVisualStyleBackColor = true;
            this.btbStatic.Click += new System.EventHandler(this.btbStatic_Click);
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Location = new System.Drawing.Point(415, 510);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(35, 13);
            this.lblRodape.TabIndex = 2;
            this.lblRodape.Text = "label1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 532);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.btbStatic);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btbStatic;
        private System.Windows.Forms.Label lblRodape;
    }
}

