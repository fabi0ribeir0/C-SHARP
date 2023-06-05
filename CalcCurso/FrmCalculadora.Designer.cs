namespace CalcCurso
{
    partial class FrmCalculadora
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
            this.txtTela = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnUMX = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTela
            // 
            this.txtTela.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTela.Location = new System.Drawing.Point(9, 12);
            this.txtTela.Multiline = true;
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(302, 119);
            this.txtTela.TabIndex = 0;
            this.txtTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTela_KeyPress);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(12, 361);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(106, 50);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 305);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 249);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 193);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(12, 137);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "🠔";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(68, 137);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 9;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(68, 193);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(68, 249);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(68, 305);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(124, 137);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(124, 193);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(124, 249);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(124, 305);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(200, 137);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(50, 50);
            this.btnMaisMenos.TabIndex = 18;
            this.btnMaisMenos.Text = "±";
            this.btnMaisMenos.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(200, 193);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 50);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(200, 249);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(50, 50);
            this.btnMult.TabIndex = 16;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(200, 305);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 50);
            this.btnSub.TabIndex = 15;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(200, 361);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(50, 50);
            this.btnSoma.TabIndex = 14;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(256, 137);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(50, 50);
            this.btnRaiz.TabIndex = 21;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.Location = new System.Drawing.Point(256, 193);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(50, 50);
            this.btnPorcentagem.TabIndex = 20;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            // 
            // btnUMX
            // 
            this.btnUMX.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUMX.Location = new System.Drawing.Point(256, 249);
            this.btnUMX.Name = "btnUMX";
            this.btnUMX.Size = new System.Drawing.Size(50, 50);
            this.btnUMX.TabIndex = 19;
            this.btnUMX.Text = "1\\x";
            this.btnUMX.UseVisualStyleBackColor = true;
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(124, 361);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(50, 50);
            this.btnVirgula.TabIndex = 22;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(256, 305);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 106);
            this.button23.TabIndex = 23;
            this.button23.Text = "=";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 429);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnUMX);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.txtTela);
            this.Name = "FrmCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnUMX;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button button23;
    }
}

