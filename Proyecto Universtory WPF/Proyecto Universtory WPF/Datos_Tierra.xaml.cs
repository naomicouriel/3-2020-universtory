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
using System.Windows.Shapes;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Datos_Tierra.xaml
    /// </summary>
    public partial class Datos_Tierra : Window
    {
        public Datos_Tierra()
        {
            InitializeComponent();
        }

        private void salDatTie_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
