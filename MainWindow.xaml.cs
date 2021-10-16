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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tarea5Aplicada.Ejercico_del_Cap_10_y_Cap_12;

namespace Tarea5Aplicada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Cap10Ejercicio4 Ce10 = new Cap10Ejercicio4();
                Ce10.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Cap12Ejercicio1 Ce12 = new Cap12Ejercicio1();
            Ce12.Show();
        }
    }
}
