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
                    btnResp2.Background = Brushes.Red;
                    break;
                case 2:
                    btnResp2.Background = Brushes.Green;
                    break;
                case 3:
                    btnResp2.Background = Brushes.Red;
                    break;
                case 4:
                    btnResp2.Background = Brushes.Red;
                    break;
                case 5:
                    btnResp2.Background = Brushes.Green;
                    break;
                case 6:
                    btnResp2.Background = Brushes.Red;
                    break;
                case 7:
                    btnResp2.Background = Brushes.Green;
                    break;
                case 8:
                    btnResp2.Background = Brushes.Red;
                    break;
                case 9:
                    btnResp2.Background = Brushes.Red;
                    break;
                case 10:
                    btnResp2.Background = Brushes.Red;
                    break;
            }
        }

        void btnResp3_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Stop();

            switch (contador)
            {
                case 1:
                    btnResp3.Background = Brushes.Green;
                    break;
                case 2:
                    btnResp3.Background = Brushes.Red;
                    break;
                case 3:
                    btnResp3.Background = Brushes.Red;
                    break;
                case 4:
                    btnResp3.Background = Brushes.Green;
                    break;
                case 5:
                    btnResp3.Background = Brushes.Red;
                    break;
                case 6:
                    btnResp3.Background = Brushes.Red;
                    break;
                case 7:
                    btnResp3.Background = Brushes.Red;
                    break;
                case 8:
                    btnResp3.Background = Brushes.Green;
                    break;
                case 9:
                    btnResp3.Background = Brushes.Red;
                    break;
                case 10:
                    btnResp3.Background = Brushes.Red;
                    break;
            }
        }

        void btnResp4_Click(object sender, RoutedEventArgs e)
        {
            temporizador.Stop();


            switch (contador)
            {
                case 1:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 2:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 3:
                    btnResp4.Background = Brushes.Green;
                    break;
                case 4:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 5:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 6:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 7:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 8:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 9:
                    btnResp4.Background = Brushes.Red;
                    break;
                case 10:
                    btnResp4.Background = Brushes.Green;
                    break;
            }
        }


        void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            contador++;

            tiempo = 45;

            temporizador.Start();

            btnResp1.Background = Brushes.Transparent;

            btnResp2.Background = Brushes.Transparent;

            btnResp3.Background = Brushes.Transparent;

            btnResp4.Background = Brushes.Transparent;

            switch (contador)
            {
                case 2:
                    btnResp1.Content = "Resp1-Preg2";

                    btnResp2.Content = "Resp3-Preg2";

                    btnResp3.Content = "Resp3-Preg2";

                    btnResp4.Content = "Resp4-Preg2";
                    break;
                case 3:
                    btnResp1.Content = "Resp1-Preg3";

                    btnResp2.Content = "Resp3-Preg3";

                    btnResp3.Content = "Resp3-Preg3";

                    btnResp4.Content = "Resp4-Preg3";
                    break;
                case 4:
                    btnResp1.Content = "Resp1-Preg4";

                    btnResp2.Content = "Resp3-Preg4";

                    btnResp3.Content = "Resp3-Preg4";

                    btnResp4.Content = "Resp4-Preg4";
                    break;
                case 5:
                    btnResp1.Content = "Resp1-Preg5";

                    btnResp2.Content = "Resp3-Preg5";

                    btnResp3.Content = "Resp3-Preg5";

                    btnResp4.Content = "Resp4-Preg5";
                    break;
                case 6:
                    btnResp1.Content = "Resp1-Preg6";

                    btnResp2.Content = "Resp3-Preg6";

                    btnResp3.Content = "Resp3-Preg6";

                    btnResp4.Content = "Resp4-Preg6";
                    break;
                case 7:
                    btnResp1.Content = "Resp1-Preg7";

                    btnResp2.Content = "Resp3-Preg7";

                    btnResp3.Content = "Resp3-Preg7";

                    btnResp4.Content = "Resp4-Preg7";
                    break;
                case 8:
                    btnResp1.Content = "Resp1-Preg8";

                    btnResp2.Content = "Resp3-Preg8";

                    btnResp3.Content = "Resp3-Preg8";

                    btnResp4.Content = "Resp4-Preg8";
                    break;
                case 9:
                    btnResp1.Content = "Resp1-Preg9";

                    btnResp2.Content = "Resp3-Preg9";

                    btnResp3.Content = "Resp3-Preg9";

                    btnResp4.Content = "Resp4-Preg9";
                    break;
                case 10:
                    btnResp1.Content = "Resp1-Preg10";

                    btnResp2.Content = "Resp3-Preg10";

                    btnResp3.Content = "Resp3-Preg10";

                    btnResp4.Content = "Resp4-Preg10";
                    break;
                case 11:
                    MainWindow obj = (MainWindow)Window.GetWindow(this);
                    obj.frame.Content = new Trivia_resultados();
                    break;



            }
            
            //btnResp1.Content = FindResource("Resp1");
            //btnResp2.Content = FindResource("Resp2");
            //btnResp3.Content = FindResource("Resp3");
            //btnResp4.Content = FindResource("Resp4");

        }
    }
}