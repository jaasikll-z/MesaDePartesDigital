using System;
using System.IO;
using System.Text;

namespace MesaDePartesDigital
{
    internal static class AlmacenExpedientes
    {
        #region Constantes y Estructuras de Datos
        internal const int capacidadMaxima = 500;
        internal static string[] codigos = new string[capacidadMaxima];
        internal static string[] solicitantes = new string[capacidadMaxima];
        internal static string[] tiposDocumento = new string[capacidadMaxima];
        internal static string[] fechas = new string[capacidadMaxima];
        internal static string[] motivos = new string[capacidadMaxima];
        internal static int cantidad = 0;
        internal static bool cambiosPendientes = false;
        private static string rutaArchivo = "expedientes.txt";
        #endregion

        #region Operaciones con Codigos
        internal static string FormatearCodigo(int numero)
        {
            return "EXP-" + numero.ToString("D3");
        }

        internal static string NormalizarCodigo(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "";
            }

            string limpio = texto.Trim().ToUpper().Replace("EXP-", "").Replace("EXP", "").Trim();

            if (int.TryParse(limpio, out int numero) && numero > 0)
            {
                return FormatearCodigo(numero);
            }

            return texto.Trim().ToUpper();
        }
        #endregion

        #region Busqueda
        internal static int BuscarIndice(string codigo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (codigos[i].Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Persistencia de Archivo
        internal static void Cargar()
        {
            cantidad = 0;
            cambiosPendientes = false;

            if (!File.Exists(rutaArchivo))
                return;

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (cantidad >= capacidadMaxima)
                    break;

                string linea = lineas[i];
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    codigos[cantidad] = datos[0].Trim();
                    solicitantes[cantidad] = datos[1].Trim();
                    tiposDocumento[cantidad] = datos[2].Trim();
                    fechas[cantidad] = datos[3].Trim();
                    motivos[cantidad] = datos[4].Trim();
                    cantidad++;
                }
            }
        }
        
        internal static void Guardar()
        {
            string[] lineas = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                lineas[i] = codigos[i] + "|" +
                            solicitantes[i].Replace("|", "/") + "|" +
                            tiposDocumento[i].Replace("|", "/") + "|" +
                            fechas[i].Replace("|", "/") + "|" +
                            motivos[i].Replace("|", "/");
            }

            File.WriteAllLines(rutaArchivo, lineas, Encoding.UTF8);
            cambiosPendientes = false;
        }

        internal static void ExportarReporte(string rutaDestino)
        {
            string[] lineas = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                lineas[i] = codigos[i] + "|" +
                            solicitantes[i].Replace("|", "/") + "|" +
                            tiposDocumento[i].Replace("|", "/") + "|" +
                            fechas[i].Replace("|", "/") + "|" +
                            motivos[i].Replace("|", "/");
            }

            File.WriteAllLines(rutaDestino, lineas, Encoding.UTF8);
        }
        #endregion
    }
}
