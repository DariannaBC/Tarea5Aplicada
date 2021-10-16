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
    /// Interaction logic for Cap10Ejercicio4.xaml
    /// </summary>
    public partial class Cap10Ejercicio4 : Window
    {
        Poligono poli = new Poligono();
        public Cap10Ejercicio4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = Multiplicar(poli.Lados = Utilidades.ToInt(LadosTextBox.Text), poli.Longitud = Utilidades.ToInt(LongitudTextBox.Text)).ToString();
        }
        private int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            return resultado;
        }
    }
}

