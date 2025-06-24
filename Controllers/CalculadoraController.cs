using Calculadora_MVC.Data;
using Calculadora_MVC.Logica;
using System;
using System.Collections.Generic;

namespace Calculadora_MVC.Controllers
{
    public class CalculadoraController
    {
        private readonly GUI _gui;
        private readonly CalculadoraLogica _logica;
        private readonly BitacoraManager _bitacora;
        private string _operador;
        private double _primerNumero;
        private bool _memorizado; 
        private readonly List<string> _bitacoraOperaciones; 

        public CalculadoraController(GUI gui)
        {
            _gui = gui;
            _logica = new CalculadoraLogica();
            _bitacora = new BitacoraManager();
            _operador = string.Empty;
            _primerNumero = 0;
            _memorizado = false;
            _bitacoraOperaciones = new List<string>(); 

        }

        public void CalcularResultado()
        {
            if (double.TryParse(_gui.Resultado, out double segundoNumero))
            {
                double resultado = _logica.Calcular(_primerNumero, segundoNumero, _operador);
                string operacion = $"{_primerNumero} {_operador} {segundoNumero} = {resultado}";

                _bitacora.GuardarOperacion(operacion);

                _gui.ActualizarResultado(resultado.ToString());
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void MostrarBitacora()
        {
            string contenido = _bitacoraOperaciones.Count > 0
                ? string.Join(Environment.NewLine, _bitacoraOperaciones)
                : "No hay operaciones registradas.";

            _gui.MostrarBitacora(contenido);
        }



        public void AgregarNumero(string numero)
        {
            if (_memorizado)
            {
                _gui.Resultado = ""; 
                _memorizado = false; 
            }

            if (_gui.Resultado == "0" || _gui.Resultado == "Memorizado")
            {
                _gui.Resultado = numero;
            }
            else
            {
                _gui.Resultado += numero;
            }
        }


        public void RealizarOperacion(string operador)
        {
            if (double.TryParse(_gui.Resultado, out _primerNumero))
            {
                _operador = operador;
                _gui.Resultado = string.Empty;
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void Limpiar()
        {
            _gui.ActualizarResultado("0"); // Restablece la pantalla a 0
            _primerNumero = 0; // Limpia el primer número almacenado
            _operador = string.Empty; // Limpia el operador
            _logica.LimpiarMemoria(); // Llama al método que limpia la memoria
            _bitacora.LimpiarBitacora(); // Llama al método que borra el archivo de bitácora
            _bitacoraOperaciones.Clear();
        }

        public void CalcularPrimo()
        {
            if (int.TryParse(_gui.Resultado, out int numero))
            {
                bool esPrimo = _logica.EsPrimo(numero);
                string resultado = esPrimo ? "Primo" : "No Primo";
                _gui.ActualizarResultado(resultado);

                _bitacora.GuardarOperacion($"{numero} es {resultado}");
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void ConvertirABinario()
        {
            if (int.TryParse(_gui.Resultado, out int numero))
            {
                string binario = _logica.ConvertirABinario(numero);
                _gui.ActualizarResultado(binario);

                _bitacora.GuardarOperacion($"{numero} en binario es {binario}");
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void GuardarEnMemoria()
        {
            if (double.TryParse(_gui.Resultado, out double numero))
            {
                _logica.GuardarEnMemoria(numero);
                _gui.ActualizarResultado("Memorizado");

                string operacion = $"Guardado en memoria: {numero}";
                _bitacora.GuardarOperacion(operacion);

                if (_bitacoraOperaciones.Count >= 10)
                {
                    _bitacoraOperaciones.RemoveAt(0); 
                }
                _bitacoraOperaciones.Add(operacion); 
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        


        public void RecuperarDeMemoria()
        {
            double numero = _logica.RecuperarDeMemoria();
            _gui.ActualizarResultado(numero.ToString());

            _bitacora.GuardarOperacion($"Recuperado de memoria: {numero}");
        }

        public void CalcularPromedio()
        {
            double promedio = _logica.CalcularPromedioMemoria();
            _gui.ActualizarResultado(promedio.ToString());

            _bitacora.GuardarOperacion($"Promedio calculado: {promedio}");
        }
        public void PruebaBitacora()
        {
            _bitacora.GuardarOperacion("Prueba de escritura en la bitácora: 123");
            string contenido = _bitacora.LeerBitacora();
            Console.WriteLine(contenido); 
        }

    }
}

// Actualizado
