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

        public int contBtn1 = 1;

        public int contBtn2 = 1;

        public int contBtn3 = 1;

        public int contBtn4 = 1;

        internal static int puntaje;

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
                    contBtn1 = 0;

                    contBtn2 = 0;

                    contBtn3 = 0;

                    contBtn4 = 0;
                    
                    btnSiguiente.Visibility = Visibility.Visible; 

                    btnResp1.Background = Brushes.Red;

                    btnResp2.Background = Brushes.Red;

                    btnResp3.Background = Brushes.Red;

                    btnResp4.Background = Brushes.Red;

                    btnSiguiente.IsEnabled = true;

                    temporizador.Stop();

                    puntaje = puntaje - 5;
                }
            };

            temporizador.Start();
        }

        void btnResp1_Click(object sender, RoutedEventArgs e)
        {

            if (contBtn1 == 1)
            {

                switch (contador)
                {
                    case 1:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 2:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 3:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 4:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 5:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 6:
                        btnResp1.Background = Brushes.Green;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn2 = 0;

                        contBtn3 = 0;

                        contBtn4 = 0;
                        break;
                    case 7:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 8:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 9:
                        btnResp1.Background = Brushes.Green;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn2 = 0;

                        contBtn3 = 0;

                        contBtn4 = 0;
                        break;
                    case 10:
                        btnResp1.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;

                }
            }
            contBtn1 = 0;
        }

        void btnResp2_Click(object sender, RoutedEventArgs e)
        {
            if (contBtn2 == 1)
            {

                switch (contador)
                {
                    case 1:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 2:
                        btnResp2.Background = Brushes.Green;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn1 = 0;

                        contBtn3 = 0;

                        contBtn4 = 0;
                        break;
                    case 3:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 4:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 5:
                        btnResp2.Background = Brushes.Green;

                        puntaje = puntaje + 10;

                        btnSiguiente.IsEnabled = true;

                        temporizador.Stop();

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn1 = 0;

                        contBtn3 = 0;

                        contBtn4 = 0;
                        break;
                    case 6:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 7:
                        btnResp2.Background = Brushes.Green;

                        puntaje = puntaje + 10;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn1 = 0;

                        contBtn3 = 0;

                        contBtn4 = 0;
                        break;
                    case 8:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 9:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 10:
                        btnResp2.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                }
            }
            contBtn2 = 0;
        }

        void btnResp3_Click(object sender, RoutedEventArgs e)
        {
            if (contBtn3 == 1)
            {

                switch (contador)
                {
                    case 1:
                        btnResp3.Background = Brushes.Green;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn1 = 0;

                        contBtn2 = 0;

                        contBtn4 = 0;
                        break;
                    case 2:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 3:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 4:
                        btnResp3.Background = Brushes.Green;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn1 = 0;

                        contBtn2 = 0;

                        contBtn4 = 0;
                        break;
                    case 5:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 6:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 7:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 8:
                        btnResp3.Background = Brushes.Green;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        contBtn1 = 0;

                        contBtn2 = 0;

                        contBtn4 = 0;
                        break;
                    case 9:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 10:
                        btnResp3.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                }
            }
            contBtn3 = 0;
        }

        void btnResp4_Click(object sender, RoutedEventArgs e)
        {
            if (contBtn4 == 1)
            {

                switch (contador)
                {
                    case 1:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 2:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 3:
                        btnResp4.Background = Brushes.Green;

                        puntaje = puntaje + 10;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        btnSiguiente.Visibility = Visibility.Visible;

                        contBtn1 = 0;

                        contBtn2 = 0;

                        contBtn3 = 0;
                        break;
                    case 4:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 5:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 6:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 7:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 8:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 9:
                        btnResp4.Background = Brushes.Red;

                        puntaje = puntaje - 2;
                        break;
                    case 10:
                        btnResp4.Background = Brushes.Green;

                        puntaje = puntaje + 10;

                        btnSiguiente.Visibility = Visibility.Visible;

                        temporizador.Stop();

                        btnSiguiente.IsEnabled = true;

                        contBtn1 = 0;

                        contBtn2 = 0;

                        contBtn3 = 0;
                        break;
                }
            }
            contBtn4 = 0;
        }


        void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            contBtn1 = 1;

            contBtn2 = 1;

            contBtn3 = 1;

            contBtn4 = 1;
            
            btnSiguiente.IsEnabled = false;

            btnSiguiente.Visibility = Visibility.Hidden;

            contador++;

            tiempo = 45;

            temporizador.Start();

            btnResp1.Background = Brushes.Transparent;

            btnResp2.Background = Brushes.Transparent;

            btnResp3.Background = Brushes.Transparent;

            btnResp4.Background = Brushes.Transparent;

            switch (contador)
            {
                //¿Cuál fue el primer planeta encontrado con un telescopio?

                case 2:
                    txtBlockPregunta.Text = "¿Cual fue el primer planeta encontrado con un telescopio?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "Marte";

                    btnResp2.Content = "Urano";

                    btnResp3.Content = "Mercurio";

                    btnResp4.Content = "Neptuno";
                    break;

                //¿Cual es el planeta mas caliente del Sistema Solar?


                case 3:
                    txtBlockPregunta.Text = "¿Cual es el planeta mas caliente del Sistema Solar?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "Mercurio";

                    btnResp2.Content = "La Tierra";

                    btnResp3.Content = "Neptuno";

                    btnResp4.Content = "Venus";
                    break;

                //¿Cuanto tiempo tarda el sistema solar en completar su orbita alrededor del centro de la galaxia?

                case 4:
                    txtBlockPregunta.Text = "¿Cuanto tiempo tarda el sistema solar en completar su orbita alrededor del centro de la galaxia?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "1.200 millones de años";

                    btnResp2.Content = "150.000 años";

                    btnResp3.Content = "230 millones de años";

                    btnResp4.Content = "8,4 millones de años";
                    break;

                //¿Cuales son los unicos planetas que rotan en direccion opuesta a los demas planetas?

                case 5:
                    txtBlockPregunta.Text = "¿Cuales son los unicos planetas que rotan en direccion opuesta a los demas planetas?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "La Tierra y Marte";

                    btnResp2.Content = "Urano y Venus";

                    btnResp3.Content = "Saturno y Jupiter";

                    btnResp4.Content = "Mercurio y Venus";
                    break;

                //¿Cuantos planetas tienen anillos?

                case 6:
                    txtBlockPregunta.Text = "¿Cuantos planetas tienen anillos?";

                    txtBlockPregunta.FontSize = 72;

                    btnResp1.Content = "4";

                    btnResp2.Content = "2";

                    btnResp3.Content = "Ninguno";

                    btnResp4.Content = "Todos";
                    break;

                //¿Que planeta se cree que haya podido albergar vida en el pasado dadas sus condiciones, ademas de la Tierra?

                case 7:
                    txtBlockPregunta.Text = "¿Que planeta se cree que haya podido albergar vida en el pasado dadas sus condiciones, ademas de la Tierra?";

                    txtBlockPregunta.FontSize = 40;

                    btnResp1.Content = "Mercurio";

                    btnResp2.Content = "Marte";

                    btnResp3.Content = "Urano";

                    btnResp4.Content = "Saturno";
                    break;

                //¿Cual es el objeto más brillante del sistema solar despues del sol?

                case 8:
                    txtBlockPregunta.Text = "¿Cual es el objeto más brillante del sistema solar después del sol?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "Jupiter";

                    btnResp2.Content = "La Tierra";

                    btnResp3.Content = "La Luna";

                    btnResp4.Content = "Venus";
                    break;

                //Como se llama la unica nave que abandono el sistema solar?

                case 9:
                    txtBlockPregunta.Text = "¿Como se llama la unica nave que abandono el sistema solar?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "Voyager 1";

                    btnResp2.Content = "Apolo 11";

                    btnResp3.Content = "Solar Orbiter";

                    btnResp4.Content = "Por ahora ninguna nave abandono el sistema solar";
                    break;

                //¿Como se llama la nube gigante que formo el sistema solar?

                case 10:
                    txtBlockPregunta.Text = "¿Como se llama la nube gigante que formo el sistema solar?";

                    txtBlockPregunta.FontSize = 50;

                    btnResp1.Content = "Niebla Creadora";

                    btnResp2.Content = "Solsticio";

                    btnResp3.Content = "Big-Bang";

                    btnResp4.Content = "Nebulosa";
                    break;
                case 11:
                    MainWindow obj = (MainWindow)Window.GetWindow(this);
                    obj.frame.Content = new Trivia_resultados();
                    break;
            }
        }
    }
}