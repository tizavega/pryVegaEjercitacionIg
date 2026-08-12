namespace pryVegaEjercitacionIg
{
    partial class frmMiPresentacion
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblCarrera = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtCarrera = new TextBox();
            btnPresentacion = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(98, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(98, 128);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(98, 176);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(98, 217);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Carrera";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(180, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(180, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(180, 168);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(48, 23);
            txtEdad.TabIndex = 6;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(180, 214);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(145, 23);
            txtCarrera.TabIndex = 7;
            // 
            // btnPresentacion
            // 
            btnPresentacion.Location = new Point(109, 270);
            btnPresentacion.Name = "btnPresentacion";
            btnPresentacion.Size = new Size(156, 50);
            btnPresentacion.TabIndex = 8;
            btnPresentacion.Text = "Presentacion";
            btnPresentacion.UseVisualStyleBackColor = true;
            // 
            // frmMiPresentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPresentacion);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmMiPresentacion";
            Text = "Mi Presentacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblCarrera;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtCarrera;
        private Button btnPresentacion;
    }
}