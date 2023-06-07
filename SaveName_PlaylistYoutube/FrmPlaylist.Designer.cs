namespace SaveName_PlaylistYoutube
{
    partial class FrmPlaylist
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
            this.txtPlaylistUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtrair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlaylistUrl
            // 
            this.txtPlaylistUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPlaylistUrl.Location = new System.Drawing.Point(12, 56);
            this.txtPlaylistUrl.Name = "txtPlaylistUrl";
            this.txtPlaylistUrl.Size = new System.Drawing.Size(443, 20);
            this.txtPlaylistUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL DA PLAYLIST";
            // 
            // btnExtrair
            // 
            this.btnExtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtrair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrair.Location = new System.Drawing.Point(12, 82);
            this.btnExtrair.Name = "btnExtrair";
            this.btnExtrair.Size = new System.Drawing.Size(70, 29);
            this.btnExtrair.TabIndex = 2;
            this.btnExtrair.Text = "Extrair";
            this.btnExtrair.UseVisualStyleBackColor = true;
            this.btnExtrair.Click += new System.EventHandler(this.btnExtrair_Click);
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 366);
            this.Controls.Add(this.btnExtrair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaylistUrl);
            this.Name = "FrmPlaylist";
            this.Text = "Baixa nomes da playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaylistUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtrair;
    }
}

