namespace MesaDePartesDigital
{
    partial class FrmBuscar
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
            lblNumero = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblResultado = new Label();
            lblDatosExpediente = new Label();
            btnVolver = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblNumero.ForeColor = SystemColors.HotTrack;
            lblNumero.Location = new Point(29, 66);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(158, 19);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Código de expediente:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Times New Roman", 12F);
            txtBuscar.Location = new Point(29, 93);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(193, 26);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.CornflowerBlue;
            btnBuscar.Font = new Font("Times New Roman", 12F);
            btnBuscar.ForeColor = SystemColors.Info;
            btnBuscar.Location = new Point(246, 93);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(122, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(29, 141);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(185, 19);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado de la búsqueda:";
            // 
            // lblDatosExpediente
            // 
            lblDatosExpediente.BackColor = SystemColors.Window;
            lblDatosExpediente.BorderStyle = BorderStyle.FixedSingle;
            lblDatosExpediente.Font = new Font("Times New Roman", 12F);
            lblDatosExpediente.Location = new Point(29, 169);
            lblDatosExpediente.Name = "lblDatosExpediente";
            lblDatosExpediente.Size = new Size(339, 147);
            lblDatosExpediente.TabIndex = 4;
            lblDatosExpediente.Text = "Aquí aparecerán los datos del expediente.";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.Font = new Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Info;
            btnVolver.Location = new Point(157, 346);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(211, 36);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver al menú principal";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(53, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(290, 22);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "BUSCADOR DE EXPEDIENTES";
            // 
            // FrmBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(404, 408);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Controls.Add(lblDatosExpediente);
            Controls.Add(lblResultado);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblNumero);
            Name = "FrmBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar expediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label lblResultado;
        private Label lblDatosExpediente;
        private Button btnVolver;
        private Label lblTitulo;
    }
}