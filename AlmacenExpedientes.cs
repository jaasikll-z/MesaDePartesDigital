using System;
using System.IO;
using System.Text;

namespace MesaDePartesDigital
{
    internal static class AlmacenExpedientes
    {
        internal const int MAX = 500;
        // Arreglos para guardar los datos de cada expediente por posicion
        internal static string[] codigos = new string[MAX];
        internal static string[] solicitantes = new string[MAX];
        internal static string[] tiposDoc = new string[MAX];
        internal static string[] fechas = new string[MAX];
        internal static string[] motivos = new string[MAX];
        internal static int cantidad = 0;
        internal static bool cambiosPendientes = false;
        private static string rutaArchivo = "expedientes.txt";

        internal static string FormatearCodigo(int numero)
        {
            return "EXP-" + numero.ToString("D3");
        }

        internal static int ExtraerNumero(string texto)
        {
            string limpio = texto.Trim().ToUpper().Replace("EXP-", "");
            int numero;
            if (int.TryParse(limpio, out numero))
            {
                return numero;
            }
            return -1;
        }

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

        internal static string NormalizarCodigo(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            string limpio = texto.Trim().ToUpper();

            // Si ingresó directamente un número (ej. "1", "01", "001")
            if (int.TryParse(limpio, out int numSolo) && numSolo > 0)
            {
                return FormatearCodigo(numSolo);
            }

            // Si ingresó con prefijo EXP- o EXP (ej. "EXP-1", "exp-001", "EXP 1")
            if (limpio.StartsWith("EXP-") || limpio.StartsWith("EXP"))
            {
                string soloDigitos = limpio.Replace("EXP-", "").Replace("EXP", "").Trim();
                if (int.TryParse(soloDigitos, out int numExp) && numExp > 0)
                {
                    return FormatearCodigo(numExp);
                }
            }

            return limpio;
        }

        internal static bool ValidarFormatoCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return false;
            }

            if (!codigo.StartsWith("EXP-"))
            {
                return false;
            }

            int numero = ExtraerNumero(codigo);
            return numero > 0;
        }

        internal static void Cargar()
        {
            cantidad = 0;
            cambiosPendientes = false;

            if (!File.Exists(rutaArchivo))
                return;

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (cantidad >= MAX)
                    break;

                string linea = lineas[i];
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                // Separamos los datos de la linea usando el caracter |
                string[] datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    codigos[cantidad] = datos[0].Trim();
                    solicitantes[cantidad] = datos[1].Trim();
                    tiposDoc[cantidad] = datos[2].Trim();
                    fechas[cantidad] = datos[3].Trim();
                    motivos[cantidad] = datos[4].Trim();
                    cantidad++;
                }
            }
        }
        
        internal static void Guardar()
        {
            // Guardamos todos los expedientes en el archivo txt
            string[] lineas = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                lineas[i] = codigos[i] + "|" +
                            solicitantes[i].Replace("|", "/") + "|" +
                            tiposDoc[i].Replace("|", "/") + "|" +
                            fechas[i].Replace("|", "/") + "|" +
                            motivos[i].Replace("|", "/");
            }

            File.WriteAllLines(rutaArchivo, lineas, Encoding.UTF8);
            cambiosPendientes = false;
        }
    }
}
