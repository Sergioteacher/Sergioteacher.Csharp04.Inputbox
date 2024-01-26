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

namespace Sergioteacher.Csharp04.Inputbox
{
    /// <summary>
    /// Lógica de interacción para WindowInput.xaml
    /// </summary>
    public partial class WindowInput : Window
    {
        MainWindow Inicio;
        public WindowInput(MainWindow ventanaInicio)
        {
            Inicio = ventanaInicio;
            InitializeComponent();
            
        }

        private void BIntro_Click(object sender, RoutedEventArgs e)
        {
            Inicio.data = MiTexto.Text;
            Inicio.Show();
            this.Hide();
        }

        private void VentanaInput_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                //MessageBox.Show("Hola, mensaje al capturar ->  X");
                e.Cancel = true;
                Inicio.data = "";
                Inicio.Show();
                this.Hide();
            }
        }

        private void VentanaInput_Activated(object sender, EventArgs e)
        {
            MiTexto.Text = "";
        }
    }
}
