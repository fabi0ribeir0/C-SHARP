namespace ClasseAbstrataEncapsulada
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
            this.rdSuco = new System.Windows.Forms.RadioButton();
            this.rdTV = new System.Windows.Forms.RadioButton();
            this.rdRadio = new System.Windows.Forms.RadioButton();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(95, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdSuco
            // 
            this.rdSuco.AutoSize = true;
            this.rdSuco.Checked = true;
            this.rdSuco.Location = new System.Drawing.Point(30, 41);
            this.rdSuco.Name = "rdSuco";
            this.rdSuco.Size = new System.Drawing.Size(50, 17);
            this.rdSuco.TabIndex = 1;
            this.rdSuco.TabStop = true;
            this.rdSuco.Text = "Suco";
            this.rdSuco.UseVisualStyleBackColor = true;
            // 
            // rdTV
            // 
            this.rdTV.AutoSize = true;
            this.rdTV.Location = new System.Drawing.Point(30, 78);
            this.rdTV.Name = "rdTV";
            this.rdTV.Size = new System.Drawing.Size(39, 17);
            this.rdTV.TabIndex = 2;
            this.rdTV.Text = "TV";
            this.rdTV.UseVisualStyleBackColor = true;
            // 
            // rdRadio
            // 
            this.rdRadio.AutoSize = true;
            this.rdRadio.Location = new System.Drawing.Point(30, 122);
            this.rdRadio.Name = "rdRadio";
            this.rdRadio.Size = new System.Drawing.Size(53, 17);
            this.rdRadio.TabIndex = 3;
            this.rdRadio.Text = "Radio";
            this.rdRadio.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(30, 168);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(126, 20);
            this.txtPreco.TabIndex = 4;
            this.txtPreco.Text = " ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 368);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.rdRadio);
            this.Controls.Add(this.rdTV);
            this.Controls.Add(this.rdSuco);
            this.Controls.Add(this.btnOK);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulo x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdSuco;
        private System.Windows.Forms.RadioButton rdTV;
        private System.Windows.Forms.RadioButton rdRadio;
        private System.Windows.Forms.TextBox txtPreco;
    }
}

