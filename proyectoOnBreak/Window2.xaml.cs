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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private List<string> lista = new List<string>();

        private void btnMostrarLista_Click(object sender, RoutedEventArgs e)
        {
            // Agrega algunos elementos a la lista
            lista.Add("Nombre Empresa: Río Bueno - Rut Empresa: 96838800‑2 - Número de teléfono: 975648378 -  Correo: rio.bueno@gmail.com");
            lista.Add("Nombre Empresa: San Carlos - Rut Empresa: 99581960‑0 -  Número de teléfono: 985736583 -  Correo: scarlos@gmail.com ");
            lista.Add("Nombre Empresa: Sotrasal -  Rut Empresa: 70016330‑K -  Número de teléfono: 985739643 - Correo: sotrasal@gmail.com");

            // Asigna la lista al ListView
            lvLista.ItemsSource = lista;

            // Muestra el ListView
            lvLista.Visibility = Visibility.Visible;
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
