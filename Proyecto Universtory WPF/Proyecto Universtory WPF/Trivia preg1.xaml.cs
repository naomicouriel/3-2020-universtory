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
        public Trivia_preg1()
        {
            InitializeComponent();

            int tiempo = 45;

            DispatcherTimer temporizador = new DispatcherTimer();

            temporizador.Interval = new TimeSpan(0, 0, 0, 0, 1000);

            temporizador.Tick +=(a, b) =>
            {
                lblTimer.Content = Convert.ToString((tiempo--));

                if (tiempo == 0)
                {
                    MainWindow obj = (MainWindow)Window.GetWindow(this);
                    obj.frame.Content = new Trivia_Incorrecto();
                }
            };

            temporizador.Start();
        }


        

        private void btnResp1_Preg1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto();
        }

        private void btnResp2_Preg1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto();
        }

        private void btnResp3_Preg1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Correcto();
        }

        private void btnResp4_Preg1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto();
        }
    }
}
