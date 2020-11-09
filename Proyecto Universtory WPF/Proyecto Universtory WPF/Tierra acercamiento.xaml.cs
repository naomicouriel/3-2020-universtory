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
        public double slidertierra;

        public Tierra_acercamiento()
        {
            InitializeComponent();
            
        }

        public void sliderTierra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double slidertierra = e.NewValue;

            if (slidertierra == 20)
            {
                Uri resourceUri = new Uri("Resources/Recursos/universtory fondo.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
            }
        }

        private void TierraVolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        public void DatTiebtn_Click(object sender, RoutedEventArgs e)
        {
            if (slidertierra == 0)
            {
                Datos_Tierra datTierra = new Datos_Tierra();
                datTierra.ShowDialog();
            }

            else if (slidertierra == 20)
            {
                Datos_Jupiter datjupp = new Datos_Jupiter();
                datjupp.ShowDialog();
            }

         
        }

        private void EllipseTierra_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Tierra_panorámica();
        }

        private void EllipseLuna_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Luna_acercamiento();
        }
    }
}
