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
    /// Lógica de interacción para Datos_Luna.xaml
    /// </summary>
    public partial class Datos_Luna : Window
    {
        public Datos_Luna()
        {
            InitializeComponent();
        }

        private void salDatLun_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
