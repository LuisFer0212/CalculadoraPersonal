using System;
using System.IO;

namespace Calculadora_MVC.Data
{
    public class BitacoraManager
    {
        private readonly string _filePath;

        public BitacoraManager()
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            _filePath = Path.Combine(directory, "Bitacora.txt");
        }

        public void GuardarOperacion(string operacion)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(operacion);
            }
        }

        // Borra el contenido de la bitácora al iniciar nuevos cálculos
        public void LimpiarBitacora()
        {
            if (File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, string.Empty); // Borra el contenido
            }
        }

        // Lee todas las operaciones guardadas en el archivo de bitácora
        public string LeerBitacora()
        {
            if (!File.Exists(_filePath))
            {
                return "No hay operaciones registradas en la bitácora.";
            }

            using (StreamReader reader = new StreamReader(_filePath))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

// Actualizado
