namespace CalculadoraLP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtBxValor1 = new System.Windows.Forms.TextBox();
            this.txtBxValor2 = new System.Windows.Forms.TextBox();
            this.txtBxResultado = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(42, 302);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 20);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(379, 52);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(379, 157);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 29);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(37, 239);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(94, 29);
            this.btnSoma.TabIndex = 3;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(167, 239);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(94, 29);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(318, 239);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(94, 29);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(450, 239);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(94, 29);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtBxValor1
            // 
            this.txtBxValor1.Location = new System.Drawing.Point(121, 53);
            this.txtBxValor1.Name = "txtBxValor1";
            this.txtBxValor1.Size = new System.Drawing.Size(125, 27);
            this.txtBxValor1.TabIndex = 7;
            // 
            // txtBxValor2
            // 
            this.txtBxValor2.Location = new System.Drawing.Point(121, 157);
            this.txtBxValor2.Name = "txtBxValor2";
            this.txtBxValor2.Size = new System.Drawing.Size(125, 27);
            this.txtBxValor2.TabIndex = 8;
            // 
            // txtBxResultado
            // 
            this.txtBxResultado.Location = new System.Drawing.Point(136, 299);
            this.txtBxResultado.Name = "txtBxResultado";
            this.txtBxResultado.Size = new System.Drawing.Size(125, 27);
            this.txtBxResultado.TabIndex = 9;
            this.txtBxResultado.TextChanged += new System.EventHandler(this.txtBxResultado_TextChanged);
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(42, 56);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(58, 20);
            this.lblValor1.TabIndex = 10;
            this.lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(42, 157);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(58, 20);
            this.lblValor2.TabIndex = 11;
            this.lblValor2.Text = "Valor 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 451);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtBxResultado);
            this.Controls.Add(this.txtBxValor2);
            this.Controls.Add(this.txtBxValor1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResultado;
        private Button btnLimpar;
        private Button btnSair;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private TextBox txtBxValor1;
        private TextBox txtBxValor2;
        private TextBox txtBxResultado;
        private Label lblValor1;
        private Label lblValor2;
    }
}