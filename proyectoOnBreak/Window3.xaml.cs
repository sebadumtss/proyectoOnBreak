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

namespace proyectoOnBreak
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboxTipEvento.Items.Add("Opción 1");
            cboxTipEvento.Items.Add("Opción 2");
            cboxTipEvento.Items.Add("Opción 3");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana actual
            this.Close();

            // Mostrar la ventana principal
            Application.Current.MainWindow.Show();
        }
    }
}
