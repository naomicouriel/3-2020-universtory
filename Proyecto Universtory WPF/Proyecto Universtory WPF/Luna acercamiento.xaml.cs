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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Luna_acercamiento.xaml
    /// </summary>
    public partial class Luna_acercamiento : Page
    {
        public Luna_acercamiento()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Uri resourceUri = new Uri("Resources/TuImagen.jpg", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var icon = new ImageBrush { ImageSource = temp };

        }

        private void LunaVolv_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Tierra_acercamiento();
        }

        private void DatLunbtn_Click(object sender, RoutedEventArgs e)
        {
            Datos_Luna datLuna = new Datos_Luna();
            datLuna.ShowDialog();
        }

        private void EllipseLuna_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Luna_panorámica();
        }
    }
}
