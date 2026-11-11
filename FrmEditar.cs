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

        bool EsTextoValido(string texto)
        {
            foreach (char c in texto)
            {
                // Solo permitimos letras, espacios y puntos (ej. para entidades como I.E. o Lic.)
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        bool ValidarCamposConEtiquetas()
        {
            bool valido = true;

            // Validación de Solicitante
            string solicitante = textSolicitante.Text.Trim();
            if (string.IsNullOrWhiteSpace(solicitante) || solicitante.Length < 3)
            {
                lblErrorSolicitante.Text = "Ingrese un nombre válido (mín. 3 letras).";
                lblErrorSolicitante.Visible = true;
                valido = false;
            }
            else if (!EsTextoValido(solicitante))
            {
                lblErrorSolicitante.Text = "Solo se permiten letras y espacios.";
                lblErrorSolicitante.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorSolicitante.Visible = false;
            }

            // Validación de Tipo de Documento
            if (cmbTipoDocumento.SelectedIndex < 0)
            {
                lblErrorTipo.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorTipo.Visible = false;
            }

            // Validación de Fecha (no puede ser fecha futura)
            if (dtpFechaRecepcion.Value.Date > DateTime.Now.Date)
            {
                lblErrorFecha.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorFecha.Visible = false;
            }

            // Validación de Motivo
            string motivo = textMotivo.Text.Trim();
            if (string.IsNullOrWhiteSpace(motivo) || motivo.Length < 10)
            {
                lblErrorMotivo.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorMotivo.Visible = false;
            }

            return valido;
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
            if (ValidarCamposConEtiquetas())
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
