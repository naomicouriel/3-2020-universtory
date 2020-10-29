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
    /// Lógica de interacción para Mercurio_acercamiento.xaml
    /// </summary>
    public partial class Mercurio_acercamiento : Page
    {
        public Mercurio_acercamiento()
        {
            InitializeComponent();
        }

        private void VolMerbtn_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();

        }

        private void DatMerbtn_Click_1(object sender, RoutedEventArgs e)
        {
            Datos_Mercurio datMer = new Datos_Mercurio();
            datMer.ShowDialog();
        }
    }
}
