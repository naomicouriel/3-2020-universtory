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

        public Tierra_acercamiento()
        {
            InitializeComponent();
            
        }

        public void sliderTierra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double sliderTierra = e.NewValue;

            if (sliderTierra == 20)
            {
                Uri resourceUri = new Uri("Resources/Recursos/universtory fondo.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };

                this.Background = icon;
                imgLuna.Visibility = Visibility.Hidden;
            }

            else if (sliderTierra == 40)
            {
                Uri resourceUri = new Uri("Resources/Recursos/universtory fondo.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };

                this.Background = icon;
                imgLuna.Visibility = Visibility.Hidden;
            }

            else if (sliderTierra == 60)
            {
                Uri resourceUri = new Uri("Resources/Recursos/universtory fondo.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };

                this.Background = icon;
                imgLuna.Visibility = Visibility.Hidden;
            }

            else if (sliderTierra == 80)
            {
                Uri resourceUri = new Uri("Resources/Recursos/universtory fondo.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };

                this.Background = icon;
                imgLuna.Visibility = Visibility.Hidden;
            }

            else if (sliderTierra == 100)
            {
                Uri resourceUri = new Uri("Resources/Recursos/universtory fondo.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };

                this.Background = icon;
                imgLuna.Visibility = Visibility.Hidden;
            }
        }

        private void TierraVolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        public void DatTiebtn_Click(object sender, RoutedEventArgs e)
        {
            if (sliderTierra.Value == 0)
            {
                Datos_Tierra datTierra = new Datos_Tierra();
                datTierra.ShowDialog();
            }

            else if (sliderTierra.Value == 20)
            {
                Datos_Tierra_E1 datTieE1 = new Datos_Tierra_E1();
                datTieE1.ShowDialog();
            }
            else if (sliderTierra.Value == 40)
            {
                Datos_Tierra_E2 datTieE2 = new Datos_Tierra_E2();
                datTieE2.ShowDialog();
            }
            else if (sliderTierra.Value == 60)
            {
                Datos_Tierra_E3 datTieE3 = new Datos_Tierra_E3();
                datTieE3.ShowDialog();
            }
            else if (sliderTierra.Value == 80)
            {
                Datos_Tierra_E4 datTieE4 = new Datos_Tierra_E4();
                datTieE4.ShowDialog();
            }
            else if (sliderTierra.Value == 100)
            {
                Datos_Tierra_E5 datTieE5 = new Datos_Tierra_E5();
                datTieE5.ShowDialog();
            }
         
        }

        private void EllipseTierra_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Tierra_panorámica();
        }

        private void EllipseLuna_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Luna_acercamiento();
        }
    }
}
