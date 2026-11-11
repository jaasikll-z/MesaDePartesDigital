namespace MesaDePartesDigital
{
    partial class FrmConsultar
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
            dgvExpedientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colSolicitante = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colMotivo = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            btnEditar = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).BeginInit();
            SuspendLayout();
            // 
            // dgvExpedientes
            // 
            dgvExpedientes.AllowUserToAddRows = false;
            dgvExpedientes.AllowUserToDeleteRows = false;
            dgvExpedientes.AllowUserToResizeRows = false;
            dgvExpedientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpedientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpedientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colSolicitante, colTipo, colFecha, colMotivo });
            dgvExpedientes.Location = new Point(22, 72);
            dgvExpedientes.Name = "dgvExpedientes";
            dgvExpedientes.ReadOnly = true;
            dgvExpedientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpedientes.Size = new Size(620, 260);
            dgvExpedientes.TabIndex = 1;
            // 
            // colCodigo
            // 
            colCodigo.FillWeight = 85F;
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colSolicitante
            // 
            colSolicitante.FillWeight = 115F;
            colSolicitante.HeaderText = "Solicitante";
            colSolicitante.Name = "colSolicitante";
            colSolicitante.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.FillWeight = 110F;
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.FillWeight = 90F;
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colMotivo
            // 
            colMotivo.FillWeight = 130F;
            colMotivo.HeaderText = "Motivo";
            colMotivo.Name = "colMotivo";
            colMotivo.ReadOnly = true;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.Font = new Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Info;
            btnVolver.Location = new Point(428, 351);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(214, 38);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al menú principal";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.CornflowerBlue;
            btnEditar.Font = new Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.Info;
            btnEditar.Location = new Point(22, 351);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(214, 38);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar expediente";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(144, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(382, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LISTA DE EXPEDIENTES REGISTRADOS";
            // 
            // FrmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(666, 413);
            Controls.Add(lblTitulo);
            Controls.Add(btnEditar);
            Controls.Add(btnVolver);
            Controls.Add(dgvExpedientes);
            Name = "FrmConsultar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar expedientes";
            Load += FrmConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvExpedientes;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colSolicitante;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colMotivo;
        private Button btnEditar;
        private Button btnVolver;
        private Label lblTitulo;
    }
}