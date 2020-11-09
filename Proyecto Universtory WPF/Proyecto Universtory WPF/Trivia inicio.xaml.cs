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
    /// Lógica de interacción para Trivia_inicio.xaml
    /// </summary>
    public partial class Trivia_inicio : Page
    {
        public Trivia_inicio()
        {
            InitializeComponent();

            lblTriviaInicio.Content = "En esta trivia vas a poner a prueba todo lo que aprendiste\nsobre nuestro sistema solar, asi que si crees que\ntodavia no lo tenes muy claro no empiezes.Son\n10 preguntas, cada una con 4 respuestas  pero solo una\ncorrecta. Si la respuesta que elegis es incorrecta se pone\nen rojo y si es correcta se pone en verde.\nPara pasar a la siguinte pregunta toca el boton  SIGUIENTE.\nCuando termines la trivia podes ver tus resultados.";
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = (MainWindow)Window.GetWindow(this);
            obj.frame.Content = new Trivia_preg1();
        }
    }
}
