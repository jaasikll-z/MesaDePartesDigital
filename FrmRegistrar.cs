using System;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmRegistrar : Form
    {
        #region Constructor
        public FrmRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos de Validación y Registro
        bool ValidarCampos()
        {
            return Validador.ValidarExpediente(
                txtSolicitante.Text, lblErrorSolicitante,
                cmbTipoDocumento.SelectedIndex, lblErrorTipo,
                dtpFechaRecepcion.Value, lblErrorFecha,
                txtMotivo.Text, lblErrorMotivo
            );
        }

        void LimpiarCampos()
        {
            txtSolicitante.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            dtpFechaRecepcion.Value = DateTime.Now;
            txtMotivo.Clear();

            lblErrorSolicitante.Visible = false;
            lblErrorTipo.Visible = false;
            lblErrorFecha.Visible = false;
            lblErrorMotivo.Visible = false;
        }

        void RegistrarExpediente()
        {
            if (AlmacenExpedientes.cantidad >= AlmacenExpedientes.capacidadMaxima)
            {
                MessageBox.Show(
                    "Error: Capacidad máxima de almacenamiento alcanzada (" + 
                    AlmacenExpedientes.capacidadMaxima + 
                    " registros).", "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            string nuevoCodigo = AlmacenExpedientes.FormatearCodigo(AlmacenExpedientes.cantidad + 1);

            AlmacenExpedientes.codigos[AlmacenExpedientes.cantidad] = nuevoCodigo;
            AlmacenExpedientes.solicitantes[AlmacenExpedientes.cantidad] = txtSolicitante.Text.Trim();
            AlmacenExpedientes.tiposDocumento[AlmacenExpedientes.cantidad] = cmbTipoDocumento.Text;
            AlmacenExpedientes.fechas[AlmacenExpedientes.cantidad] = dtpFechaRecepcion.Value.ToString("dd/MM/yyyy");
            AlmacenExpedientes.motivos[AlmacenExpedientes.cantidad] = txtMotivo.Text.Trim();
            AlmacenExpedientes.cantidad++;
            AlmacenExpedientes.cambiosPendientes = true;

            MessageBox.Show("Expediente registrado exitosamente con código: " + nuevoCodigo, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }
        #endregion

        #region Eventos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                RegistrarExpediente();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
