namespace pryVegaEjercitacionIg
{
    partial class frmCaso2
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
            lblNúmero1 = new Label();
            lblNúmero2 = new Label();
            txtNúmero1 = new TextBox();
            txtNúmero2 = new TextBox();
            btnMultiplicar = new Button();
            btnSumar = new Button();
            btnRestar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblNúmero1
            // 
            lblNúmero1.AutoSize = true;
            lblNúmero1.Location = new Point(124, 97);
            lblNúmero1.Name = "lblNúmero1";
            lblNúmero1.Size = new Size(60, 15);
            lblNúmero1.TabIndex = 0;
            lblNúmero1.Text = "Número 1";
            // 
            // lblNúmero2
            // 
            lblNúmero2.AutoSize = true;
            lblNúmero2.Location = new Point(124, 134);
            lblNúmero2.Name = "lblNúmero2";
            lblNúmero2.Size = new Size(60, 15);
            lblNúmero2.TabIndex = 1;
            lblNúmero2.Text = "Número 2";
            // 
            // txtNúmero1
            // 
            txtNúmero1.Location = new Point(235, 94);
            txtNúmero1.Name = "txtNúmero1";
            txtNúmero1.Size = new Size(57, 23);
            txtNúmero1.TabIndex = 2;
            // 
            // txtNúmero2
            // 
            txtNúmero2.Location = new Point(235, 131);
            txtNúmero2.Name = "txtNúmero2";
            txtNúmero2.Size = new Size(57, 23);
            txtNúmero2.TabIndex = 3;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(52, 182);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 4;
            btnMultiplicar.Text = "( x )";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(151, 182);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "( + )";
            btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(256, 182);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 6;
            btnRestar.Text = "( - )";
            btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(355, 182);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "( % )";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(125, 234);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(213, 231);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 9;
            // 
            // frmCaso2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnMultiplicar);
            Controls.Add(txtNúmero2);
            Controls.Add(txtNúmero1);
            Controls.Add(lblNúmero2);
            Controls.Add(lblNúmero1);
            Name = "frmCaso2";
            Text = "Calculadora ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNúmero1;
        private Label lblNúmero2;
        private TextBox txtNúmero1;
        private TextBox txtNúmero2;
        private Button btnMultiplicar;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnDividir;
        private Label lblResultado;
        private TextBox txtResultado;
    }
}