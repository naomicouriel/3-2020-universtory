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
using System.Windows.Media.Animation;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Trivia_inicio.xaml
    /// </summary>
    public partial class Trivia_inicio : Page
    {
        public Trivia_inicio()
        {
            InitializeComponent();

            var fadeAnimation = new DoubleAnimation();
            fadeAnimation.From = 1;
            fadeAnimation.To = 0;

            fadeAnimation.AutoReverse = true;

            InfoTrivia.BeginAnimation(TextBlock.OpacityProperty, fadeAnimation);
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_preg1();
        }

        private void atrasTrivInibtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Inicio2();
        }
    }
}
