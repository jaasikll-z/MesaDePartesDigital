using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            AlmacenExpedientes.Cargar();
        }

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
    }
}
