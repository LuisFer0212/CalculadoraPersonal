using Calculadora_MVC.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora_MVC.Logica
{
    public class CalculadoraLogica
    {
        private readonly List<double> _memoria;

        public CalculadoraLogica()
        {
            _memoria = new List<double>();
        }

        public double Calcular(double primerNumero, double segundoNumero, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primerNumero / segundoNumero;
                    break;
            }

            return resultado;
        }

        public bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public string ConvertirABinario(int numero)
        {
            string binario = string.Empty;

            while (numero > 0)
            {
                binario = (numero % 2) + binario;
                numero /= 2;
            }

            return binario;
        }

        public double CalcularPromedio(double[] numeros)
        {
            double suma = 0;

            foreach (double numero in numeros)
            {
                suma += numero;
            }

            return suma / numeros.Length;
        }

        public void GuardarEnMemoria(double numero)
        {
            if (_memoria.Count >= 10)
            {
                _memoria.RemoveAt(0); 
            }
            _memoria.Add(numero);
        }

        public double CalcularPromedioMemoria()
        {
            if (_memoria.Count == 0)
            {
                return 0; 
            }
            return _memoria.Average();
        }

        public double RecuperarDeMemoria()
        {
            return _memoria.Count > 0 ? _memoria.Last() : 0;
        }
        public List<double> ObtenerMemoria()
        {
            return new List<double>(_memoria); 
        }
        public void LimpiarMemoria()
        {
            _memoria.Clear(); // Limpia todos los elementos en la lista de memoria
        }

    }
}

// Actualizado
