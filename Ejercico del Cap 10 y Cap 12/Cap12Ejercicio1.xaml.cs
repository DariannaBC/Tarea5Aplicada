using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tarea5Aplicada.Entidades;
namespace Tarea5Aplicada.Ejercico_del_Cap_10_y_Cap_12
{
    /// <summary>
    /// Interaction logic for Cap12Ejercicio1.xaml
    /// </summary>
    public partial class Cap12Ejercicio1 : Window
    {
        Factorial facto = new Factorial();
        public Cap12Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = CalculoFactorial(facto.Numero = Utilidades.ToInt(NumeroTextBox.Text.ToString())).ToString();
        }

        private object CalculoFactorial(object p)
        {
            throw new NotImplementedException();
        }

        private int CalculoFactorial(int numero)
        {
            int j;
            for (j = numero; j >= 1; j--)
            {
                facto.FactorialN *= j;
            }

            return facto.FactorialN;
        }
    }
}

