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
            lista.Add("Elemento 1");
            lista.Add("Elemento 2");
            lista.Add("Elemento 3");

            // Asigna la lista al ListView
            lvLista.ItemsSource = lista;

            // Muestra el ListView
            lvLista.Visibility = Visibility.Visible;
        }
        
    }
}
