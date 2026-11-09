using System;
using System.Drawing;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        void CargarDatos()
        {
            dgvExpedientes.Rows.Clear();

            for (int i = 0; i < AlmacenExpedientes.cantidad; i++)
            {
                dgvExpedientes.Rows.Add(
                    AlmacenExpedientes.codigos[i],
                    AlmacenExpedientes.solicitantes[i],
                    AlmacenExpedientes.tiposDoc[i],
                    AlmacenExpedientes.fechas[i],
                    AlmacenExpedientes.motivos[i]
                );
            }
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
