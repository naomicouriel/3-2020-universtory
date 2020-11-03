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
    /// Lógica de interacción para Trivia_preg10.xaml
    /// </summary>
    public partial class Trivia_preg10 : Page
    {
        public Trivia_preg10()
        {
            InitializeComponent();
        }

        private void btnResp1_Preg10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto10();
        }

        private void btnResp2_Preg10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto10();
        }

        private void btnResp3_Preg10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto10();
        }

        private void btnResp4_Preg10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Correcto10();
        }
    }
}
