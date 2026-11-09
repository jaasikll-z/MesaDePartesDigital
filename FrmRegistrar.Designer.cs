namespace MesaDePartesDigital
{
    partial class FrmRegistrar
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
            lblSolicitante = new Label();
            textSolicitante = new TextBox();
            lblTipoDocumento = new Label();
            cmbTipoDocumento = new ComboBox();
            lblFechaRecepcion = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblMotivo = new Label();
            textMotivo = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSolicitante.ForeColor = SystemColors.HotTrack;
            lblSolicitante.Location = new Point(36, 68);
            lblSolicitante.Margin = new Padding(4, 0, 4, 0);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(164, 19);
            lblSolicitante.TabIndex = 1;
            lblSolicitante.Text = "Nombre del solicitante:";
            // 
            // textSolicitante
            // 
            textSolicitante.Font = new Font("Times New Roman", 12F);
            textSolicitante.Location = new Point(220, 65);
            textSolicitante.Margin = new Padding(4, 3, 4, 3);
            textSolicitante.Name = "textSolicitante";
            textSolicitante.Size = new Size(244, 26);
            textSolicitante.TabIndex = 2;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTipoDocumento.ForeColor = SystemColors.HotTrack;
            lblTipoDocumento.Location = new Point(36, 115);
            lblTipoDocumento.Margin = new Padding(4, 0, 4, 0);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(140, 19);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo de documento:";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.Font = new Font("Times New Roman", 12F);
            cmbTipoDocumento.ForeColor = Color.DimGray;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "Solicitud de matrícula", "Solicitud de traslado", "Constancia de estudios", "Justificación de inasistencia", "Autorización de recojo de menor", "Otro" });
            cmbTipoDocumento.Location = new Point(219, 112);
            cmbTipoDocumento.Margin = new Padding(4, 3, 4, 3);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(245, 27);
            cmbTipoDocumento.TabIndex = 4;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFechaRecepcion.ForeColor = SystemColors.HotTrack;
            lblFechaRecepcion.Location = new Point(36, 164);
            lblFechaRecepcion.Margin = new Padding(4, 0, 4, 0);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(142, 19);
            lblFechaRecepcion.TabIndex = 5;
            lblFechaRecepcion.Text = "Fecha de recepción:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Font = new Font("Times New Roman", 12F);
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(220, 160);
            dtpFechaRecepcion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(245, 26);
            dtpFechaRecepcion.TabIndex = 6;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMotivo.ForeColor = SystemColors.HotTrack;
            lblMotivo.Location = new Point(36, 208);
            lblMotivo.Margin = new Padding(4, 0, 4, 0);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(158, 19);
            lblMotivo.TabIndex = 7;
            lblMotivo.Text = "Motivo de la solicitud:";
            // 
            // textMotivo
            // 
            textMotivo.Font = new Font("Times New Roman", 12F);
            textMotivo.Location = new Point(36, 241);
            textMotivo.Margin = new Padding(4, 3, 4, 3);
            textMotivo.Multiline = true;
            textMotivo.Name = "textMotivo";
            textMotivo.ScrollBars = ScrollBars.Vertical;
            textMotivo.Size = new Size(426, 101);
            textMotivo.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CornflowerBlue;
            btnRegistrar.Font = new Font("Rockwell", 11.25F, FontStyle.Italic);
            btnRegistrar.ForeColor = SystemColors.Info;
            btnRegistrar.Location = new Point(271, 367);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(191, 55);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar expediente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.CornflowerBlue;
            btnLimpiar.Font = new Font("Rockwell", 11.25F, FontStyle.Italic);
            btnLimpiar.ForeColor = SystemColors.Info;
            btnLimpiar.Location = new Point(36, 367);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(191, 55);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.Font = new Font("Rockwell", 11.25F, FontStyle.Italic);
            btnVolver.ForeColor = SystemColors.Info;
            btnVolver.Location = new Point(109, 442);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(278, 55);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver al menú principal";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(107, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(299, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE EXPENDIENTES";
            // 
            // FrmRegistrar
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(509, 522);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(textMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(textSolicitante);
            Controls.Add(lblSolicitante);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar expediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSolicitante;
        private TextBox textSolicitante;
        private Label lblTipoDocumento;
        private ComboBox cmbTipoDocumento;
        private Label lblFechaRecepcion;
        private DateTimePicker dtpFechaRecepcion;
        private Label lblMotivo;
        private TextBox textMotivo;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblTitulo;
    }
}