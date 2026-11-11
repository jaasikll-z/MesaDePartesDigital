namespace MesaDePartesDigital
{
    partial class FrmEditar
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
            lblCodigo = new Label();
            textCodigo = new TextBox();
            lblSolicitante = new Label();
            lblErrorSolicitante = new Label();
            textSolicitante = new TextBox();
            lblTipoDocumento = new Label();
            lblErrorTipo = new Label();
            cmbTipoDocumento = new ComboBox();
            lblFechaRecepcion = new Label();
            lblErrorFecha = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            lblMotivo = new Label();
            lblErrorMotivo = new Label();
            textMotivo = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(123, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "EDITAR EXPEDIENTE";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCodigo.ForeColor = SystemColors.HotTrack;
            lblCodigo.Location = new Point(24, 55);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(158, 19);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código de expediente:";
            // 
            // textCodigo
            // 
            textCodigo.BackColor = SystemColors.ControlLight;
            textCodigo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textCodigo.Location = new Point(208, 52);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(244, 26);
            textCodigo.TabIndex = 2;
            textCodigo.TabStop = false;
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSolicitante.ForeColor = SystemColors.HotTrack;
            lblSolicitante.Location = new Point(24, 95);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(164, 19);
            lblSolicitante.TabIndex = 3;
            lblSolicitante.Text = "Nombre del solicitante:";
            // 
            // lblErrorSolicitante
            // 
            lblErrorSolicitante.AutoSize = true;
            lblErrorSolicitante.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblErrorSolicitante.ForeColor = Color.Red;
            lblErrorSolicitante.Location = new Point(208, 121);
            lblErrorSolicitante.Name = "lblErrorSolicitante";
            lblErrorSolicitante.Size = new Size(218, 15);
            lblErrorSolicitante.TabIndex = 13;
            lblErrorSolicitante.Text = "Ingrese un nombre válido (mín. 3 letras).";
            lblErrorSolicitante.Visible = false;
            // 
            // textSolicitante
            // 
            textSolicitante.Font = new Font("Times New Roman", 12F);
            textSolicitante.Location = new Point(208, 92);
            textSolicitante.Name = "textSolicitante";
            textSolicitante.Size = new Size(244, 26);
            textSolicitante.TabIndex = 4;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTipoDocumento.ForeColor = SystemColors.HotTrack;
            lblTipoDocumento.Location = new Point(24, 142);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(140, 19);
            lblTipoDocumento.TabIndex = 5;
            lblTipoDocumento.Text = "Tipo de documento:";
            // 
            // lblErrorTipo
            // 
            lblErrorTipo.AutoSize = true;
            lblErrorTipo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblErrorTipo.ForeColor = Color.Red;
            lblErrorTipo.Location = new Point(208, 170);
            lblErrorTipo.Name = "lblErrorTipo";
            lblErrorTipo.Size = new Size(180, 15);
            lblErrorTipo.TabIndex = 14;
            lblErrorTipo.Text = "Seleccione un tipo de documento.";
            lblErrorTipo.Visible = false;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.Font = new Font("Times New Roman", 12F);
            cmbTipoDocumento.ForeColor = Color.DimGray;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Items.AddRange(new object[] { "Solicitud de matrícula", "Solicitud de traslado", "Constancia de estudios", "Justificación de inasistencia", "Autorización de recojo de menor", "Otro" });
            cmbTipoDocumento.Location = new Point(207, 139);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(245, 27);
            cmbTipoDocumento.TabIndex = 6;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFechaRecepcion.ForeColor = SystemColors.HotTrack;
            lblFechaRecepcion.Location = new Point(24, 192);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(142, 19);
            lblFechaRecepcion.TabIndex = 7;
            lblFechaRecepcion.Text = "Fecha de recepción:";
            // 
            // lblErrorFecha
            // 
            lblErrorFecha.AutoSize = true;
            lblErrorFecha.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblErrorFecha.ForeColor = Color.Red;
            lblErrorFecha.Location = new Point(208, 218);
            lblErrorFecha.Name = "lblErrorFecha";
            lblErrorFecha.Size = new Size(161, 15);
            lblErrorFecha.TabIndex = 15;
            lblErrorFecha.Text = "La fecha no puede ser futura.";
            lblErrorFecha.Visible = false;
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Font = new Font("Times New Roman", 12F);
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(208, 188);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(245, 26);
            dtpFechaRecepcion.TabIndex = 8;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblMotivo.ForeColor = SystemColors.HotTrack;
            lblMotivo.Location = new Point(24, 239);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(158, 19);
            lblMotivo.TabIndex = 9;
            lblMotivo.Text = "Motivo de la solicitud:";
            // 
            // lblErrorMotivo
            // 
            lblErrorMotivo.AutoSize = true;
            lblErrorMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblErrorMotivo.ForeColor = Color.Red;
            lblErrorMotivo.Location = new Point(188, 242);
            lblErrorMotivo.Name = "lblErrorMotivo";
            lblErrorMotivo.Size = new Size(227, 15);
            lblErrorMotivo.TabIndex = 16;
            lblErrorMotivo.Text = "Describa el motivo (mínimo 10 caracteres).";
            lblErrorMotivo.Visible = false;
            // 
            // textMotivo
            // 
            textMotivo.Font = new Font("Times New Roman", 12F);
            textMotivo.Location = new Point(24, 265);
            textMotivo.Multiline = true;
            textMotivo.Name = "textMotivo";
            textMotivo.ScrollBars = ScrollBars.Vertical;
            textMotivo.Size = new Size(428, 110);
            textMotivo.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.Font = new Font("Rockwell", 11.25F, FontStyle.Italic);
            btnGuardar.ForeColor = SystemColors.Info;
            btnGuardar.Location = new Point(24, 404);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.CornflowerBlue;
            btnCancelar.Font = new Font("Rockwell", 11.25F, FontStyle.Italic);
            btnCancelar.ForeColor = SystemColors.Info;
            btnCancelar.Location = new Point(263, 404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(190, 50);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(480, 485);
            Controls.Add(lblErrorMotivo);
            Controls.Add(lblErrorFecha);
            Controls.Add(lblErrorTipo);
            Controls.Add(lblErrorSolicitante);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(textMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(dtpFechaRecepcion);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(textSolicitante);
            Controls.Add(lblSolicitante);
            Controls.Add(textCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblTitulo);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar expediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigo;
        private TextBox textCodigo;
        private Label lblSolicitante;
        private TextBox textSolicitante;
        private Label lblTipoDocumento;
        private ComboBox cmbTipoDocumento;
        private Label lblFechaRecepcion;
        private DateTimePicker dtpFechaRecepcion;
        private Label lblMotivo;
        private TextBox textMotivo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblErrorSolicitante;
        private Label lblErrorTipo;
        private Label lblErrorFecha;
        private Label lblErrorMotivo;
    }
}
