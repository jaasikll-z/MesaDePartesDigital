using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        bool ValidarFormatoCodigo(string codigo)
        {
            if (codigo.Length != 7)
            {
                return false;
            }

            if (!codigo.StartsWith("EXP-"))
            {
                return false;
            }

            int numero;
            if (!int.TryParse(codigo.Substring(4), out numero) || numero <= 0)
            {
                return false;
            }

            return true;
        }

        // Recorremos los codigos uno por uno hasta encontrar la coincidencia
        int BuscarDocumento(string codigoBuscado)
        {
            for (int i = 0; i < AlmacenExpedientes.cantidad; i++)
            {
                if (AlmacenExpedientes.codigos[i].Equals(codigoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = textBuscar.Text.Trim().ToUpper();

            if (!ValidarFormatoCodigo(codigoBuscado))
            {
                lblDatosExpediente.Text = "Código de expediente no válido.";
                MessageBox.Show("Debe ingresar el código completo con el formato exacto (ejemplo: EXP-001).", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int posicion = BuscarDocumento(codigoBuscado);

            if (posicion != -1)
            {
                lblDatosExpediente.Text =
                    "Código: " + AlmacenExpedientes.codigos[posicion] + "\n" +
                    "Solicitante: " + AlmacenExpedientes.solicitantes[posicion] + "\n" +
                    "Tipo de documento: " + AlmacenExpedientes.tiposDoc[posicion] + "\n" +
                    "Fecha de recepción: " + AlmacenExpedientes.fechas[posicion] + "\n" +
                    "Motivo: " + AlmacenExpedientes.motivos[posicion];
            }
            else
            {
                lblDatosExpediente.Text = "El expediente con código " + codigoBuscado + " no fue encontrado.";
                MessageBox.Show("El expediente con código " + codigoBuscado + " no fue encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
