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
    /// Lógica de interacción para Tierra_panorámica.xaml
    /// </summary>
    public partial class Tierra_panorámica : Page
    {
        public Tierra_panorámica()
        {
            InitializeComponent();
            flecha1.Visibility = Visibility.Hidden;
        }
        int contador = 0;

        private void TierraVolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Tierra_acercamiento();
        }

        private void flecha2_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                flecha1.Visibility = Visibility.Visible;
                datcuritxt.Text = "La Voyager 1 de la NASA es la única nave espacial hasta ahora que ha abandonado nuestro sistema solar. Otras cuatro naves espaciales llegarán eventualmente al espacio interestelar.";
            }
            else if (contador == 2)
            {
                datcuritxt.Text = "Más de 300 naves espaciales robóticas han explorado destinos más allá de la órbita terrestre, incluidos 24 astronautas que orbitaron la luna.";
            }
            else if (contador == 3)
            {
                datcuritxt.Text = "Si la Luna no existiera, los dias en la Tierra durarian 6 horas";
                flecha2.Visibility = Visibility.Visible;
            }
            else if (contador == 4)
            {
                datcuritxt.Text = "Nuestro sistema solar tarda unos 230 millones de años en completar su órbita alrededor del centro de la galaxia.";
                flecha2.Visibility = Visibility.Hidden;
            }
            else if (contador == 0)
            {
                flecha1.Visibility = Visibility.Hidden;
                datcuritxt.Text = "La Tierra es el unico lugar en el Sistema Solar donde el agua puede estar en sus tres estados: liquido, gaseoso y solido";
            }
        }

        private void flecha1_Click(object sender, RoutedEventArgs e)
        {
            contador--;
            if (contador == 1)
            {
                flecha1.Visibility = Visibility.Visible;
                datcuritxt.Text = "La Voyager 1 de la NASA es la única nave espacial hasta ahora que ha abandonado nuestro sistema solar. Otras cuatro naves espaciales llegarán eventualmente al espacio interestelar.";
            }
            else if (contador == 2)
            {
                datcuritxt.Text = "Más de 300 naves espaciales robóticas han explorado destinos más allá de la órbita terrestre, incluidos 24 astronautas que orbitaron la luna.";
            }
            else if (contador == 3)
            {
                datcuritxt.Text = "Si la Luna no existiera, los dias en la Tierra durarian 6 horas";
                flecha2.Visibility = Visibility.Visible;
            }
            else if (contador == 4)
            {
                datcuritxt.Text = "Nuestro sistema solar tarda unos 230 millones de años en completar su órbita alrededor del centro de la galaxia.";
                flecha2.Visibility = Visibility.Hidden;
            }
            else if (contador == 0)
            {
                flecha1.Visibility = Visibility.Hidden;
                datcuritxt.Text = "La Tierra es el unico lugar en el Sistema Solar donde el agua puede estar en sus tres estados: liquido, gaseoso y solido";
            }
        }
    }
}
