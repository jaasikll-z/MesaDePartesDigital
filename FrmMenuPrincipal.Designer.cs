namespace MesaDePartesDigital
{
    partial class FrmMenuPrincipal
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
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnConsultar = new Button();
            msMenuPrincipal = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            itemGuardar = new ToolStripMenuItem();
            itemExportar = new ToolStripMenuItem();
            itemVerExpedientes = new ToolStripMenuItem();
            itemSalir = new ToolStripMenuItem();
            menuAyuda = new ToolStripMenuItem();
            itemManualUsuario = new ToolStripMenuItem();
            itemAcercaDe = new ToolStripMenuItem();
            lblTitulo = new Label();
            msMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CornflowerBlue;
            btnRegistrar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnRegistrar.ForeColor = SystemColors.Info;
            btnRegistrar.Location = new Point(54, 151);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(300, 45);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar expediente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.CornflowerBlue;
            btnBuscar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Info;
            btnBuscar.Location = new Point(54, 215);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(300, 45);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar expediente";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.CornflowerBlue;
            btnConsultar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnConsultar.ForeColor = SystemColors.Info;
            btnConsultar.Location = new Point(54, 278);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(300, 45);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar expedientes";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // msMenuPrincipal
            // 
            msMenuPrincipal.Items.AddRange(new ToolStripItem[] { menuArchivo, menuAyuda });
            msMenuPrincipal.Location = new Point(0, 0);
            msMenuPrincipal.Name = "msMenuPrincipal";
            msMenuPrincipal.Size = new Size(414, 24);
            msMenuPrincipal.TabIndex = 4;
            msMenuPrincipal.Text = "msMenuPrincipal";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { itemGuardar, itemExportar, itemVerExpedientes, itemSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(60, 20);
            menuArchivo.Text = "Archivo";
            // 
            // itemGuardar
            // 
            itemGuardar.Name = "itemGuardar";
            itemGuardar.Size = new Size(214, 22);
            itemGuardar.Text = "Guardar";
            itemGuardar.Click += itemGuardar_Click;
            // 
            // itemExportar
            // 
            itemExportar.Name = "itemExportar";
            itemExportar.Size = new Size(214, 22);
            itemExportar.Text = "Exportar reporte";
            itemExportar.Click += itemExportar_Click;
            // 
            // itemVerExpedientes
            // 
            itemVerExpedientes.Name = "itemVerExpedientes";
            itemVerExpedientes.Size = new Size(214, 22);
            itemVerExpedientes.Text = "Ver archivo de expedientes";
            itemVerExpedientes.Click += itemVerExpedientes_Click;
            // 
            // itemSalir
            // 
            itemSalir.Name = "itemSalir";
            itemSalir.Size = new Size(214, 22);
            itemSalir.Text = "Salir";
            itemSalir.Click += itemSalir_Click;
            // 
            // menuAyuda
            // 
            menuAyuda.DropDownItems.AddRange(new ToolStripItem[] { itemManualUsuario, itemAcercaDe });
            menuAyuda.Name = "menuAyuda";
            menuAyuda.Size = new Size(53, 20);
            menuAyuda.Text = "Ayuda";
            // 
            // itemManualUsuario
            // 
            itemManualUsuario.Name = "itemManualUsuario";
            itemManualUsuario.ShortcutKeys = Keys.F1;
            itemManualUsuario.Size = new Size(191, 22);
            itemManualUsuario.Text = "Manual de usuario";
            itemManualUsuario.Click += itemManualUsuario_Click;
            // 
            // itemAcercaDe
            // 
            itemAcercaDe.Name = "itemAcercaDe";
            itemAcercaDe.Size = new Size(191, 22);
            itemAcercaDe.Text = "Acerca de";
            itemAcercaDe.Click += itemAcercaDe_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(31, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(352, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MESA DE PARTES DIGITAL";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(414, 375);
            Controls.Add(lblTitulo);
            Controls.Add(btnConsultar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(msMenuPrincipal);
            MainMenuStrip = msMenuPrincipal;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesa de partes digital";
            FormClosing += FrmMenuPrincipal_FormClosing;
            msMenuPrincipal.ResumeLayout(false);
            msMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnConsultar;
        private MenuStrip msMenuPrincipal;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem itemGuardar;
        private ToolStripMenuItem itemSalir;
        private ToolStripMenuItem itemExportar;
        private ToolStripMenuItem menuAyuda;
        private ToolStripMenuItem itemAcercaDe;
        private ToolStripMenuItem itemVerExpedientes;
        private ToolStripMenuItem itemManualUsuario;
        private Label lblTitulo;
    }
}
