using System;
using System.Drawing;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmEditar : Form
    {
        int indice;

        public FrmEditar(int indiceExpediente)
        {
            InitializeComponent();
            indice = indiceExpediente;
            CargarDatos();
        }

        void CargarDatos()
        {
            textCodigo.Text = AlmacenExpedientes.codigos[indice];
            textSolicitante.Text = AlmacenExpedientes.solicitantes[indice];
            cmbTipoDocumento.Text = AlmacenExpedientes.tiposDoc[indice];

            if (DateTime.TryParse(AlmacenExpedientes.fechas[indice], out DateTime fecha))
            {
                dtpFechaRecepcion.Value = fecha;
            }
            else
            {
                dtpFechaRecepcion.Value = DateTime.Now;
            }

            textMotivo.Text = AlmacenExpedientes.motivos[indice];
        }

        void GuardarCambios()
        {
            AlmacenExpedientes.solicitantes[indice] = textSolicitante.Text.Trim();
            AlmacenExpedientes.tiposDoc[indice] = cmbTipoDocumento.Text;
            AlmacenExpedientes.fechas[indice] = dtpFechaRecepcion.Value.ToString("dd/MM/yyyy");
            AlmacenExpedientes.motivos[indice] = textMotivo.Text.Trim();
            AlmacenExpedientes.cambiosPendientes = true;

            MessageBox.Show(
                "Expediente " + AlmacenExpedientes.codigos[indice] + " actualizado correctamente.",
                "Actualización exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (AlmacenExpedientes.ValidarCampos(textSolicitante.Text, cmbTipoDocumento.SelectedIndex, textMotivo.Text, this))
            {
                GuardarCambios();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
