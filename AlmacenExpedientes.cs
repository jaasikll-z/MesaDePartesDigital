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
