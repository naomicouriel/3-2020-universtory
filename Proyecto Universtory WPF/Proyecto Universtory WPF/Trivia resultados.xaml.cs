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
using System.Windows.Shapes;

namespace Proyecto_Universtory_WPF
{
    /// <summary>
    /// Lógica de interacción para Trivia_resultados.xaml
    /// </summary>
    public partial class Trivia_resultados : Page
    {

        public Trivia_resultados()
        {
            InitializeComponent();
        }

        private void triviaResbtnVolv_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Inicio2();
        }

        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lblResFinal.Content = ("El resultado es " + Trivia_preg1.puntaje + "/100");
        }
    }
}
