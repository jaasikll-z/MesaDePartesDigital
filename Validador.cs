using System;
using System.Windows.Forms;

namespace MesaDePartesDigital
{
    internal static class Validador
    {
        internal static bool EsTextoValido(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }

            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        internal static bool EsFormatoCodigoValido(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo) || !codigo.StartsWith("EXP-", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return int.TryParse(codigo.Substring(4), out int numero) && numero > 0;
        }

        internal static bool ValidarExpediente(
            string solicitante, Label lblErrorSolicitante,
            int indiceTipoDoc, Label lblErrorTipo,
            DateTime fecha, Label lblErrorFecha,
            string motivo, Label lblErrorMotivo)
        {
            bool valido = true;

            string solicitanteLimpio = solicitante.Trim();
            if (string.IsNullOrWhiteSpace(solicitanteLimpio) || solicitanteLimpio.Length < 3)
            {
                lblErrorSolicitante.Text = "Ingrese un nombre válido (mín. 3 letras).";
                lblErrorSolicitante.Visible = true;
                valido = false;
            }
            else if (!EsTextoValido(solicitanteLimpio))
            {
                lblErrorSolicitante.Text = "Solo se permiten letras y espacios.";
                lblErrorSolicitante.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorSolicitante.Visible = false;
            }

            if (indiceTipoDoc < 0)
            {
                lblErrorTipo.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorTipo.Visible = false;
            }

            if (fecha.Date > DateTime.Today)
            {
                lblErrorFecha.Visible = true;
                valido = false;
            }
            else
            {
                lblErrorFecha.Visible = false;
            }

            string motivoLimpio = motivo.Trim();
            if (string.IsNullOrWhiteSpace(motivoLimpio) || motivoLimpio.Length < 10)
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
    }
}
