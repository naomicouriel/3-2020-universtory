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
    /// Lógica de interacción para Tierra_acercamiento.xaml
    /// </summary>
    public partial class Tierra_acercamiento : Page
    {
        private double valSliderT = 0;
        public Tierra_acercamiento()
        {
            InitializeComponent();
            
        }

        public void sliderTierra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double valSliderT = e.NewValue;
            valSliderT = sliderTierra.Value;
            /*if (valSliderT == 20) { 
            //Código para cambiar el fondo de la page
             
            Uri resourceUri = new Uri("Resources/TuImagen.jpg", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var icon = new ImageBrush { ImageSource = temp };
            }*/
        }

        private void TierraVolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        public void DatTiebtn_Click(object sender, RoutedEventArgs e)
        {
            if (valSliderT == 0) { 
            Datos_Tierra datTierra = new Datos_Tierra();
            datTierra.ShowDialog();
            }
            if (valSliderT == 20)
            {
                Datos_Tierra_E1 datTieE1 = new Datos_Tierra_E1();
                datTieE1.ShowDialog();
            }
        }
    }
}
