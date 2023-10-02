using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1Olvin.Paginas
{
    public partial class PaginaResultado : ContentPage
    {
        public PaginaResultado(double resultado)
        {
            InitializeComponent();
            ResultadoLabel.Text = "Resultado: " + resultado;
        }
    }
}