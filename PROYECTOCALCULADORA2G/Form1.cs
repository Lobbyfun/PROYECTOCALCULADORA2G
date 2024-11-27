using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOCALCULADORA2G
{
    public partial class Form1 : Form
    {
        double Valor1;
        double Valor2;
        double Rspta;
        char Operador;
        bool Bandera = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void PonerNumero(string Numero)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = " ";
            }
            if (Bandera == true)
            {
                lblPantalla.Text = "";
            }
            lblPantalla.Text = lblPantalla.Text + Numero;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Valor2 = double.Parse(lblPantalla.Text);

            switch (Operador)
            {
                case '+':
                    Rspta = Valor1 + Valor2;
                    break;

                case '-':
                    Rspta = Valor1 - Valor2;
                    break;

                case 'x':
                    Rspta = Valor1 * Valor2;
                    break;

                case '÷':
                    Rspta = Valor1 / Valor2;
                    break;
            }

            lblPantalla.Text = Rspta.ToString(); // Mostramos el resultado final
            Valor1 = 0; // Reiniciamos el acumulador para futuras operaciones
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "0";
            Valor1 = 0;
            Valor2 = 0;
            Operador = ' '; // Limpia la variable de operación
            Bandera = false; // Reinicia la bandera para que no borre los números nuevos
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Si ya hay un valor acumulado, realiza la operación acumulativa
            if (Valor1 != 0)
            {
                Valor1 = Valor1 / double.Parse(lblPantalla.Text);
            }
            else
            {
                // Si es la primera operación, guarda el valor actual
                Valor1 = double.Parse(lblPantalla.Text);
            }

            lblPantalla.Text = "0"; // Limpia la pantalla para que puedas ingresar el siguiente número
            Operador = '÷'; // Guardamos el operador
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Si ya hay un valor acumulado, realiza la operación acumulativa
            if (Valor1 != 0)
            {
                Valor1 = Valor1 * double.Parse(lblPantalla.Text);
            }
            else
            {
                // Si es la primera operación, guarda el valor actual
                Valor1 = double.Parse(lblPantalla.Text);
            }

            lblPantalla.Text = "0"; // Limpia la pantalla para que puedas ingresar el siguiente número
            Operador = 'x'; // Guardamos el operador
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Si ya hay un valor acumulado, realiza la operación acumulativa
            if (Valor1 != 0)
            {
                Valor1 = Valor1 - double.Parse(lblPantalla.Text);
            }
            else
            {
                // Si es la primera operación, guarda el valor actual
                Valor1 = double.Parse(lblPantalla.Text);
            }

            lblPantalla.Text = "0"; // Limpia la pantalla para que puedas ingresar el siguiente número
            Operador = '-'; // Guardamos el operador
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Si ya hay un valor acumulado, realiza la operación acumulativa
            if (Valor1 != 0)
            {
                Valor1 = Valor1 + double.Parse(lblPantalla.Text);
            }
            else
            {
                // Si es la primera operación, guarda el valor actual
                Valor1 = double.Parse(lblPantalla.Text);
            }

            lblPantalla.Text = "0"; // Limpia la pantalla para que puedas ingresar el siguiente número
            Operador = '+'; // Guardamos el operador
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            PonerNumero(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PonerNumero(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PonerNumero(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PonerNumero(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PonerNumero(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PonerNumero(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PonerNumero(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PonerNumero(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PonerNumero(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PonerNumero(btn9.Text);
        }
    }
}
