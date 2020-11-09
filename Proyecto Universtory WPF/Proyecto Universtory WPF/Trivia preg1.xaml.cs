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
using System.Windows.Threading;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Trivia_preg1.xaml
    /// </summary>
    public partial class Trivia_preg1 : Page
    {
        int tiempo = 45;
        int contador = 1;
        DispatcherTimer temporizador = new DispatcherTimer();

        public Trivia_preg1()
        {
            InitializeComponent();

            temporizador.Interval = new TimeSpan(0, 0, 0, 0, 1000);

            temporizador.Tick += (a, b) =>
            {
                lblTimer.Content = Convert.ToString((tiempo--));

                if (tiempo == 0)
                {

                }
            };

            temporizador.Start();
        }

        void btnResp1_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Stop();



            // Falta como cambiar el texto todavia no se 

            switch (contador)
            {
                case 1:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 2:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 3:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 4:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 5:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 6:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 7:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 8:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 9:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 10:
                    btnResp1.Background = Brushes.Red;
                    break;

            }
        }

        void btnResp2_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Stop();

            switch (contador)
            {
                case 1:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 2:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 3:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 4:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 5:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 6:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 7:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 8:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 9:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 10:
                    btnResp1.Background = Brushes.Red;
                    break;
            }
        }

        void btnResp3_Preg1_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Stop();

            switch (contador)
            {
                case 1:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 2:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 3:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 4:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 5:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 6:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 7:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 8:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 9:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 10:
                    btnResp1.Background = Brushes.Red;
                    break;
            }
        }

        void btnResp4_Preg1_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Stop();


            switch (contador)
            {
                case 1:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 2:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 3:
                    btnResp1.Background = Brushes.Green;
                    break;
                case 4:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 5:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 6:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 7:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 8:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 9:
                    btnResp1.Background = Brushes.Red;
                    break;
                case 10:
                    btnResp1.Background = Brushes.Green;
                    break;
            }
        }


        void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            contador++;

            switch (contador)
            {
                case 2:

                    break;

            }
        }

        private void btnResp3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnResp4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}