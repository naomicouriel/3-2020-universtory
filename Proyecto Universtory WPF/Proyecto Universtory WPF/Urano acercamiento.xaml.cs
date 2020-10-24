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

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Urano_acercamiento.xaml
    /// </summary>
    public partial class Urano_acercamiento : Page
    {
        public Urano_acercamiento()
        {
            InitializeComponent();
        }

        private void VolUrabtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        private void DatUrabtn_Click(object sender, RoutedEventArgs e)
        {
            Datos_Urano datUra = new Datos_Urano();
            datUra.ShowDialog();
        }
    }
}
