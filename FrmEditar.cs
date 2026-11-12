using System;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmEditar : Form
    {
        #region Atributos
        int indice;
        #endregion

        #region Constructor
        public FrmEditar(int indiceExpediente)
        {
            InitializeComponent();
            this.AcceptButton = btnGuardar;
            this.CancelButton = btnCancelar;
            indice = indiceExpediente;
            CargarDatos();
        }
        #endregion

        #region Métodos Auxiliares
        void CargarDatos()
        {
            lblCodigoExpediente.Text = AlmacenExpedientes.codigos[indice];
            txtSolicitante.Text = AlmacenExpedientes.solicitantes[indice];
            cmbTipoDocumento.Text = AlmacenExpedientes.tiposDocumento[indice];

            dtpFechaRecepcion.Value = DateTime.TryParse(AlmacenExpedientes.fechas[indice], out DateTime fecha)
                ? fecha
                : DateTime.Now;

            txtMotivo.Text = AlmacenExpedientes.motivos[indice];
        }

        bool ValidarCampos()
        {
            return Validador.ValidarExpediente(
                txtSolicitante.Text, lblErrorSolicitante,
                cmbTipoDocumento.SelectedIndex, lblErrorTipo,
                dtpFechaRecepcion.Value, lblErrorFecha,
                txtMotivo.Text, lblErrorMotivo
            );
        }

        void GuardarCambios()
        {
            AlmacenExpedientes.solicitantes[indice] = txtSolicitante.Text.Trim();
            AlmacenExpedientes.tiposDocumento[indice] = cmbTipoDocumento.Text;
            AlmacenExpedientes.fechas[indice] = dtpFechaRecepcion.Value.ToString("dd/MM/yyyy");
            AlmacenExpedientes.motivos[indice] = txtMotivo.Text.Trim();
            AlmacenExpedientes.cambiosPendientes = true;

            MessageBox.Show(
                "Expediente " + AlmacenExpedientes.codigos[indice] + " actualizado correctamente.",
                "Actualización exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarCambios();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
