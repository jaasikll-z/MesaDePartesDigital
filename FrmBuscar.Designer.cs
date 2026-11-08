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
            lblDatosExpediente = new Label();
            textBuscar = new TextBox();
            lblTitulo = new Label();
            lblNumero = new Label();
            btnBuscar = new Button();
            lblResultado = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblDatosExpediente
            // 
            lblDatosExpediente.BackColor = SystemColors.Window;
            lblDatosExpediente.BorderStyle = BorderStyle.FixedSingle;
            lblDatosExpediente.Font = new Font("Times New Roman", 12F);
            lblDatosExpediente.Location = new Point(26, 202);
            lblDatosExpediente.Name = "lblDatosExpediente";
            lblDatosExpediente.Size = new Size(339, 147);
            lblDatosExpediente.TabIndex = 6;
            lblDatosExpediente.Text = "Aquí aparecerán los datos del expediente.";
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Times New Roman", 12F);
            textBuscar.Location = new Point(26, 126);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(193, 26);
            textBuscar.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(52, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 30);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "BUSCADOR DE EXPEDIENTES";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(26, 99);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(126, 15);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Código de expediente:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(252, 126);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 26);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(26, 174);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(145, 15);
            lblResultado.TabIndex = 15;
            lblResultado.Text = "Resultado de la búsqueda:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(118, 370);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(169, 46);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver Atrás";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 445);
            Controls.Add(btnVolver);
            Controls.Add(lblResultado);
            Controls.Add(btnBuscar);
            Controls.Add(lblNumero);
            Controls.Add(lblTitulo);
            Controls.Add(lblDatosExpediente);
            Controls.Add(textBuscar);
            Name = "FrmBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosExpediente;
        private TextBox textBuscar;
        private Label lblTitulo;
        private Label lblNumero;
        private Button btnBuscar;
        private Label lblResultado;
        private Button btnVolver;
    }
}