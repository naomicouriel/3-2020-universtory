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
    /// Lógica de interacción para Sol_acercamiento.xaml
    /// </summary>
    public partial class Sol_acercamiento : Page
    {
        public Sol_acercamiento()
        {
            InitializeComponent();
        }

        private void sliderSol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double sliderSol = e.NewValue;

            if (sliderSol == 33)
            {
                Uri resourceUri = new Uri("Resources/TuImagen.jpg", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
            }

            else if (sliderSol == 66)
            {
                Uri resourceUri = new Uri("Resources/TuImagen.jpg", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
            }

            else if (sliderSol == 99)
            {
                Uri resourceUri = new Uri("Resources/TuImagen.jpg", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
            }
        }

        private void VolSolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        private void DatSolbtn_Click(object sender, RoutedEventArgs e)
        {
            Datos_Sol datSol = new Datos_Sol();
            datSol.ShowDialog();
        }
        
    }
}
