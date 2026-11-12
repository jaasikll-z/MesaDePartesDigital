using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmMenuPrincipal : Form
    {
        #region Constructor
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            AlmacenExpedientes.Cargar();
        }
        #endregion

        #region Eventos de Botones
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar formulario = new FrmRegistrar();
            formulario.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar formulario = new FrmBuscar();
            formulario.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar formulario = new FrmConsultar();
            formulario.ShowDialog();
        }
        #endregion

        #region Eventos del Menú y Formulario
        private void itemGuardar_Click(object sender, EventArgs e)
        {
            AlmacenExpedientes.Guardar();
            MessageBox.Show("Los expedientes se han guardado correctamente en el archivo.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Mesa de Partes Digital - I.E.P. Niños de Fátima (Nivel Inicial)\nTotal de expedientes registrados: " + AlmacenExpedientes.cantidad,
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void itemExportar_Click(object sender, EventArgs e)
        {
            if (AlmacenExpedientes.cantidad == 0)
            {
                MessageBox.Show("No hay expedientes registrados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Title = "Exportar reporte de expedientes";
            dialogo.Filter = "Archivo de texto (*.txt)|*.txt";
            dialogo.FileName = "reporte_expedientes";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                AlmacenExpedientes.ExportarReporte(dialogo.FileName);
                MessageBox.Show("El reporte se exportó correctamente.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void itemVerExpedientes_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("notepad.exe", "expedientes.txt") { UseShellExecute = true });
        }

        private void itemManualUsuario_Click(object sender, EventArgs e)
        {
            if (File.Exists("ManualDeUsuario.pdf"))
                Process.Start(new ProcessStartInfo("ManualDeUsuario.pdf") { UseShellExecute = true });
            else
                MessageBox.Show("El archivo del Manual de Usuario no fue encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AlmacenExpedientes.cambiosPendientes)
            {
                DialogResult respuesta = MessageBox.Show(
                    "Hay cambios sin guardar. ¿Desea guardar los cambios antes de salir?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    AlmacenExpedientes.Guardar();
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}
