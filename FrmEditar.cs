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

        bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(textSolicitante.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre del solicitante (padre, apoderado o entidad).",
                    "Validación de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textSolicitante.Focus();
                return false;
            }

            if (cmbTipoDocumento.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de documento válido de la lista desplegable.",
                    "Validación de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbTipoDocumento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textMotivo.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el motivo o descripción detallada del trámite.",
                    "Validación de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textMotivo.Focus();
                return false;
            }

            return true;
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
            if (ValidarDatos())
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
