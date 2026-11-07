using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        string FormatearCodigo(int numero)
        {
            return "EXP-" + numero.ToString("D3");
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

        void LimpiarCampos()
        {
            textSolicitante.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            dtpFechaRecepcion.Value = DateTime.Now;
            textMotivo.Clear();
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
            string nuevoCodigo = FormatearCodigo(mayor + 1);

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                RegistrarExpediente();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
