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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        
        private void BtnSolClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Sol_acercamiento();
        }

        private void btnMercurio_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Mercurio_acercamiento();
        }

        private void btnVenus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Venus_acercamiento();
        }

        private void btnTierra_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Tierra_acercamiento();
        }

        private void btnMarte_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Marte_acercamiento();

        }

        private void btnJupiter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Júpiter_acercamiento();

        }

        private void btnSaturno_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Saturno_acercamiento();

        }

        private void btnUrano_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Urano_acercamiento();

        }

        private void btnNeptuno_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Neptuno_acercamiento();

        }

        private void VolPPbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Inicio2();
        }

        private void DatSolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Datos_SistemaSolar();
        }
    }
}
