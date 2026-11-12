using System;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmBuscar : Form
    {
        #region Constructor
        public FrmBuscar()
        {
            InitializeComponent();
            this.AcceptButton = btnBuscar;
        }
        #endregion

        #region Métodos Auxiliares
        void MostrarDetalleExpediente(int posicion)
        {
            lblDatosExpediente.Text =
                "Código: " + AlmacenExpedientes.codigos[posicion] + "\n" +
                "Solicitante: " + AlmacenExpedientes.solicitantes[posicion] + "\n" +
                "Tipo de documento: " + AlmacenExpedientes.tiposDocumento[posicion] + "\n" +
                "Fecha de recepción: " + AlmacenExpedientes.fechas[posicion] + "\n" +
                "Motivo: " + AlmacenExpedientes.motivos[posicion];
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoIngresado = txtBuscar.Text.Trim();
            string codigoBuscado = AlmacenExpedientes.NormalizarCodigo(textoIngresado);

            if (!Validador.EsFormatoCodigoValido(codigoBuscado))
            {
                lblDatosExpediente.Text = "Código de expediente no válido.";
                MessageBox.Show(
                    "Debe ingresar un número de expediente válido (ejemplos: 1, 001 o EXP-001).",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int posicion = AlmacenExpedientes.BuscarIndice(codigoBuscado);

            if (posicion != -1)
            {
                MostrarDetalleExpediente(posicion);
            }
            else
            {
                string mensaje = "El expediente con código " + codigoBuscado + " no fue encontrado.";
                lblDatosExpediente.Text = mensaje;
                MessageBox.Show(mensaje, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
