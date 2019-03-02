using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RotationApp
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;

        void AdicionarValor(object sender, System.EventArgs e)
        {
            valor = valor+5;
            label_rotation.Rotation = valor;
        }

        void SubtrairValor(object sender, System.EventArgs e)
        {
            valor = valor-5;
            label_rotation.Rotation = valor;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
