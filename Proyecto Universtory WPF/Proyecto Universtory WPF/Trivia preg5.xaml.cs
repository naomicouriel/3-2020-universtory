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
    /// Lógica de interacción para Trivia_preg5.xaml
    /// </summary>
    public partial class Trivia_preg5 : Page
    {
        public Trivia_preg5()
        {
            InitializeComponent();
        }

        private void btnResp1_Preg5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto5();
        }

        private void btnResp2_Preg5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Correcto5();
        }

        private void btnResp3_Preg5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto5();
        }

        private void btnResp4_Preg5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_Incorrecto5();
        }
    }
}
