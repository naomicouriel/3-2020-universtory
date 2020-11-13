using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Inicio2.xaml
    /// </summary>
    public partial class Inicio2 : Page
    {
        SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.universtory_song);

        public Inicio2()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_inicio();
        }
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window main = Window.GetWindow(this);
            main.Close();
        }

        private void FormLoad(object sender, RoutedEventArgs e)
        {
           var st = (Storyboard)Resources["Movimiento"];
            st.Begin(btnStart);

           var trivia = (Storyboard)Resources["Trivia"];
            trivia.Begin(btnTrivia);

            menuVol.Visibility = Visibility.Hidden;
            
            player.PlayLooping();

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menuVol.Visibility = Visibility.Visible;
        }

        private void btnStopMusic_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void btnPlayMusic_Click(object sender, RoutedEventArgs e)
        {
            player.PlayLooping();
        }

        private void btnCerrarMenu_Click(object sender, RoutedEventArgs e)
        {
            menuVol.Visibility = Visibility.Hidden;
        }

    }
}
