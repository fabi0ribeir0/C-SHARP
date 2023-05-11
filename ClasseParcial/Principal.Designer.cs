namespace ClasseParcial
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
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(49, 398);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(75, 23);
            this.btnB1.TabIndex = 0;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(206, 398);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(75, 23);
            this.btnB2.TabIndex = 1;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
    }
}

