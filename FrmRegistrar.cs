using System;
using System.Drawing;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
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

        void LimpiarCampos()
        {
            textSolicitante.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            dtpFechaRecepcion.Value = DateTime.Now;
            textMotivo.Clear();

            // Ocultar etiquetas de error
            lblErrorSolicitante.Visible = false;
            lblErrorTipo.Visible = false;
            lblErrorFecha.Visible = false;
            lblErrorMotivo.Visible = false;
        }

        void RegistrarExpediente()
        {
            if (AlmacenExpedientes.cantidad >= AlmacenExpedientes.MAX)
            {
                MessageBox.Show(
                    "Error: Capacidad máxima de almacenamiento alcanzada (" + 
                    AlmacenExpedientes.MAX + 
                    " registros).", "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            // Buscamos el numero mas alto para generar el siguiente codigo
            int mayor = 0;
            for (int i = 0; i < AlmacenExpedientes.cantidad; i++)
            {
                int num = AlmacenExpedientes.ExtraerNumero(AlmacenExpedientes.codigos[i]);
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            string nuevoCodigo = AlmacenExpedientes.FormatearCodigo(mayor + 1);

            AlmacenExpedientes.codigos[AlmacenExpedientes.cantidad] = nuevoCodigo;
            AlmacenExpedientes.solicitantes[AlmacenExpedientes.cantidad] = textSolicitante.Text.Trim();
            AlmacenExpedientes.tiposDoc[AlmacenExpedientes.cantidad] = cmbTipoDocumento.Text;
            AlmacenExpedientes.fechas[AlmacenExpedientes.cantidad] = dtpFechaRecepcion.Value.ToString("dd/MM/yyyy");
            AlmacenExpedientes.motivos[AlmacenExpedientes.cantidad] = textMotivo.Text.Trim();
            AlmacenExpedientes.cantidad++;
            AlmacenExpedientes.cambiosPendientes = true;

            MessageBox.Show("Expediente registrado exitosamente con código: " + nuevoCodigo, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposConEtiquetas())
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
    }
}
