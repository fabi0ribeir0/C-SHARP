namespace Controles
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
            this.btnMensagem = new System.Windows.Forms.Button();
            this.chbAtivaBotao = new System.Windows.Forms.CheckBox();
            this.chlItens = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMensagem.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnMensagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMensagem.FlatAppearance.BorderSize = 3;
            this.btnMensagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensagem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.ForeColor = System.Drawing.Color.Yellow;
            this.btnMensagem.Location = new System.Drawing.Point(314, 57);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(130, 50);
            this.btnMensagem.TabIndex = 0;
            this.btnMensagem.Text = "Novo Item";
            this.btnMensagem.UseVisualStyleBackColor = false;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // chbAtivaBotao
            // 
            this.chbAtivaBotao.AutoSize = true;
            this.chbAtivaBotao.Checked = true;
            this.chbAtivaBotao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAtivaBotao.Location = new System.Drawing.Point(144, 77);
            this.chbAtivaBotao.Name = "chbAtivaBotao";
            this.chbAtivaBotao.Size = new System.Drawing.Size(143, 17);
            this.chbAtivaBotao.TabIndex = 1;
            this.chbAtivaBotao.Text = "Ativa / Desativa o Botão";
            this.chbAtivaBotao.UseVisualStyleBackColor = true;
            this.chbAtivaBotao.CheckedChanged += new System.EventHandler(this.chbAtivaBotao_CheckedChanged);
            // 
            // chlItens
            // 
            this.chlItens.CheckOnClick = true;
            this.chlItens.FormattingEnabled = true;
            this.chlItens.Items.AddRange(new object[] {
            "1 - João",
            "2 - Maria",
            "3 - Sara",
            "4 - Marcia"});
            this.chlItens.Location = new System.Drawing.Point(144, 168);
            this.chlItens.Name = "chlItens";
            this.chlItens.Size = new System.Drawing.Size(312, 124);
            this.chlItens.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.chlItens);
            this.Controls.Add(this.chbAtivaBotao);
            this.Controls.Add(this.btnMensagem);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.CheckBox chbAtivaBotao;
        private System.Windows.Forms.CheckedListBox chlItens;
    }
}

