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
            lblTitulo = new Label();
            lblSolicitante = new Label();
            lblTipoDocumento = new Label();
            lblFechaRecepcion = new Label();
            lblMotivo = new Label();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            btnVolver = new Button();
            cmbTipoDocumento = new ComboBox();
            dtpFechaRecepcion = new DateTimePicker();
            textSolicitante = new TextBox();
            textMotivo = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(81, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "REGISTRO DE EXPEDIENTES";
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Location = new Point(38, 100);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(131, 15);
            lblSolicitante.TabIndex = 2;
            lblSolicitante.Text = "Nombre del Solicitante:";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(38, 139);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(115, 15);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo de Documento:";
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new Point(38, 180);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(115, 15);
            lblFechaRecepcion.TabIndex = 4;
            lblFechaRecepcion.Text = "Fecha de Recepción:";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(38, 223);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(113, 15);
            lblMotivo.TabIndex = 5;
            lblMotivo.Text = "Motivo de Solicitud:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(34, 401);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 46);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(168, 401);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(113, 46);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(300, 401);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 46);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver Atrás";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.Font = new Font("Times New Roman", 12F);
            cmbTipoDocumento.ForeColor = Color.DimGray;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "Solicitud de matrícula", "Solicitud de traslado", "Constancia de estudios", "Justificación de inasistencia", "Autorización de recojo de menor", "Otro" });
            cmbTipoDocumento.Location = new Point(231, 133);
            cmbTipoDocumento.Margin = new Padding(4, 3, 4, 3);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(180, 27);
            cmbTipoDocumento.TabIndex = 14;
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Font = new Font("Times New Roman", 12F);
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(229, 171);
            dtpFechaRecepcion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(182, 26);
            dtpFechaRecepcion.TabIndex = 15;
            // 
            // textSolicitante
            // 
            textSolicitante.Font = new Font("Times New Roman", 12F);
            textSolicitante.Location = new Point(231, 94);
            textSolicitante.Margin = new Padding(4, 3, 4, 3);
            textSolicitante.Name = "textSolicitante";
            textSolicitante.Size = new Size(180, 26);
            textSolicitante.TabIndex = 16;
            // 
            // textMotivo
            // 
            textMotivo.Font = new Font("Times New Roman", 12F);
            textMotivo.Location = new Point(38, 257);
            textMotivo.Margin = new Padding(4, 3, 4, 3);
            textMotivo.Multiline = true;
            textMotivo.Name = "textMotivo";
            textMotivo.ScrollBars = ScrollBars.Vertical;
            textMotivo.Size = new Size(373, 123);
            textMotivo.TabIndex = 17;
            // 
            // FrmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 489);
            Controls.Add(textMotivo);
            Controls.Add(textSolicitante);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblMotivo);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(lblTipoDocumento);
            Controls.Add(lblSolicitante);
            Controls.Add(lblTitulo);
            Name = "FrmRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSolicitante;
        private Label lblTipoDocumento;
        private Label lblFechaRecepcion;
        private Label lblMotivo;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnVolver;
        private ComboBox cmbTipoDocumento;
        private DateTimePicker dtpFechaRecepcion;
        private TextBox textSolicitante;
        private TextBox textMotivo;
    }
}