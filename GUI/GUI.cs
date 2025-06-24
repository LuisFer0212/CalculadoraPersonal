using System;
using System.Windows.Forms;
using Calculadora_MVC.Controllers;

namespace Calculadora_MVC
{
    public partial class GUI : Form
    {
        private readonly CalculadoraController _controller;

        public GUI()
        {
            InitializeComponent();
            _controller = new CalculadoraController(this);
        }

        public string Resultado
        {
            get => txtResultado.Text;
            set => txtResultado.Text = value;
        }

        private void BtnSuma_Click(object sender, EventArgs e) => _controller.RealizarOperacion("+");
        private void BtnResta_Click(object sender, EventArgs e) => _controller.RealizarOperacion("-");
        private void BtnMultiplicacion_Click(object sender, EventArgs e) => _controller.RealizarOperacion("*");
        private void BtnDivision_Click(object sender, EventArgs e) => _controller.RealizarOperacion("/");
        private void BtnIgual_Click(object sender, EventArgs e) => _controller.CalcularResultado();
        private void BtnClear_Click(object sender, EventArgs e) => _controller.Limpiar();

        private void Btn0_Click(object sender, EventArgs e) => _controller.AgregarNumero("0");
        private void Btn1_Click(object sender, EventArgs e) => _controller.AgregarNumero("1");
        private void Btn2_Click(object sender, EventArgs e) => _controller.AgregarNumero("2");
        private void Btn3_Click(object sender, EventArgs e) => _controller.AgregarNumero("3");
        private void Btn4_Click(object sender, EventArgs e) => _controller.AgregarNumero("4");
        private void Btn5_Click(object sender, EventArgs e) => _controller.AgregarNumero("5");
        private void Btn6_Click(object sender, EventArgs e) => _controller.AgregarNumero("6");
        private void Btn7_Click(object sender, EventArgs e) => _controller.AgregarNumero("7");
        private void Btn8_Click(object sender, EventArgs e) => _controller.AgregarNumero("8");
        private void Btn9_Click(object sender, EventArgs e) => _controller.AgregarNumero("9");
        private void BtnDot_Click(object sender, EventArgs e) => _controller.AgregarNumero(".");

        private void BtnMemory_Click(object sender, EventArgs e) => _controller.GuardarEnMemoria(); // M+
        private void BtnAvg_Click(object sender, EventArgs e) => _controller.CalcularPromedio();     // Avg

        private void BtnData_Click(object sender, EventArgs e) => _controller.CalcularPromedio();
        private void BtnPrimo_Click(object sender, EventArgs e) => _controller.CalcularPrimo();
        private void BtnBinario_Click(object sender, EventArgs e) => _controller.ConvertirABinario();

        private void btnVerBitacora_Click_1(object sender, EventArgs e)
        {
            _controller.MostrarBitacora();
        }


        public void MostrarBitacora(string contenido)
        {
            MessageBox.Show(contenido, "Bitácora de Operaciones");
        }

        public void ActualizarResultado(string resultado)
        {
            txtResultado.Text = resultado;
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
    }
}

// Actualizado
