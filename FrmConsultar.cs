using System;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmConsultar : Form
    {
        #region Constructor
        public FrmConsultar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos Auxiliares
        void CargarDatos()
        {
            dgvExpedientes.Rows.Clear();

            for (int i = 0; i < AlmacenExpedientes.cantidad; i++)
            {
                dgvExpedientes.Rows.Add(
                    AlmacenExpedientes.codigos[i],
                    AlmacenExpedientes.solicitantes[i],
                    AlmacenExpedientes.tiposDocumento[i],
                    AlmacenExpedientes.fechas[i],
                    AlmacenExpedientes.motivos[i]
                );
            }

            dgvExpedientes.ClearSelection();
        }

        void AbrirEdicionExpediente()
        {
            if (dgvExpedientes.CurrentRow == null || dgvExpedientes.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, seleccione un expediente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = dgvExpedientes.CurrentRow.Cells["colCodigo"].Value?.ToString() ?? "";
            int indice = AlmacenExpedientes.BuscarIndice(codigo);

            if (indice == -1)
            {
                MessageBox.Show("No se encontró el expediente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditar formularioEditar = new FrmEditar(indice);
            formularioEditar.ShowDialog();
            CargarDatos();
        }
        #endregion

        #region Eventos
        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirEdicionExpediente();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
