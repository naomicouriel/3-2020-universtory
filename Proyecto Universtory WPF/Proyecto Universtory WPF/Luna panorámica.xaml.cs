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
    /// Lógica de interacción para Luna_panorámica.xaml
    /// </summary>
    public partial class Luna_panorámica : Page
    {
        public Luna_panorámica()
        {
            InitializeComponent();
            flecha1.Visibility = Visibility.Hidden;
        }
        int contador = 0;

        private void btnPanoLuna_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Luna_acercamiento();
        }

        private void flecha2_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                flecha1.Visibility = Visibility.Visible;
                datcuritxt.Text = "Una persona que pesa 45 kilos en la tierra pesaría 8,05 kilos en la Luna.";
                datcuritxt.Height = 137;
            }
            else if (contador == 2)
            {
                datcuritxt.Text = "La Luna se aleja aproximadamente 3.8 cm de nuestro planeta cada año. Por esta razon, dentro de 50 mil millones de años la Luna tardara 47 días en dar vuelta a la Tierra, en vez de 27.";
                datcuritxt.Height = 310;
            }
            else if (contador == 3)
            {
                datcuritxt.Text = "En la Luna es imposible silbar.";
                datcuritxt.Height = 70;
            }
            else if (contador == 4)
            {
                datcuritxt.Text = "Ha llegando mas gente a la Luna que a las profundidades de los oceanos.";
                flecha2.Visibility = Visibility.Visible;
                datcuritxt.Height = 137;
            }
            else if (contador == 5)
            {
                datcuritxt.Text = "Sin traje espacial en la Luna, la sangre hierve instantáneamente.";
                flecha2.Visibility = Visibility.Hidden;
            }
            else if (contador == 0)
            {
                flecha1.Visibility = Visibility.Hidden;
                datcuritxt.Text = "Se necesitan cientos de miles de lunas para igualar el brillo del sol.";
            }
        }

        private void flecha1_Click(object sender, RoutedEventArgs e)
        {
            contador--;
            if (contador == 1)
            {
                flecha1.Visibility = Visibility.Visible;
                datcuritxt.Text = "Una persona que pesa 45 kilos en la tierra pesaría 8,05 kilos en la Luna.";
                datcuritxt.Height = 137;
            }
            else if (contador == 2)
            {
                datcuritxt.Text = "La Luna se aleja aproximadamente 3.8 cm de nuestro planeta cada año. Por esta razon, dentro de 50 mil millones de años la Luna tardara 47 días en dar vuelta a la Tierra, en vez de 27.";
                datcuritxt.Height = 310;
            }
            else if (contador == 3)
            {
                datcuritxt.Text = "En la Luna es imposible silbar.";
                datcuritxt.Height = 70;
            }
            else if (contador == 4)
            {
                datcuritxt.Text = "Ha llegado mas gente a la Luna que a las profundidades de los oceanos.";
                flecha2.Visibility = Visibility.Visible;
                datcuritxt.Height = 137;
            }
            else if (contador == 5)
            {
                datcuritxt.Text = "Sin traje espacial en la Luna, la sangre hierve instantáneamente.";
                flecha2.Visibility = Visibility.Hidden;
            }
            else if (contador == 0)
            {
                flecha1.Visibility = Visibility.Hidden;
                datcuritxt.Text = "Se necesitan cientos de miles de lunas para igualar el brillo del sol.";
            }
        }
    }
}
