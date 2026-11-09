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
            lblTitulo = new Label();
            btnVolver = new Button();
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
            dgvExpedientes.Location = new Point(22, 95);
            dgvExpedientes.Name = "dgvExpedientes";
            dgvExpedientes.ReadOnly = true;
            dgvExpedientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpedientes.Size = new Size(620, 260);
            dgvExpedientes.TabIndex = 2;
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(138, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(390, 30);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "LISTA DE EXPEDIENTES REGISTRADOS";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(215, 378);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(214, 46);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver Atrás";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(dgvExpedientes);
            Name = "FrmConsultar";
            Text = "FrmConsultar";
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
        private Label lblTitulo;
        private Button btnVolver;
    }
}