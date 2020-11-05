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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Tierra_acercamiento.xaml
    /// </summary>
    public partial class Tierra_acercamiento : Page
    {
        
        public Tierra_acercamiento()
        {
            InitializeComponent();
            
        }

        public void sliderTierra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Datos_Jupiter datjupp = new Datos_Jupiter();
            datjupp.ShowDialog();
        }

        private void TierraVolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        public void DatTiebtn_Click(object sender, RoutedEventArgs e)
        {
            Datos_Tierra datTierra = new Datos_Tierra();
            datTierra.Show();

         
        }
    }
}
