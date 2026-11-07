namespace MesaDePartesDigital
{
    partial class FrmMenuPrincipal
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
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnConsultar = new Button();
            msMenuPrincipal = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            itemGuardar = new ToolStripMenuItem();
            itemSalir = new ToolStripMenuItem();
            menuAyuda = new ToolStripMenuItem();
            itemAcercaDe = new ToolStripMenuItem();
            msMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(69, 60);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MESA DE PARTES DIGITAL";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(18, 160);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 66);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(156, 160);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 66);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(295, 160);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(106, 66);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // msMenuPrincipal
            // 
            msMenuPrincipal.Items.AddRange(new ToolStripItem[] { menuArchivo, menuAyuda });
            msMenuPrincipal.Location = new Point(0, 0);
            msMenuPrincipal.Name = "msMenuPrincipal";
            msMenuPrincipal.Size = new Size(425, 24);
            msMenuPrincipal.TabIndex = 5;
            msMenuPrincipal.Text = "msMenuPrincipal";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { itemGuardar, itemSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(60, 20);
            menuArchivo.Text = "Archivo";
            // 
            // itemGuardar
            // 
            itemGuardar.Name = "itemGuardar";
            itemGuardar.Size = new Size(180, 22);
            itemGuardar.Text = "Guardar";
            itemGuardar.Click += itemGuardar_Click;
            // 
            // itemSalir
            // 
            itemSalir.Name = "itemSalir";
            itemSalir.Size = new Size(180, 22);
            itemSalir.Text = "Salir";
            itemSalir.Click += itemSalir_Click;
            // 
            // menuAyuda
            // 
            menuAyuda.DropDownItems.AddRange(new ToolStripItem[] { itemAcercaDe });
            menuAyuda.Name = "menuAyuda";
            menuAyuda.Size = new Size(53, 20);
            menuAyuda.Text = "Ayuda";
            // 
            // itemAcercaDe
            // 
            itemAcercaDe.Name = "itemAcercaDe";
            itemAcercaDe.Size = new Size(180, 22);
            itemAcercaDe.Text = "Acerca de";
            itemAcercaDe.Click += itemAcercaDe_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 304);
            Controls.Add(msMenuPrincipal);
            Controls.Add(btnConsultar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblTitulo);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            msMenuPrincipal.ResumeLayout(false);
            msMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnConsultar;
        private MenuStrip msMenuPrincipal;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem itemGuardar;
        private ToolStripMenuItem itemSalir;
        private ToolStripMenuItem menuAyuda;
        private ToolStripMenuItem itemAcercaDe;
    }
}