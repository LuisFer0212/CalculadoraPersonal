namespace Calculadora_MVC
{
    partial class GUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnData = new System.Windows.Forms.Button();
            this.BtnBinario = new System.Windows.Forms.Button();
            this.BtnPrimo = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnAvg = new System.Windows.Forms.Button();
            this.BtnMemory = new System.Windows.Forms.Button();
            this.btnVerBitacora = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtResultado
            this.txtResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResultado.ForeColor = System.Drawing.Color.Black;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(28, 25);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(315, 43);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Función rápida para aplicar estilo iOS
            void Estilizar(System.Windows.Forms.Button btn, System.Drawing.Color fondo, System.Drawing.Color texto)
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.BackColor = fondo;
                btn.ForeColor = texto;
            }

            // Botones de números
            System.Windows.Forms.Button[] numeros = { Btn0, Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9, BtnDot };
            foreach (var b in numeros)
                Estilizar(b, System.Drawing.Color.Gainsboro, System.Drawing.Color.Black);

            // Operaciones
            Estilizar(btnSuma, System.Drawing.Color.Orange, System.Drawing.Color.White);
            Estilizar(btnResta, System.Drawing.Color.Orange, System.Drawing.Color.White);
            Estilizar(btnMultiplicacion, System.Drawing.Color.Orange, System.Drawing.Color.White);
            Estilizar(btnDivision, System.Drawing.Color.Orange, System.Drawing.Color.White);
            Estilizar(btnIgual, System.Drawing.Color.Orange, System.Drawing.Color.White);

            // Especiales
            Estilizar(btnClear, System.Drawing.Color.LightGray, System.Drawing.Color.Black);
            Estilizar(BtnData, System.Drawing.Color.LightGray, System.Drawing.Color.Black);
            Estilizar(BtnBinario, System.Drawing.Color.LightGray, System.Drawing.Color.Black);
            Estilizar(BtnPrimo, System.Drawing.Color.LightGray, System.Drawing.Color.Black);
            Estilizar(BtnAvg, System.Drawing.Color.LightGray, System.Drawing.Color.Black);
            Estilizar(BtnMemory, System.Drawing.Color.LightGray, System.Drawing.Color.Black);
            Estilizar(btnVerBitacora, System.Drawing.Color.LightGray, System.Drawing.Color.Black);

            // Posiciones y tamaños (ya los tenías bien definidos)
            this.btnSuma.Location = new System.Drawing.Point(208, 296);
            this.btnSuma.Size = new System.Drawing.Size(50, 50);
            this.btnSuma.Text = "+";
            this.btnSuma.Click += new System.EventHandler(this.BtnSuma_Click);

            this.btnResta.Location = new System.Drawing.Point(208, 240);
            this.btnResta.Size = new System.Drawing.Size(50, 50);
            this.btnResta.Text = "-";
            this.btnResta.Click += new System.EventHandler(this.BtnResta_Click);

            this.btnMultiplicacion.Location = new System.Drawing.Point(208, 128);
            this.btnMultiplicacion.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click);

            this.btnDivision.Location = new System.Drawing.Point(208, 184);
            this.btnDivision.Size = new System.Drawing.Size(50, 50);
            this.btnDivision.Text = "/";
            this.btnDivision.Click += new System.EventHandler(this.BtnDivision_Click);

            this.btnIgual.Location = new System.Drawing.Point(264, 240);
            this.btnIgual.Size = new System.Drawing.Size(79, 106);
            this.btnIgual.Text = "=";
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);

            this.btnClear.Location = new System.Drawing.Point(88, 296);
            this.btnClear.Size = new System.Drawing.Size(54, 50);
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.BtnData.Location = new System.Drawing.Point(208, 60);
            this.BtnData.Size = new System.Drawing.Size(135, 52);
            this.BtnData.Text = "Data";
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);

            this.BtnBinario.Location = new System.Drawing.Point(28, 60);
            this.BtnBinario.Size = new System.Drawing.Size(170, 28);
            this.BtnBinario.Text = "Binario";
            this.BtnBinario.Click += new System.EventHandler(this.BtnBinario_Click);

            this.BtnPrimo.Location = new System.Drawing.Point(28, 89);
            this.BtnPrimo.Size = new System.Drawing.Size(170, 28);
            this.BtnPrimo.Text = "Primo";
            this.BtnPrimo.Click += new System.EventHandler(this.BtnPrimo_Click);

            this.Btn7.Location = new System.Drawing.Point(28, 128);
            this.Btn7.Size = new System.Drawing.Size(50, 50);
            this.Btn7.Text = "7";
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);

            this.Btn8.Location = new System.Drawing.Point(88, 128);
            this.Btn8.Size = new System.Drawing.Size(50, 50);
            this.Btn8.Text = "8";
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);

            this.Btn9.Location = new System.Drawing.Point(148, 128);
            this.Btn9.Size = new System.Drawing.Size(50, 50);
            this.Btn9.Text = "9";
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);

            this.Btn4.Location = new System.Drawing.Point(28, 184);
            this.Btn4.Size = new System.Drawing.Size(50, 50);
            this.Btn4.Text = "4";
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);

            this.Btn5.Location = new System.Drawing.Point(88, 184);
            this.Btn5.Size = new System.Drawing.Size(50, 50);
            this.Btn5.Text = "5";
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);

            this.Btn6.Location = new System.Drawing.Point(148, 184);
            this.Btn6.Size = new System.Drawing.Size(50, 50);
            this.Btn6.Text = "6";
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);

            this.Btn1.Location = new System.Drawing.Point(28, 240);
            this.Btn1.Size = new System.Drawing.Size(50, 50);
            this.Btn1.Text = "1";
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);

            this.Btn2.Location = new System.Drawing.Point(88, 240);
            this.Btn2.Size = new System.Drawing.Size(50, 50);
            this.Btn2.Text = "2";
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);

            this.Btn3.Location = new System.Drawing.Point(148, 240);
            this.Btn3.Size = new System.Drawing.Size(50, 50);
            this.Btn3.Text = "3";
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);

            this.Btn0.Location = new System.Drawing.Point(28, 296);
            this.Btn0.Size = new System.Drawing.Size(50, 50);
            this.Btn0.Text = "0";
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);

            this.BtnDot.Location = new System.Drawing.Point(148, 296);
            this.BtnDot.Size = new System.Drawing.Size(50, 50);
            this.BtnDot.Text = ".";
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);

            this.BtnAvg.Location = new System.Drawing.Point(264, 128);
            this.BtnAvg.Size = new System.Drawing.Size(79, 50);
            this.BtnAvg.Text = "Avg";
            this.BtnAvg.Click += new System.EventHandler(this.BtnAvg_Click);

            this.BtnMemory.Location = new System.Drawing.Point(264, 184);
            this.BtnMemory.Size = new System.Drawing.Size(79, 50);
            this.BtnMemory.Text = "M+";
            this.BtnMemory.Click += new System.EventHandler(this.BtnMemory_Click);

            this.btnVerBitacora.Location = new System.Drawing.Point(117, 352);
            this.btnVerBitacora.Size = new System.Drawing.Size(110, 38);
            this.btnVerBitacora.Text = "Ver Bitácora";
            this.btnVerBitacora.Click += new System.EventHandler(this.btnVerBitacora_Click_1);

            // GUI
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 399);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                txtResultado, btnSuma, btnResta, btnMultiplicacion, btnDivision,
                btnIgual, btnClear, BtnData, BtnBinario, BtnPrimo,
                Btn7, Btn8, Btn9, Btn4, Btn5, Btn6,
                Btn1, Btn2, Btn3, Btn0, BtnDot, BtnAvg,
                BtnMemory, btnVerBitacora
            });
            this.Name = "GUI";
            this.Text = "Calculadora iOS";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSuma, btnResta, btnMultiplicacion, btnDivision, btnIgual, btnClear;
        private System.Windows.Forms.Button BtnData, BtnBinario, BtnPrimo, Btn7, Btn8, Btn9, Btn6, Btn5, Btn4;
        private System.Windows.Forms.Button Btn3, Btn2, Btn1, Btn0, BtnAvg, BtnMemory, btnVerBitacora, BtnDot;
    }
}

// Actualizado
