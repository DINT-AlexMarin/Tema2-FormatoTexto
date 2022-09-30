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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Azul_RadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            texto_TextBlock.Foreground = Brushes.Blue;
        }

        private void Negrita_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                texto_TextBlock.FontWeight = FontWeights.Bold;

        }
        private void Negrita_Unchecked(object sender, RoutedEventArgs e)
        {
            texto_TextBlock.FontWeight = FontWeights.Normal;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                texto_TextBlock.FontStyle = FontStyles.Italic;

        }
        private void Cursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            texto_TextBlock.FontStyle = FontStyles.Normal;

        }

        private void Rojo_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
         
            texto_TextBlock.Foreground = Brushes.Red;
        }

        private void Verde_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            texto_TextBlock.Foreground = Brushes.Green;
        }

        private void Texto_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            texto_TextBlock.Text = Texto_TextBox.Text;
        }
    }
}
