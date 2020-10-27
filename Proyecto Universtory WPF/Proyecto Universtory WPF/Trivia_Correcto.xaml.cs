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
            contador++;

            switch (contador)
            {
                case 1:
                    MainWindow obj1 = (MainWindow)Window.GetWindow(this);
                    obj1.frame.Content = new Trivia_preg1();
                    break;
                case 2:
                    MainWindow obj2 = (MainWindow)Window.GetWindow(this);
                    obj2.frame.Content = new Trivia_preg2();
                    break;
                case 3:
                    MainWindow obj3 = (MainWindow)Window.GetWindow(this);
                    obj3.frame.Content = new Trivia_preg3();
                    break;
                case 4:
                    MainWindow obj4 = (MainWindow)Window.GetWindow(this);
                    obj4.frame.Content = new Trivia_preg4();
                    break;
                case 5:
                    MainWindow obj5 = (MainWindow)Window.GetWindow(this);
                    obj5.frame.Content = new Trivia_preg5();
                    break;
                case 6:
                    MainWindow obj6 = (MainWindow)Window.GetWindow(this);
                    obj6.frame.Content = new Trivia_preg6();
                    break;
                case 7:
                    MainWindow obj7 = (MainWindow)Window.GetWindow(this);
                    obj7.frame.Content = new Trivia_preg7();
                    break;
                case 8:
                    MainWindow obj8 = (MainWindow)Window.GetWindow(this);
                    obj8.frame.Content = new Trivia_preg8();
                    break;
                case 9:
                    MainWindow obj9 = (MainWindow)Window.GetWindow(this);
                    obj9.frame.Content = new Trivia_preg9();
                    break;
                case 10:
                    MainWindow obj10 = (MainWindow)Window.GetWindow(this);
                    obj10.frame.Content = new Trivia_preg10();
                    break;
                case 11:
                    MainWindow objResultados = (MainWindow)Window.GetWindow(this);
                    objResultados.frame.Content = new Trivia_resultados();
                    break;
            }

            
        }
    }
}
