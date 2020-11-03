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
    /// Lógica de interacción para Trivia_Correcto.xaml
    /// </summary>
    public partial class Trivia_Correcto : Page
    {
        public Trivia_Correcto()
        {
            InitializeComponent();
        }

        

        int contador = 1;

        private void btn_continuar_Click(object sender, RoutedEventArgs e)
        {

            MainWindow obj1 = (MainWindow)Window.GetWindow(this);
            obj1.frame.Content = new Trivia_preg2();


        }



    }
}
