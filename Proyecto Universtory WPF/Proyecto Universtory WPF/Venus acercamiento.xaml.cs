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
    /// Lógica de interacción para Venus_acercamiento.xaml
    /// </summary>
    public partial class Venus_acercamiento : Page
    {
        public Venus_acercamiento()
        {
            InitializeComponent();
        }

        private void VolVenbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        private void DatVenbtn_Click(object sender, RoutedEventArgs e)
        {
            Datos_Venus datVen = new Datos_Venus();
            datVen.ShowDialog();
        }
    }
}
