namespace ColecaoArrays
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
            this.lstQuadro = new System.Windows.Forms.ListBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.numUD1 = new System.Windows.Forms.NumericUpDown();
            this.numUD2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(12, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "FOR";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstQuadro
            // 
            this.lstQuadro.FormattingEnabled = true;
            this.lstQuadro.Location = new System.Drawing.Point(12, 12);
            this.lstQuadro.Name = "lstQuadro";
            this.lstQuadro.Size = new System.Drawing.Size(273, 303);
            this.lstQuadro.TabIndex = 2;
            // 
            // btnTeste
            // 
            this.btnTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeste.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTeste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTeste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeste.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(93, 321);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(96, 25);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "FOREACH";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSoma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(190, 384);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(96, 25);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // numUD1
            // 
            this.numUD1.Location = new System.Drawing.Point(57, 389);
            this.numUD1.Name = "numUD1";
            this.numUD1.Size = new System.Drawing.Size(32, 20);
            this.numUD1.TabIndex = 6;
            this.numUD1.Maximum = 6;
            // 
            // numUD2
            // 
            this.numUD2.Location = new System.Drawing.Point(152, 389);
            this.numUD2.Name = "numUD2";
            this.numUD2.Size = new System.Drawing.Size(32, 20);
            this.numUD2.TabIndex = 7;
            this.numUD2.Maximum = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Indice1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Indice2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD2);
            this.Controls.Add(this.numUD1);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lstQuadro);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrays";
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstQuadro;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.NumericUpDown numUD1;
        private System.Windows.Forms.NumericUpDown numUD2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

