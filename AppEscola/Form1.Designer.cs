namespace AppEscola
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.nudNota1 = new System.Windows.Forms.NumericUpDown();
            this.nudNota2 = new System.Windows.Forms.NumericUpDown();
            this.nudNota4 = new System.Windows.Forms.NumericUpDown();
            this.nudNota3 = new System.Windows.Forms.NumericUpDown();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblnada = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNome.Location = new System.Drawing.Point(154, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(28, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "...";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(474, 12);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(105, 20);
            this.dtData.TabIndex = 2;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(12, 126);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(67, 20);
            this.lblNota1.TabIndex = 3;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(12, 176);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(67, 20);
            this.lblNota2.TabIndex = 4;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota4.Location = new System.Drawing.Point(12, 276);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(67, 20);
            this.lblNota4.TabIndex = 6;
            this.lblNota4.Text = "Nota 4:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(12, 226);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(67, 20);
            this.lblNota3.TabIndex = 5;
            this.lblNota3.Text = "Nota 3:";
            // 
            // nudNota1
            // 
            this.nudNota1.DecimalPlaces = 1;
            this.nudNota1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNota1.Location = new System.Drawing.Point(86, 126);
            this.nudNota1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota1.Name = "nudNota1";
            this.nudNota1.Size = new System.Drawing.Size(62, 20);
            this.nudNota1.TabIndex = 0;
            // 
            // nudNota2
            // 
            this.nudNota2.DecimalPlaces = 1;
            this.nudNota2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNota2.Location = new System.Drawing.Point(86, 176);
            this.nudNota2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota2.Name = "nudNota2";
            this.nudNota2.Size = new System.Drawing.Size(62, 20);
            this.nudNota2.TabIndex = 1;
            // 
            // nudNota4
            // 
            this.nudNota4.DecimalPlaces = 1;
            this.nudNota4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNota4.Location = new System.Drawing.Point(86, 276);
            this.nudNota4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota4.Name = "nudNota4";
            this.nudNota4.Size = new System.Drawing.Size(62, 20);
            this.nudNota4.TabIndex = 3;
            // 
            // nudNota3
            // 
            this.nudNota3.DecimalPlaces = 1;
            this.nudNota3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNota3.Location = new System.Drawing.Point(86, 226);
            this.nudNota3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota3.Name = "nudNota3";
            this.nudNota3.Size = new System.Drawing.Size(62, 20);
            this.nudNota3.TabIndex = 2;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(73, 317);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(103, 356);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(20, 18);
            this.lblMedia.TabIndex = 14;
            this.lblMedia.Text = "...";
            // 
            // lblnada
            // 
            this.lblnada.AutoSize = true;
            this.lblnada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnada.Location = new System.Drawing.Point(12, 354);
            this.lblnada.Name = "lblnada";
            this.lblnada.Size = new System.Drawing.Size(62, 20);
            this.lblnada.TabIndex = 13;
            this.lblnada.Text = "Média:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(103, 412);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(24, 20);
            this.lblSituacao.TabIndex = 16;
            this.lblSituacao.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Situação:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 469);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblnada);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.nudNota4);
            this.Controls.Add(this.nudNota3);
            this.Controls.Add(this.nudNota2);
            this.Controls.Add(this.nudNota1);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escola";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.NumericUpDown nudNota1;
        private System.Windows.Forms.NumericUpDown nudNota2;
        private System.Windows.Forms.NumericUpDown nudNota4;
        private System.Windows.Forms.NumericUpDown nudNota3;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblnada;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label label3;
    }
}

