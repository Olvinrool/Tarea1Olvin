using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1Olvin.Paginas
{
    public partial class PaginaEntrada : ContentPage
    {
        public PaginaEntrada()
        {
            InitializeComponent();
        }

        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            double num1 = double.Parse(Numero1Entry.Text);
            double num2 = double.Parse(Numero2Entry.Text);
            string operacion = OperacionPicker.SelectedItem.ToString();

            Calculadora calculadora = new Calculadora();
            double resultado = 0;

            switch (operacion)
            {
                case "Suma":
                    resultado = calculadora.Sumar(num1, num2);
                    break;
                case "Resta":
                    resultado = calculadora.Restar(num1, num2);
                    break;
                case "Multiplicación":
                    resultado = calculadora.Multiplicar(num1, num2);
                    break;
                case "División":
                    resultado = calculadora.Dividir(num1, num2);
                    break;
            }

            // Navegar a la página de resultados y pasar el resultado a través del constructor
            Navigation.PushAsync(new PaginaResultado(resultado));
        }
    }
}