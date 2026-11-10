using System;
using System.Drawing;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = textBuscar.Text.Trim().ToUpper();

            if (!AlmacenExpedientes.ValidarFormatoCodigo(codigoBuscado))
            {
                lblDatosExpediente.Text = "Código de expediente no válido.";
                MessageBox.Show("Debe ingresar el código completo con el formato exacto (ejemplo: EXP-001).", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int posicion = AlmacenExpedientes.BuscarIndice(codigoBuscado);

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
