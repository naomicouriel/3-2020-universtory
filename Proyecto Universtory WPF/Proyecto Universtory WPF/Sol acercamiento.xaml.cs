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
    /// Lógica de interacción para Sol_acercamiento.xaml
    /// </summary>
    public partial class Sol_acercamiento : Page
    {
        public Sol_acercamiento()
        {
            InitializeComponent();
            sliderSol.Visibility = Visibility.Hidden;
            deslizalbl.Visibility = Visibility.Hidden;
        }
        int contadormas = 0;

        private void sliderSol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double sliderSol = e.NewValue;

            if (sliderSol == 0)
            {
                Uri resourceUri = new Uri("Resources/sol.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
                this.Background = icon;
            }

            else if (sliderSol == 33)
            {
                Uri resourceUri = new Uri("Resources/etapa 1 sol.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
                this.Background = icon;
            }

            else if (sliderSol == 66)
            {
                Uri resourceUri = new Uri("Resources/etapa 2 sol.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
                this.Background = icon;
            }

            else if (sliderSol == 99)
            {
                Uri resourceUri = new Uri("Resources/etapa 3 sol.png", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetRemoteStream(resourceUri);
                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var icon = new ImageBrush { ImageSource = temp };
                this.Background = icon;
            }
        }

        private void VolSolbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Page1();
        }

        private void DatSolbtn_Click(object sender, RoutedEventArgs e)
        {
            if (sliderSol.Value == 0)
            {
                Datos_Sol datSol = new Datos_Sol();
                datSol.ShowDialog();
            }
            else if (sliderSol.Value == 33)
            {
                Datos_Sol_E1 datSolE1 = new Datos_Sol_E1();
                datSolE1.ShowDialog();
            }
            else if (sliderSol.Value == 66)
            {
                Datos_Sol_E2 datSolE2 = new Datos_Sol_E2();
                datSolE2.ShowDialog();
            }
            else if (sliderSol.Value == 99)
            {
                Datos_Sol_E3 datSolE3 = new Datos_Sol_E3();
                datSolE3.ShowDialog();
            }
        }

        private void masbtn_Click(object sender, RoutedEventArgs e)
        {
            if (contadormas == 0)
            {
                sliderSol.Visibility = Visibility.Visible;
                masbtn.Content = "-";
                deslizalbl.Visibility = Visibility.Visible;
                contadormas++;
            }
            else if (contadormas == 1)
            {
                sliderSol.Visibility = Visibility.Hidden;
                masbtn.Content = "+";
                deslizalbl.Visibility = Visibility.Hidden;
                contadormas--;
            }
        }
    }
}
