﻿using System;
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
    /// Lógica de interacción para Datos_Marte.xaml
    /// </summary>
    public partial class Datos_Marte : Window
    {
        public Datos_Marte()
        {
            InitializeComponent();
        }

        private void salirDatMar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
